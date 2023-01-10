using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario
{
    public class mdlUsuario
    {
        private string nome { get; set; }
        private string senha { get;set; }
        public mdlUsuario() { }
        public mdlUsuario(string pNome, string pSenha)
        {
            nome = pNome;
            senha = pSenha;
        }
        public string getNome ()
        {
            return nome;
        }
        public string getSenha()
        {
            return senha;
        }
    }
}
