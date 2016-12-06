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

        CapaDeNegocios.Paciente.cPaciente miPaciente = new CapaDeNegocios.Paciente.cPaciente();

        public frmPaciente()
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
                bool bOk = false;
                miPaciente.idtpaciente = sidtpaciente;
                miPaciente.codigohistoriaclinica = txtCodigoHistoriaClinica.Text;
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
                    CapaDeNegocios.cSiguienteCodigo miSiguienteCodigo = new CapaDeNegocios.cSiguienteCodigo();
                    foreach (DataRow row in miSiguienteCodigo.SiguientesCodigo("tpaciente", sidtestablecimientosalud).Rows)
                    {
                        miPaciente.idtpaciente = row[0].ToString();
                    }
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
                    if (saccion == 1)
                    {
                        MessageBox.Show("Gestante agregado correctamente.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (saccion == 2)
                    {
                        MessageBox.Show("Datos Gestante modificados correctamente.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
            oDataPaciente = miPaciente.ListarPaciente(sidtestablecimientosalud);
            if (txtDNI.Text.Length == 8 && txtDNI.Text != "")
            {
                foreach (DataRow row in oDataPaciente.Select("dni = '" + txtDNI.Text + "'"))
                {
                    MessageBox.Show("El DNI ingresado ya pertenece a otra Gestante.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDNI.Text = "";
                    return;
                }
            }
        }

        private void txtCodigoHistoriaClinica_TextChanged(object sender, EventArgs e)
        {
            DataTable oDataPaciente = new DataTable();
            oDataPaciente = miPaciente.ListarPaciente(sidtestablecimientosalud);
            if (txtCodigoHistoriaClinica.Text != "")
            {
                foreach (DataRow row in oDataPaciente.Select("codigohistoriaclinica = '" + txtCodigoHistoriaClinica.Text + "'"))
                {
                    MessageBox.Show("La Historia Clinica ingresada ya pertenece a otra Gestante.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigoHistoriaClinica.Text = "";
                    return;
                }
            }
        }

        public void RecibirDatos(string pidtpaciente, string scodigohistoriaclinica, string pnombres, string papellidopaterno, string papellidomaterno, string pdni, DateTime pfechanacimiento, string pdireccion, string ptelefono, string pidtestablecimientosalud, int paccion)
        {
            sidtpaciente = pidtpaciente;
            txtCodigoHistoriaClinica.Text = scodigohistoriaclinica;
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
                txtCodigoHistoriaClinica.Focus();
            }
        }

        private void txtCodigoHistoriaClinica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
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
                btnAceptar.Focus();
            }
        }
    }
}
