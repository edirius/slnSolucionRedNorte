using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaUsuario.Properties;
using CapaDeDatos;

namespace CapaUsuario.Seguridad
{
    public partial class frmLogin : Form
    {
        CapaDeNegocios.Obstetra.cUsuario miUsuario = new CapaDeNegocios.Obstetra.cUsuario();
        
        public frmLogin()
        {
            InitializeComponent();
            HacerConeccion();
        }
        private void HacerConeccion()
        {
            try
            {
                Conexion.IniciarSesion(Settings.Default.ConexionMySql, "bdcontrolgestantes", "root", "root");
                //MessageBox.Show(String.Format("{0}", "Se conecto exitosamente"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string Usuario;
        public void IniciarSesion()
        {
            string existe = "@a";
            string user = "@b";
            try
            {
                int numero;
                //string Contraseña = txtContraseña.Text;
                string Contraseña = miUsuario.ObtenerSHA1(txtContraseña.Text);
                numero = miUsuario.ValidarUsuarioContraseña(txtUsuario.Text, Contraseña, existe, user);
                Usuario = txtUsuario.Text;
                //
                if (numero == 1)
                {
                    frmMenu Menu = new frmMenu();
                    MessageBox.Show("Bienvenido al Sistema de Control de Gestantes usuario " + Usuario + ".", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu.obtenerDatos(Usuario);
                    Menu.Show();
                    this.Hide();
                   
                }
                else
                {
                    const string message = "El Usuario no existe o la contraseña es incorrecta.";
                    const string caption = "Error";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Text = ""; txtContraseña.Text = ""; txtUsuario.Focus();
                }
            }
            catch { }
        }
        private void cbVer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVer.Checked)
            {
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '●';
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                IniciarSesion();
            }
        }
    }
}
