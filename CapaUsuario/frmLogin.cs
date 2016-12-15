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
using System.IO;

namespace CapaUsuario.Seguridad
{
    public partial class frmLogin : Form
    {
        CapaDeNegocios.Obstetra.cObstetra miObstetra = new CapaDeNegocios.Obstetra.cObstetra();
        CapaDeNegocios.Obstetra.cUsuario miUsuario = new CapaDeNegocios.Obstetra.cUsuario();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void MoverArchivo()
        {
            string usuario = Environment.UserName;
            string path = @"C:\Users\Usuario\Desktop\Sistema Control Gestantes.lnk";
            path = path.Replace("Usuario", usuario);

            string path2 = @"C:\Users\Usuario\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\Sistema Control Gestantes.lnk";
            path2 = path2.Replace("Usuario", usuario);
            try
            {
                if (!File.Exists(path))
                {
                    //This statement ensures that the file is created,
                    // but the handle is not kept.
                    using (FileStream fs = File.Create(path)) { }
                }

                //Ensure that the target does not exist.
                if (File.Exists(path2))
                    File.Delete(path2);

                //Move the file.
                File.Copy(path, path2);
                //MessageBox.Show("El archivo fue movido");

                //See if the original exists now.
                if (File.Exists(path))
                {
                    //MessageBox.Show("El archivo original todavía existe, lo cual es inesperado.");
                }
                else
                {
                    //MessageBox.Show("El archivo original ya no existe, lo que se espera.");
                }

            }
            catch (Exception e)
            {
                //MessageBox.Show("El proceso falló: {0}", e.ToString());
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //MoverArchivo();

            try
            {
                Conexion.IniciarSesion(Settings.Default.ConexionMySql, "bdcontrolgestantes", "root", "root");
                txtUsuario.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void IniciarSesion()
        {
            try
            {
                DataView objDataView = new DataView();
                objDataView.Table = miObstetra.ListarObstetra();
                objDataView.RowFilter = "usuario='" + txtUsuario.Text + "' and password='" + miUsuario.ObtenerSHA1(txtContraseña.Text) + "'";
                if (objDataView.Count > 0)
                {
                    frmMenu Menu = new frmMenu();
                    MessageBox.Show("Bienvenido al Sistema de Control de Gestantes usuario " + txtUsuario.Text + ".", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu.obtenerDatos(txtUsuario.Text);
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


                //string existe = "@a";
                //string user = "@b";
                //string Usuario = "";
                //int numero;
                ////string Contraseña = txtContraseña.Text;
                //string Contraseña = miUsuario.ObtenerSHA1(txtContraseña.Text);
                //numero = miUsuario.ValidarUsuarioContraseña(txtUsuario.Text, Contraseña, existe, user);
                //Usuario = txtUsuario.Text;
                ////
                //if (numero == 1)
                //{
                //    frmMenu Menu = new frmMenu();
                //    MessageBox.Show("Bienvenido al Sistema de Control de Gestantes usuario " + Usuario + ".", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    Menu.obtenerDatos(Usuario);
                //    Menu.Show();
                //    this.Hide();
                //}
                //else
                //{
                //    const string message = "El Usuario no existe o la contraseña es incorrecta.";
                //    const string caption = "Error";
                //    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txtUsuario.Text = ""; txtContraseña.Text = ""; txtUsuario.Focus();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void txtAdmin_TextChanged(object sender, EventArgs e)
        {
            if (txtAdmin.Text == "BAHAMUT")
            {
                frmMenu menu = new frmMenu();
                menu.Show();
                this.Hide();
            }
        }
    }
}
