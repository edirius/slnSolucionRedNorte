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
    public partial class frmObstetra : Form
    {
        int saccion = 0;
        string sidtobstetra= "";
        string sidtestablecimientosalud = "";
        CapaDeNegocios.Obstetra.cUsuario miUsuario = new CapaDeNegocios.Obstetra.cUsuario();
        CapaDeNegocios.Obstetra.cObstetra miObstetra = new CapaDeNegocios.Obstetra.cObstetra();

        public frmObstetra()
        {
            InitializeComponent();
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            txtDNI.Select();
            txtDNI.Focus();
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
                miObstetra.idtobstetra = sidtobstetra;
                miObstetra.nombres = txtNombre.Text ;
                miObstetra.apellidopaterno = txtApePaterno.Text ;
                miObstetra.apellidomaterno = txtApeMaterno.Text ;
                if (rbtMasculino.Checked == true) { miObstetra.sexo = "M"; }
                else if (rbtFemenino.Checked == true) { miObstetra.sexo = "F"; }
                miObstetra.dni = txtDNI.Text ;
                miObstetra.fechanacimiento = dtpFechaNacimiento.Value ;
                miObstetra.direccion = txtDireccion.Text ;
                miObstetra.telefono = txtCelular.Text;
                miObstetra.tituloprofesional = txtTituloProfesional.Text;
                miObstetra.idtestablecimientosalud = sidtestablecimientosalud;
                miObstetra.usuario = txtUsuario.Text;
                miObstetra.password = miUsuario.ObtenerSHA1(txtPassword.Text);
                miObstetra.categoria = "OBSTETRA";

                if (saccion == 1)
                {
                    CapaDeNegocios.cSiguienteCodigo miSiguienteCodigo = new CapaDeNegocios.cSiguienteCodigo();
                    foreach (DataRow row in miSiguienteCodigo.SiguientesCodigo("tobstetra", sidtestablecimientosalud).Rows)
                    {
                        miObstetra.idtobstetra = row[0].ToString();
                    }
                    miObstetra.CrearObstetra(miObstetra);
                    bOk = true;
                }
                if (saccion == 2)
                {
                    miObstetra.ModificarObstetra(miObstetra);
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
            oDataPaciente = miObstetra.ListarObstetra();
            if (saccion != 0)
            {
                if (txtDNI.Text.Length == 8)
                {
                    foreach (DataRow row in oDataPaciente.Select("dni = '" + txtDNI.Text + "'"))
                    {
                        MessageBox.Show("El DNI ingresado ya pertenece a otro Obstetra.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDNI.Text = "";
                        return;
                    }
                }
            }
        }

        public void RecibirDatos(string pidtobstetra, string pnombres, string papellidopaterno, string papellidomaterno, string psexo, string pdni, DateTime pfechanacimiento, string pdireccion, string ptelefono, string ptituloprofesional, string pidtestablecimientosalud, string pusuario, string ppassword, int paccion)
        {
            sidtobstetra = pidtobstetra;
            txtNombre.Text = pnombres;
            txtApePaterno.Text = papellidopaterno;
            txtApeMaterno.Text = papellidomaterno;
            if (psexo == "M") { rbtMasculino.Checked = true; }
            else if (psexo == "F") { rbtFemenino.Checked = true; }
            txtDNI.Text = pdni;
            dtpFechaNacimiento.Value = pfechanacimiento;
            txtDireccion.Text = pdireccion;
            txtCelular.Text = ptelefono;
            txtTituloProfesional.Text = ptituloprofesional;
            sidtestablecimientosalud = pidtestablecimientosalud;
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
                txtTituloProfesional.Focus();
            }
        }

        private void txtTituloProfesional_KeyPress(object sender, KeyPressEventArgs e)
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
