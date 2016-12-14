using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoreo.Administrador
{
    public partial class frmAdministrador : Form
    {
        int saccion;
        string sidtadministrador= "";
        CapaDeNegocios.Obstetra.cUsuario miUsuario = new CapaDeNegocios.Obstetra.cUsuario();
        CapaDeNegocios.Administrador.cAdministrador miAdministrador = new CapaDeNegocios.Administrador.cAdministrador();

        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            txtDNI.Select();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDNI.Text == "" || txtNombre.Text == "" || txtApePaterno.Text == "" || txtApeMaterno.Text == "")
                {
                    MessageBox.Show("Debe tener un DNI, Nombre, Apellido Paterno y Apellido Materno.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtUsuario.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Debe tener un Usuario y Contraseña.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool bOk = false;
                miAdministrador.idtadministrador = sidtadministrador;
                miAdministrador.nombres = txtNombre.Text ;
                miAdministrador.apellidopaterno = txtApePaterno.Text ;
                miAdministrador.apellidomaterno = txtApeMaterno.Text ;
                if (rbtMasculino.Checked == true) { miAdministrador.sexo = "M"; }
                else if (rbtFemenino.Checked == true) { miAdministrador.sexo = "F"; }
                miAdministrador.dni = txtDNI.Text ;
                miAdministrador.fechanacimiento = dtpFechaNacimiento.Value ;
                miAdministrador.direccion = txtDireccion.Text ;
                miAdministrador.telefono = txtCelular.Text;
                miAdministrador.usuario = txtUsuario.Text;
                miAdministrador.password = miUsuario.ObtenerSHA1(txtPassword.Text);

                if (saccion == 1)
                {
                    miAdministrador.CrearAdministrador(miAdministrador);
                    bOk = true;
                }
                if (saccion == 2)
                {
                    miAdministrador.ModificarAdministrador(miAdministrador);
                    bOk = true;
                }
                if (bOk == true)
                {
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("No se puede registrar estos datos", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            DataTable oDataPaciente = new DataTable();
            oDataPaciente = miAdministrador.ListarAdministrador();
            if (txtDNI.Text.Length == 8)
            {
                foreach (DataRow row in oDataPaciente.Select("dni = '" + txtDNI.Text + "'"))
                {
                    MessageBox.Show("El DNI ingresado ya pertenece a otro Administrador.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDNI.Text = "";
                    return;
                }
            }
        }

        public void RecibirDatos(string pidtadministrador, string pnombres, string papellidopaterno, string papellidomaterno, string psexo, string pdni, DateTime pfechanacimiento, string pdireccion, string ptelefono, string pusuario, string ppassword, int paccion)
        {
            sidtadministrador = pidtadministrador;
            txtNombre.Text = pnombres;
            txtApePaterno.Text = papellidopaterno;
            txtApeMaterno.Text = papellidomaterno;
            if (psexo == "M") { rbtMasculino.Checked = true; }
            else if (psexo == "F") { rbtFemenino.Checked = true; }
            txtDNI.Text = pdni;
            dtpFechaNacimiento.Value = pfechanacimiento;
            txtDireccion.Text = pdireccion;
            txtCelular.Text = ptelefono;
            txtUsuario.Text = pusuario;
            txtPassword.Text = ppassword;
            saccion = paccion;
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                if (txtDNI.Text.Length != 8)
                {
                    MessageBox.Show("El DNI ingresado no es el correcto.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDNI.Select();
                    txtDNI.Focus();
                    return;
                }
                txtNombre.Focus();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtApePaterno.Focus();
            }
        }

        private void txtApePaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtApeMaterno.Focus();
            }
        }

        private void txtApeMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rbtFemenino.Focus();
            }
        }

        private void rbtFemenino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtpFechaNacimiento.Focus();
            }
        }

        private void rbtMasculino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtpFechaNacimiento.Focus();
            }
        }

        private void dtpFechaNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCelular.Focus();
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDireccion.Focus();
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtUsuario.Focus();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAceptar.Focus();
            }
        }
    }
}
