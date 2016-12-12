using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario.Obstetra
{
    public partial class frmMantenimientoContraseña : Form
    {

        public frmMantenimientoContraseña()
        {
            InitializeComponent();
        }

        private void frmMantenimientoContraseña_Load(object sender, EventArgs e)
        {
            txtUsuario.Select();
            txtUsuario.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaDeNegocios.Obstetra.cUsuario miUsuario = new CapaDeNegocios.Obstetra.cUsuario();
                CapaDeNegocios.Obstetra.cObstetra miObstetra = new CapaDeNegocios.Obstetra.cObstetra();
                if (cVariables.v_usuario != txtUsuario.Text || cVariables.v_password != miUsuario.ObtenerSHA1(txtPasswordAnterior.Text))
                {
                    MessageBox.Show("El usuario y/o password no es el correcto.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtPasswordNuevo.Text != txtPasswordConfirmar.Text)
                {
                    MessageBox.Show("El nuevo password y su confirmacion son diferentes.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                miObstetra.idtobstetra = cVariables.v_idobstetra;
                miObstetra.usuario = txtUsuario.Text;
                miObstetra.password = miUsuario.ObtenerSHA1(txtPasswordNuevo.Text);

                miObstetra.MantenimientoContraseña(miObstetra);
                MessageBox.Show("La contraseña se modifico satisfactoriamente.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPasswordAnterior.Focus();
            }
        }

        private void txtPasswordAnterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPasswordNuevo.Focus();
            }
        }

        private void txtPasswordNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPasswordConfirmar.Focus();
            }
        }

        private void txtPasswordConfirmar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAceptar.Focus();
            }
        }
    }
}
