using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuncionarioDAO;
using Funcionario;
using System.Data;

namespace Controlador
{
    public class controlador
    {
        public static string getCracha()
        {
            return daoFuncionario.getCracha();
        }
        public static string getNome()
        {
            return daoFuncionario.getNome();
        }
        public static string getSetor()
        {
            return daoFuncionario.getSetor();
        }
        public static string getCargo()
        {
            return daoFuncionario.getCargo();
        }
        public static bool insert (mdlFuncionario funcionario)
        {
           return daoFuncionario.insert(funcionario);
        }
        public static bool alter(mdlFuncionario funcionario)
        {
            return daoFuncionario.alter(funcionario);
        }
        public static List<mdlFuncionario> read()
        {
            return daoFuncionario.read();
        }
        public static bool delete(string nome)
        {
            return daoFuncionario.delete(nome);
        }
        public static bool searchCracha(int cracha)
        {
            return daoFuncionario.searchCracha(cracha);
        }
        public static DataTable searchName(string nome)
        {
            return daoFuncionario.searchName(nome);
        }
    }
}
