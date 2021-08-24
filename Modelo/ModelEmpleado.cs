using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ModelEmpleado
    {
        public static DataTable CargarEstadoEmpleado()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tbestadoempleado";
                MySqlCommand cmdtipodoc = new MySqlCommand(string.Format(instruccion), ModelConexion.ObtenerConexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipodoc);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static DataTable CargarEstadoCivil()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tbestadocivil";
                MySqlCommand cmdtipodoc = new MySqlCommand(string.Format(instruccion), ModelConexion.ObtenerConexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipodoc);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static DataTable CargarMunicipios()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tbmunicipio ORDER BY municipio ASC";
                MySqlCommand cmdtipodoc = new MySqlCommand(string.Format(instruccion), ModelConexion.ObtenerConexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipodoc);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static DataTable CargarEstadoEmpleadoInner(string id)
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tbtipodocumento WHERE tipoDocumento = ?param1";
                MySqlCommand cmdtipodoc = new MySqlCommand(string.Format(instruccion), ModelConexion.ObtenerConexion());
                cmdtipodoc.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipodoc);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        public static DataTable CargarEstadoCivilInner(string id)
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tbestadocivil WHERE estadocivil = ?param1";
                MySqlCommand cmdtipodoc = new MySqlCommand(string.Format(instruccion), ModelConexion.ObtenerConexion());
                cmdtipodoc.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipodoc);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        public static DataTable CargarMunicipioInner(string id)
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tbmunicipio WHERE municipio = ?param1";
                MySqlCommand cmdtipodoc = new MySqlCommand(string.Format(instruccion), ModelConexion.ObtenerConexion());
                cmdtipodoc.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipodoc);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        //CRUD
        public static bool RegistrarEmpleado(string pnombres, string papellidos, string pnacimiento,string pdireccion, string pDUI, string pNIT, string pemail, int pidestadocivil, int pidestadoempleado, int pidmunicipio)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbempleado(nombre, apellidos, Nacimiento, direccion, DUI, NIT, email, idestadocivil, idestodoempleado, idmunicipio) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}', '{9}')", pnombres, papellidos, pnacimiento, pdireccion, pDUI, pNIT, pemail, pidestadocivil, pidestadoempleado, pidmunicipio), ModelConexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        public static DataTable ObtenerlistaEmpleados()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tbempleadoinner";
                MySqlCommand cmdtipodoc = new MySqlCommand(string.Format(instruccion), ModelConexion.ObtenerConexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipodoc);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static bool ActualizarEmpleado(int pidempleado, string pnombres, string papellidos, string pnacimiento, string pdireccion, string pDUI, string pNIT, string pemail, int pidestadocivil, int pidestadoempleado, int pidmunicipio)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbempleados SET nombre = '" + pnombres + "', apellidos = '" + papellidos + "', Nacimiento = '"+pnacimiento+"', direccion = '"+pdireccion+"', DUI = '"+pDUI+"', NIT = '"+pNIT+"', email = '"+pemail+"', idestadocivil '"+pidestadocivil+"', idestadoempleado = '"+pidestadoempleado+"', idmunicipio = '"+pidmunicipio+"' WHERE idempleado = '" + pidempleado + "'"), ModelConexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        public static bool EliminarEmpleados(int pid)
        {
            bool retorno;
            try
            {
                string query = "DELETE FROM tbempleado WHERE idempleado = '" + pid + "'";
                MySqlCommand cmddel = new MySqlCommand(string.Format(query),
                                                        ModelConexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
    }
}
