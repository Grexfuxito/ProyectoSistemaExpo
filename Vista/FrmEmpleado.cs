using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Controlador;

namespace Vista
{
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        public DataTable datosEmpleados;
        public EmpleadoController objempleado;

        void CargarEstadoEmpleado()
        {
            try
            {
                DataTable dataTipoDoc = EmpleadoController.ObtenerEstadEempleado();
                CmbEstadoEmpleado.DataSource = dataTipoDoc;
                CmbEstadoEmpleado.DisplayMember = "estadoempleado";
                CmbEstadoEmpleado.ValueMember = "idestadoempleado";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los tipos de documentos.", "Error de carga",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
        void CargarEstadoCivil()
        {
            try
            {
                DataTable dataEstCivil = EmpleadoController.ObtenerEstadoCivil();
                CmbEstadoCivil.DataSource = dataEstCivil;
                CmbEstadoCivil.DisplayMember = "estadocivil";
                CmbEstadoCivil.ValueMember = "idestadocivil";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar estados civiles.", "Error de carga",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }

        }
        void CargarMunicipios()
        {
            try
            {
                DataTable dataMunicipio = EmpleadoController.ObtenerMunicipio();
                CmbMunicipio.DataSource = dataMunicipio;
                CmbMunicipio.DisplayMember = "municipio";
                CmbMunicipio.ValueMember = "idMunicipio";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los municipios.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }

        void CargarDatos()
        {
            try
            {
                CargarEstadoEmpleado();
                CargarEstadoCivil();
                CargarMunicipios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos." + ex.Message, "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarGridDatos();
        }

        //CRUD
        void CargarGridDatos()
        {
            datosEmpleados = EmpleadoController.CargarEmpleados_Controller();
            DgvEmpleado.DataSource = datosEmpleados;
        }

        void EnvioDatos()
        {
            try
            {
                string nombres, apellidos, nacimiento, direccion, DUI, NIT, email;
                int idestadocivil, idestadoempleado, idmunicipio;
                nombres = TxTNombre.Text;
                apellidos = TxTApellido.Text;
                nacimiento = DataTimeNacimiento.Text;
                direccion = TxTDireccion.Text;
                DUI = TxTDUI.Text;
                NIT = TxTNIT.Text;
                email = TxTEmail.Text;
                idestadocivil = Convert.ToInt16(CmbEstadoCivil.SelectedValue);
                idestadoempleado = Convert.ToInt16(CmbEstadoEmpleado.SelectedValue);
                idmunicipio = Convert.ToInt16(CmbMunicipio.SelectedValue);
                //INSTANCIAR OBJETO
                objempleado = new EmpleadoController(nombres, apellidos, nacimiento, direccion, DUI, NIT, email, idestadocivil, idestadoempleado, idmunicipio);
                bool respuesta = objempleado.EnviarDatosController();
                if (respuesta == true)
                {
                    MessageBox.Show("Usuario registrado exitosamente", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario no pudo ser registrado", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Oops!, ocurrió un error al registrar al empleado, consulte con el administrador del sistema.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ActualizarDatos()
        {
            try
            {
                string nombres, apellidos, nacimiento, direccion, DUI, NIT, email;
                int idestadocivil, idestadoempleado, idmunicipio;
                nombres = TxTNombre.Text;
                apellidos = TxTApellido.Text;
                nacimiento = DataTimeNacimiento.Text;
                direccion = TxTDireccion.Text;
                DUI = TxTDUI.Text;
                NIT = TxTNIT.Text;
                email = TxTEmail.Text;
                idestadocivil = Convert.ToInt16(CmbEstadoCivil.SelectedValue);
                idestadoempleado = Convert.ToInt16(CmbEstadoEmpleado.SelectedValue);
                idmunicipio = Convert.ToInt16(CmbMunicipio.SelectedValue);
                //INSTANCIAR OBJETO
                EmpleadoController.idempleado = Convert.ToInt16(txtidempleado.Text);
                objempleado = new EmpleadoController(nombres, apellidos, nacimiento, direccion, DUI, NIT, email, idestadocivil, idestadoempleado, idmunicipio);
                bool respuesta = objempleado.ActualizarDatosController();
                if (respuesta == true)
                {
                    MessageBox.Show("Usuario actualizado exitosamente", "Confirmación de actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario no pudo ser actualizado", "Proceso de actualización incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error crítico.", "Errr C001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void EliminarDatos()
        {
            EmpleadoController.idempleado = Convert.ToInt16(txtidempleado.Text);
            bool respuesta = EmpleadoController.EliminarEmpleadoController();
            if (respuesta == true)
            {
                MessageBox.Show("El registro ha sido eliminado", "Confirmación",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El registro no fue eliminado", "Confirmación",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            EnvioDatos();
            CargarGridDatos();
        }

        private void DgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = DgvEmpleado.CurrentRow.Index;

            txtidempleado.Text = DgvEmpleado[0, posicion].Value.ToString();
            TxTNombre.Text = DgvEmpleado[1, posicion].Value.ToString();
            TxTApellido.Text = DgvEmpleado[2, posicion].Value.ToString();
            DataTimeNacimiento.Text = DgvEmpleado[3, posicion].Value.ToString();
            TxTDireccion.Text = DgvEmpleado[4, posicion].Value.ToString();
            TxTDUI.Text = DgvEmpleado[5, posicion].Value.ToString();
            TxTNIT.Text = DgvEmpleado[6, posicion].Value.ToString();
            TxTEmail.Text = DgvEmpleado[7, posicion].Value.ToString();

            string idestadocivil = DgvEmpleado[8, posicion].Value.ToString();
            CmbEstadoEmpleado.DataSource = EmpleadoController.CargarEstadoCivilInnerJoin_Controller(idestadocivil);
            CmbEstadoEmpleado.DisplayMember = "estadocivil";
            CmbEstadoEmpleado.ValueMember = "idestadocivil";

            string idestadoempleado = DgvEmpleado[9, posicion].Value.ToString();
            CmbEstadoEmpleado.DataSource = EmpleadoController.CargarEstadoEmpleadoInnerJoin_Controller(idestadoempleado);
            CmbEstadoEmpleado.DisplayMember = "estadoempleado";
            CmbEstadoEmpleado.ValueMember = "idestadoempleado";

            string idmunicipio = DgvEmpleado[10, posicion].Value.ToString();
            CmbMunicipio.DataSource = EmpleadoController.CargarMunicipiosInnerJoin_Controller(idmunicipio);
            CmbMunicipio.DisplayMember = "municipio";
            CmbMunicipio.ValueMember = "idmunicipio";
        }
    }
}
