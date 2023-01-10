using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    public class mdlFuncionario
    {
        private string cracha { get; set; }
        private string nome { get; set; }
        private string setor { get; set; }
        private string cargo { get; set; }

        public mdlFuncionario(string pCracha, string pNome, string pSetor, string pCargo)
        {
            cracha = pCracha;
            nome = pNome;   
            setor = pSetor; 
            cargo = pCargo;
        }
        public string getCracha()
        {
            return cracha;
        }
        public string getNome()
        {
            return nome;
        }
        public string getSetor()
        {
            return setor;
        }
        public string getCargo()
        {
            return cargo;
        }
    }
}
