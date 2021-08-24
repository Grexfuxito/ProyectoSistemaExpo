using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ModelConexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection retorno;
            string server, database, user, password, puerto;
            server = "127.0.0.1";
            database = "dbsistemadeseguridad";
            user = "root";
            password = "";
            puerto = "3306";
            try
            {
                retorno = new MySqlConnection("server = " + server +
                                              "; database =" + database +
                                              "; uid = " + user +
                                              "; pwd = " + password +
                                              "; port = " + puerto);
                retorno.Open();
                return retorno;
            }
            catch (Exception)
            {
                return retorno = null;
            }
        }
    }
}
