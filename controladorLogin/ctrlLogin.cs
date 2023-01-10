using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuario;
using UsuarioDAO;

namespace controladorLogin
{
    public class ctrlLogin
    {
        public static bool autenticar(mdlUsuario usuario)
        {
           return daoUsuario.Autenticar(usuario);
        }

    }
}
