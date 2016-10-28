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
    public partial class frmMantenimientoPaciente : Form
    {
        string sidtpaciente = "";
        string snombres = "";
        string sapellidopaterno = "";
        string sapellidomaterno = "";
        string sdni = "";
        DateTime sfechanacimiento;
        string sdireccion = "";
        string stelefono = "";
        string sidtestablecimientosalud = "";
        CapaDeNegocios.Paciente.cPaciente miPaciente = new CapaDeNegocios.Paciente.cPaciente();

        public frmMantenimientoPaciente(string pidestablecimientosalud)
        {
            sidtestablecimientosalud = pidestablecimientosalud;
            InitializeComponent();
        }

        private void frmMantenimientoPaciente_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sidtpaciente = Convert.ToString(dgvPacientes.Rows[e.RowIndex].Cells["idtpaciente"].Value);
            snombres = Convert.ToString(dgvPacientes.Rows[e.RowIndex].Cells["nombres"].Value);
            sapellidopaterno = Convert.ToString(dgvPacientes.Rows[e.RowIndex].Cells["apellidopaterno"].Value);
            sapellidomaterno = Convert.ToString(dgvPacientes.Rows[e.RowIndex].Cells["apellidomaterno"].Value);
            sdni = Convert.ToString(dgvPacientes.Rows[e.RowIndex].Cells["dni"].Value);
            sfechanacimiento = Convert.ToDateTime(dgvPacientes.Rows[e.RowIndex].Cells["fechanacimiento"].Value);
            sdireccion = Convert.ToString(dgvPacientes.Rows[e.RowIndex].Cells["direccion"].Value);
            stelefono = Convert.ToString(dgvPacientes.Rows[e.RowIndex].Cells["telefono"].Value);
            sidtestablecimientosalud = Convert.ToString(dgvPacientes.Rows[e.RowIndex].Cells["idtestablecimientosalud"].Value);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmPaciente fPaciente = new frmPaciente();
            fPaciente.RecibirDatos("", "", "", "", "", DateTime.Today, "", "", sidtestablecimientosalud, 1);
            if (fPaciente.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (sidtpaciente == "")
            {
                MessageBox.Show("Debe seleccionar nuevamente los datos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmPaciente fPaciente = new frmPaciente();
            fPaciente.RecibirDatos(sidtpaciente, snombres, sapellidopaterno, sapellidomaterno, sdni, sfechanacimiento, sdireccion, stelefono, sidtestablecimientosalud, 2);
            if (fPaciente.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (sidtpaciente == "")
            {
                MessageBox.Show("Debe seleccionar nuevamente los datos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Está seguro que desea eliminar el Maestro Descuentos", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            miPaciente.EliminarPaciente(sidtpaciente);
            CargarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatos()
        {
            try
            {
                //dgvPaciente.Rows.Clear();
                //foreach (DataRow row in miPaciente.ListarPaciente("E0002").Rows)
                //{
                //    dgvPaciente.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
                //}
                dgvPacientes.DataSource = miPaciente.ListarPaciente(sidtestablecimientosalud);
                if (dgvPacientes.Rows.Count > 0)
                {
                    dgvPacientes.Rows[0].Selected = true;
                    DataGridViewCellEventArgs ceo = new DataGridViewCellEventArgs(0, 0);
                    dgvPacientes_CellClick(dgvPacientes, ceo);
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
    }
}
