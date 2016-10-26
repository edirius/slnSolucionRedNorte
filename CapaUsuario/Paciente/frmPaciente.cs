using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario.Paciente
{
    public partial class frmPaciente : Form
    {
        int saccion;
        string sidtpaciente = "";
        string sidtestablecimientosalud = "";

        public frmPaciente()
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
                CapaDeNegocios.Paciente.cPaciente miPaciente = new CapaDeNegocios.Paciente.cPaciente();
                miPaciente.idtpaciente = sidtpaciente;
                miPaciente.nombres = txtNombre.Text ;
                miPaciente.apellidopaterno = txtApePaterno.Text ;
                miPaciente.apellidomaterno = txtApeMaterno.Text ;
                miPaciente.dni = txtDNI.Text ;
                miPaciente.fechanacimiento = dtpFechaNacimiento.Value ;
                miPaciente.direccion = txtDireccion.Text ;
                miPaciente.telefono = txtCelular.Text ;
                miPaciente.idtestablecimientosalud = sidtestablecimientosalud;

                if (saccion == 1)
                {
                    miPaciente.CrearPaciente(miPaciente);
                    bOk = true;
                }
                if (saccion == 2)
                {
                    miPaciente.ModificarPaciente(miPaciente);
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

        public void RecibirDatos(string pidtpaciente, string pnombres, string papellidopaterno, string papellidomaterno, string pdni, DateTime pfechanacimiento, string pdireccion, string ptelefono, string pidtestablecimientosalud, int paccion)
        {
            sidtpaciente = pidtpaciente;
            txtNombre.Text = pnombres;
            txtApePaterno.Text = papellidopaterno;
            txtApeMaterno.Text = papellidomaterno;
            txtDNI.Text = pdni;
            dtpFechaNacimiento.Value = pfechanacimiento;
            txtDireccion.Text = pdireccion;
            txtCelular.Text = ptelefono;
            sidtestablecimientosalud = pidtestablecimientosalud;
            saccion = paccion;
        }
    }
}
