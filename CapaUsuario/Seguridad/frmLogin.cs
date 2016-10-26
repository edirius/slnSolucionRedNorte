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
        public frmLogin()
        {
            InitializeComponent();
        }
        private void HacerConeccion()
        {
            try
            {
                Conexion.IniciarSesion(Settings.Default.ConexionMySql, "bdcontrolgestantes", "root", "root");
                MessageBox.Show(String.Format("{0}", "Se conecto exitosamente"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void IniciarSesion()
        {
            //string existe = "@a";
            //string user = "@b";
            //try
            //{
            //    int numero;
            //    string Contraseña = oUsuario.ObtenerSHA1(txtcontraseña.Text);
            //    numero = oUsuario.ValidarUsuarioContraseña(txtusuario.Text, Contraseña, existe, user);
            //    Usuario = txtusuario.Text;
            //    //
            //    if (numero == 1)
            //    {
            //        frmMenuTramite MenuTramite = new frmMenuTramite();
            //        MessageBox.Show("Bienvenido al Sistema de Tramite Documentario usuario " + Usuario + ".", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        MenuTramite.Show();
            //        this.Hide();
            //        MenuTramite.obtenerDatos(Usuario);
            //    }
            //    else
            //    {
            //        const string message = "El Usuario no existe o la contraseña es incorrecta.";
            //        const string caption = "Error";
            //        var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txtusuario.Text = ""; txtcontraseña.Text = ""; txtusuario.Focus();
            //    }
            //}
            //catch { }
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
    }
}
