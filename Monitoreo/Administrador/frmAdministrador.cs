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

        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                bool bOk = false;
                CapaDeNegocios.Administrador.cAdministrador miAdministrador = new CapaDeNegocios.Administrador.cAdministrador();
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
                miAdministrador.password = txtPassword.Text;

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

            if (txtDNI.Text.Length == 8)
            {
                foreach (DataRow row in oDataPaciente.Select("dni = '" + txtDNI.Text + "'"))
                {
                    MessageBox.Show("El DNI ingresado ya pertenece a otro Obrero.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
