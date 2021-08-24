using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (lblusuario.Visible == false)
            {
                lblusuario.Visible = true;
                txtusuario.Clear();
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text.Trim() == "")
            {
                lblusuario.Visible = false;
                txtusuario.Text = "Ingrese su usuario";
            }
        }

        private void txtclave_Enter(object sender, EventArgs e)
        {
            if (lblclave.Visible == false)
            {
                lblclave.Visible = true;
                txtclave.Clear();
                txtclave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtclave.Text.Trim() == "")
            {
                lblclave.Visible = false;
                txtclave.Text = "Ingrese su clave";
                txtclave.UseSystemPasswordChar = false;
            }
        }

        void EnviarDatosLog()
        {
            AtributosLogin.usuario = txtusuario.Text;
            string clave = (txtclave.Text);
            AtributosLogin.clave = clave;
            bool respuesta = LoginController.Acceso_Controller();
            if (respuesta == true)
            {
                FrmLogin empleados = new FrmLogin();
                empleados.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto",
                                "Error en credenciales",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btnacceder_Click(object sender, EventArgs e)
        {
            EnviarDatosLog();
        }
    }
}
