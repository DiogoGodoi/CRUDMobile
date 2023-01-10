using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Usuario;

namespace UsuarioDAO
{
    public class daoUsuario
    {
        private static string nome { get; set; }
        private static string senha { get; set; }
        private static string ip { get; set; }
        private static string porta { get; set; }
        public static string getNome()
        {
            return nome;
        }
        public static string getSenha()
        {
            return senha;
        }
        public static string getIp()
        {
            return ip;
        }
        public static string getPort()
        {
            return porta;
        }
        public daoUsuario(string pNome, string pSenha, string pIp, string pPorta)
        {
            nome = pNome;
            senha = pSenha;
            ip = pIp;
            porta = pPorta;
        }
        public static bool Autenticar(mdlUsuario usuario)
        {
                var acessDB = new MySqlConnectionStringBuilder {
                    Server = ip,
                    UserID = nome,
                    Password = senha,
                    Database = "gerador",
                    Port = Convert.ToUInt32(porta),
                };

                MySqlConnection conn = new MySqlConnection(acessDB.ConnectionString);
            
            try
            {
                conn.Open();
                string query = "SELECT nome, senha FROM usuario WHERE nome = @nome";
                MySqlCommand comando = new MySqlCommand(query, conn);
                comando.Parameters.AddWithValue("@nome", usuario.getNome());
                var leitura = comando.ExecuteReader();
                
                if (leitura.Read() == true )
                {
                    if (leitura["nome"].ToString() == usuario.getNome() && leitura["senha"].ToString() == usuario.getSenha())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                return true;
            }
            catch
            {
                return false;
                throw;
            }
        }
    }
}
