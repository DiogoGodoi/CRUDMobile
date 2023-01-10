using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySqlConnector;
using Funcionario;
using System.Data.Entity;
using System.Security.Cryptography;
using UsuarioDAO;

namespace FuncionarioDAO
{
    public class daoFuncionario
    {
        private static string cracha { get; set; }
        private static string nome { get; set; }
        private static string setor { get; set; }
        private static string cargo { get; set; }
        public static string user { get; set; }
        public static string password { get; set; }
        public static string getCracha()
        {
            return cracha;
        }
        public static string getNome()
        {
            return nome;
        }
        public static string getSetor()
        {
            return setor;
        }
        public static string getCargo()
        {
            return cargo;
        }
        public static string getUser()
        {
            return user;
        }
        public static string getPassword()
        {
            return password;
        }
        public static bool insert(mdlFuncionario funcionario)
        {
            var db = new MySqlConnectionStringBuilder
            {
                Server = daoUsuario.getIp(),
                UserID = daoUsuario.getNome(),
                Password = daoUsuario.getSenha(),
                Database = "gerador",
                Port = Convert.ToUInt32(daoUsuario.getPort()),
            };

            MySqlConnection conn = new MySqlConnection(db.ConnectionString);
            try
            {
                    string query = "INSERT INTO Funcionario (cracha, nome, setor, cargo) VALUES (@cracha, @nome, @setor, @cargo)";
                    MySqlCommand comando = new MySqlCommand(query, conn);
                    comando.Parameters.AddWithValue("@cracha", int.Parse(funcionario.getCracha()));
                    comando.Parameters.AddWithValue("@nome", funcionario.getNome());
                    comando.Parameters.AddWithValue("@setor", funcionario.getSetor());
                    comando.Parameters.AddWithValue("@cargo", funcionario.getCargo());
                    conn.Open();
                    if(comando.ExecuteNonQuery() >= -1)
                    {
                    conn.Close();
                    return true;
                    }
                    else
                    {
                        conn.Close();
                        return false;
                    };
            }
            catch
            {
                conn.Close();
                return false;
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool alter(mdlFuncionario funcionario)
        {
            var db = new MySqlConnectionStringBuilder
            {
                Server = daoUsuario.getIp(),
                UserID = daoUsuario.getNome(),
                Password = daoUsuario.getSenha(),
                Database = "gerador",
                Port = Convert.ToUInt32(daoUsuario.getPort()),
            };

            MySqlConnection conn = new MySqlConnection(db.ConnectionString);
           
                    conn.Open();
                    string query = "UPDATE Funcionario SET cracha = @cracha, nome = @nome, setor = @setor, cargo = @cargo WHERE cracha LIKE @pCracha";
                    MySqlCommand comando = new MySqlCommand(query, conn);
                    comando.Parameters.AddWithValue("@cracha", funcionario.getCracha());
                    comando.Parameters.AddWithValue("@nome", funcionario.getNome());
                    comando.Parameters.AddWithValue("@setor", funcionario.getSetor());
                    comando.Parameters.AddWithValue("@cargo", funcionario.getCargo());
                    comando.Parameters.AddWithValue("@pCracha", funcionario.getCracha());
                    comando.ExecuteNonQuery();
                    conn.Close();
                
                return true;
         
        }
        public static List<mdlFuncionario> read()
        {
            List<mdlFuncionario> list = new List<mdlFuncionario>();

            var db = new MySqlConnectionStringBuilder
            {
                Server = daoUsuario.getIp(),
                UserID = daoUsuario.getNome(),
                Password = daoUsuario.getSenha(),
                Database = "gerador",
                Port = Convert.ToUInt32(daoUsuario.getPort()),
            };

            MySqlConnection conn = new MySqlConnection(db.ConnectionString);
            try
            {
                conn.Open();
                string query = "SELECT * FROM Funcionario ORDER BY nome ASC";
                MySqlCommand comando = new MySqlCommand(query, conn);
                comando.CommandType = CommandType.Text;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                var leitura = comando.ExecuteReader();
                if (leitura.Read() == true)
                {
                    foreach (DataRow item in tabela.Rows)
                    {
                        var cracha = item["cracha"].ToString();
                        var nome = item["nome"].ToString();
                        var setor = item["setor"].ToString();
                        var cargo = item["cargo"].ToString();
                        list.Add(new mdlFuncionario(cracha, nome, setor, cargo));
                    }
                    conn.Close();
                    return list;
                }
                else
                {
                    conn.Close();
                    return null;
                }
            }
            catch
            {
                conn.Close();
                return null;
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool delete(string pNome)
        {
            var db = new MySqlConnectionStringBuilder
            {
                Server = daoUsuario.getIp(),
                UserID = daoUsuario.getNome(),
                Password = daoUsuario.getSenha(),
                Database = "gerador",
                Port = Convert.ToUInt32(daoUsuario.getPort()),
            };

            MySqlConnection conn = new MySqlConnection(db.ConnectionString);
            try
            {
                    conn.Open();
                    string query = "DELETE FROM Funcionario WHERE nome = @nome";
                    MySqlCommand comando = new MySqlCommand(query, conn);
                    comando.Parameters.AddWithValue("@nome", pNome);
                    comando.ExecuteNonQuery();
                    conn.Close();
                    return true;
            }
            catch
            {
                conn.Close();
                return false;
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool searchCracha(int pCracha)
        {
            var db = new MySqlConnectionStringBuilder
            {
                Server = daoUsuario.getIp(),
                UserID = daoUsuario.getNome(),
                Password = daoUsuario.getSenha(),
                Database = "gerador",
                Port = Convert.ToUInt32(daoUsuario.getPort()),
            };

            MySqlConnection conn = new MySqlConnection(db.ConnectionString);
            try
            {
                conn.Open();
                string query = "SELECT * FROM Funcionario WHERE cracha=@cracha";
                MySqlCommand comando = new MySqlCommand(query, conn);
                comando.Parameters.AddWithValue("@cracha", pCracha);
                var leitura = comando.ExecuteReader();
                if (leitura.Read() == true)
                {
                cracha = leitura["cracha"].ToString();
                nome = leitura["nome"].ToString();
                setor = leitura["setor"].ToString();
                cargo = leitura["cargo"].ToString();  
                conn.Close();
                return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch
            {
                conn.Close();
                return false;
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public static DataTable searchName(string pNome)
        {
            var db = new MySqlConnectionStringBuilder
            {
                Server = "177.67.158.126",
                UserID = daoUsuario.getNome(),
                Password = daoUsuario.getSenha(),
                Database = "gerador",
                Port = 4550,
            };

            MySqlConnection conn = new MySqlConnection(db.ConnectionString);
            try
            {
                conn.Open();
                string query = "SELECT * FROM Funcionario WHERE nome LIKE @nome";
                MySqlCommand comando = new MySqlCommand(query, conn);
                comando.Parameters.AddWithValue("@nome", pNome + "%");
                comando.CommandType = CommandType.Text;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                var leitura = comando.ExecuteReader();
                if (leitura.Read() == true)
                {
                    cracha = leitura["cracha"].ToString();
                    nome = leitura["nome"].ToString();
                    setor = leitura["setor"].ToString();
                    cargo = leitura["cargo"].ToString();
                    conn.Close();
                    return tabela;
                }
                else
                {
                    conn.Close();
                    return null;
                }
            }
            catch
            {
                conn.Close();
                return null;
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
