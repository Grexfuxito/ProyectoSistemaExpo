using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controlador
{
    public class AtributosLogin
    {
        public static string usuario { get; set; }
        public static string clave { get; set; }
    }

    public class LoginController : AtributosLogin
    {
        public static bool Acceso_Controller()
        {
            return ModelLogin.Acceso(usuario, clave);
        }
    }
}
