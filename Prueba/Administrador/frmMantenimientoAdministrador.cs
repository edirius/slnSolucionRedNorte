using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba.Administrador
{
    public partial class frmMantenimientoAdministrador : Form
    {
        string sidtadministrador = "";
        string snombres = "";
        string sapellidopaterno = "";
        string sapellidomaterno = "";
        string ssexo = "";
        string sdni = "";
        DateTime sfechanacimiento;
        string sdireccion = "";
        string stelefono = "";
        string susuario = "";
        string spassword = "";
        CapaDeNegocios.Administrador.cAdministrador miAdministrador = new CapaDeNegocios.Administrador.cAdministrador();

        public frmMantenimientoAdministrador()
        {
            InitializeComponent();
        }

        private void frmMantenimientoPaciente_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dgvObstetras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvObstetras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sidtadministrador = Convert.ToString(dgvAdministradores.Rows[e.RowIndex].Cells["idtadministrador"].Value);
            snombres = Convert.ToString(dgvAdministradores.Rows[e.RowIndex].Cells["nombres"].Value);
            sapellidopaterno = Convert.ToString(dgvAdministradores.Rows[e.RowIndex].Cells["apellidopaterno"].Value);
            sapellidomaterno = Convert.ToString(dgvAdministradores.Rows[e.RowIndex].Cells["apellidomaterno"].Value);
            ssexo = Convert.ToString(dgvAdministradores.Rows[e.RowIndex].Cells["sexo"].Value);
            sdni = Convert.ToString(dgvAdministradores.Rows[e.RowIndex].Cells["dni"].Value);
            sfechanacimiento = Convert.ToDateTime(dgvAdministradores.Rows[e.RowIndex].Cells["fechanacimiento"].Value);
            sdireccion = Convert.ToString(dgvAdministradores.Rows[e.RowIndex].Cells["direccion"].Value);
            stelefono = Convert.ToString(dgvAdministradores.Rows[e.RowIndex].Cells["telefono"].Value);
            susuario = Convert.ToString(dgvAdministradores.Rows[e.RowIndex].Cells["usuario"].Value);
            spassword = Convert.ToString(dgvAdministradores.Rows[e.RowIndex].Cells["password"].Value);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAdministrador fAdministrador = new frmAdministrador();
            fAdministrador.RecibirDatos("", "", "", "", "", "", DateTime.Today, "", "", "", "", 1);
            if (fAdministrador.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (sidtadministrador == "")
            {
                MessageBox.Show("Debe seleccionar nuevamente los datos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmAdministrador fAdministrador = new frmAdministrador();
            fAdministrador.RecibirDatos(sidtadministrador, snombres, sapellidopaterno, sapellidomaterno, ssexo, sdni, sfechanacimiento, sdireccion, stelefono, susuario, spassword, 2);
            if (fAdministrador.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (sidtadministrador == "")
            {
                MessageBox.Show("Debe seleccionar nuevamente los datos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Está seguro que desea eliminar el Maestro Descuentos", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            miAdministrador.EliminarAdministrador(sidtadministrador);
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
                dgvAdministradores.DataSource = miAdministrador.ListarAdministrador();
                if (dgvAdministradores.Rows.Count > 0)
                {
                    dgvAdministradores.Rows[0].Selected = true;
                    DataGridViewCellEventArgs ceo = new DataGridViewCellEventArgs(0, 0);
                    dgvObstetras_CellClick(dgvAdministradores, ceo);
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
    }
}
