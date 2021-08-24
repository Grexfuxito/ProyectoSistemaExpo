using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;

namespace Controlador
{
    public class ConexionController
    {
        public static MySqlConnection Conexion()
        {
            return ModelConexion.ObtenerConexion();
        }
    }
}
