using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controlador
{
    public class EmpleadoController
    {
        public static DataTable ObtenerEstadEempleado()
        {
            return ModelEmpleado.CargarEstadoEmpleado();
        }

        public static DataTable ObtenerEstadoCivil()
        {
            return ModelEmpleado.CargarEstadoCivil();
        }

        public static DataTable ObtenerMunicipio()
        {
            return ModelEmpleado.CargarMunicipios();
        }

        public static DataTable CargarEmpleados_Controller()
        {
            return ModelEmpleado.ObtenerlistaEmpleados();
        }

        public static DataTable CargarEstadoEmpleadoInnerJoin_Controller(string id)
        {
            return ModelEmpleado.CargarEstadoEmpleadoInner(id);
        }

        public static DataTable CargarEstadoCivilInnerJoin_Controller(string id)
        {
            return ModelEmpleado.CargarEstadoCivilInner(id);
        }

        public static DataTable CargarMunicipiosInnerJoin_Controller(string id)
        {
            return ModelEmpleado.CargarMunicipioInner(id);
        }

        //ATRIBUTOS
        public static int idempleado { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string nacimiento { get; set; }
        public string direccion { get; set; }
        public string DUI { get; set; }
        public string NIT { get; set; }
        public string email { get; set; }
        public int idestadocivil { get; set; }
        public int idestadoempleado { get; set; }
        public int idmunicipio { get; set; }

        //CONSTRUCTOR
        public EmpleadoController(string pnombres, string papellidos, string pnacimiento, string pdireccion, string pDUI, string pNIT, string pemail, int pidestadocivil, int pidestadoempleado, int pidmunicipio)
        {
            nombre = pnombres;
            apellidos = papellidos;
            nacimiento = pnacimiento;
            direccion = pdireccion;
            DUI = pDUI;
            NIT = pNIT;
            email = pemail;
            idestadocivil = pidestadocivil;
            idestadoempleado = pidestadoempleado;
            idmunicipio = pidmunicipio;
        }

        //CRUD
        public bool EnviarDatosController()
        {
            return ModelEmpleado.RegistrarEmpleado(nombre, apellidos, nacimiento, direccion, DUI, NIT, email, idestadocivil, idestadoempleado, idmunicipio);
        }

        public bool ActualizarDatosController()
        {
            return ModelEmpleado.ActualizarEmpleado(idempleado, nombre, apellidos, nacimiento, direccion, DUI, NIT, email, idestadocivil, idestadoempleado, idmunicipio);
        }

        public static bool EliminarEmpleadoController()
        {
            return ModelEmpleado.EliminarEmpleados(idempleado);
        }
    }
}
