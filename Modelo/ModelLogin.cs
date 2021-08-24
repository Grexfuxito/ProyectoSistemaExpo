using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelLogin
    {
        public static bool Acceso(string usuario, string clave)
        {
            bool retorno = false;
            try
            {
                int activo = 1;
                string query = "SELECT * FROM tbusuario WHERE usuario = BINARY ?param1 AND clave = BINARY ?param2 AND idusuario = ?param3";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConexion.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1", usuario));
                cmdselect.Parameters.Add(new MySqlParameter("param2", clave));
                cmdselect.Parameters.Add(new MySqlParameter("param3", activo));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }
    }
}
