using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario.Pacientes
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
        CapaDeNegocios.cPaciente miPaciente = new CapaDeNegocios.cPaciente();

        public frmMantenimientoPaciente()
        {
            InitializeComponent();
        }

        private void dgvPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //sidtmaestrodescuentos = Convert.ToInt32(dgvPaciente.Rows[e.RowIndex].Cells[0].Value);
            //scodigo = Convert.ToString(dgvPaciente.Rows[e.RowIndex].Cells[1].Value);
            //sdescripcion = Convert.ToString(dgvPaciente.Rows[e.RowIndex].Cells[2].Value);
            //scalculo = Convert.ToString(dgvPaciente.Rows[e.RowIndex].Cells[3].Value);
            //sabreviacion = Convert.ToString(dgvPaciente.Rows[e.RowIndex].Cells[4].Value);
        }

        private void frmMantenimientoPaciente_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmPaciente fPaciente = new frmPaciente();
            //fPaciente.RecibirDatos(0, "", "", "", "", 1);
            if (fPaciente.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //CargarDatos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (sidtpaciente == "" && dgvPaciente.SelectedRows.Count > 0)
            {
                MessageBox.Show("Debe seleccionar nuevamente los datos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmPaciente fPaciente = new frmPaciente();
            //fPaciente.RecibirDatos(sidtmaestrodescuentos, scodigo, sdescripcion, scalculo, sabreviacion, 2);
            if (fPaciente.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (sidtpaciente == "" && dgvPaciente.SelectedRows.Count > 0)
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
            //dgvPaciente.Rows.Clear();
            //foreach (DataRow row in miPaciente.ListarPaciente("E0002").Rows)
            //{
            //    dgvPaciente.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
            //}
            dgvPaciente.DataSource = miPaciente.ListarPaciente("E0002");
            if (dgvPaciente.Rows.Count > 0)
            {
                dgvPaciente.Rows[0].Selected = true;
                DataGridViewCellEventArgs ceo = new DataGridViewCellEventArgs(0, 0);
                dgvPaciente_CellClick(dgvPaciente, ceo);
            }
        }
    }
}
