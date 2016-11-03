using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario.VisitaDomiciliaria
{
    public partial class frmMantenimientoVisitaDomiciliaria : Form
    {
        int saccion = 0;
        string stipo = "";
        string sidtvisitadomiciliariagestante = "";
        string sidthistoriaclinica = "";
        string sidtestablecimientosalud = "";
        string snombreobstetra = "";

        CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaGestante miVisitaDomiciliariaGestante = new CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaGestante();
        CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaPuerperaRN miVisitaDomiciliariaPuerperaRN = new CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaPuerperaRN();

        public frmMantenimientoVisitaDomiciliaria(string pidestablecimientosalud, string pnombreobstetra)
        {
            sidtestablecimientosalud = pidestablecimientosalud;
            snombreobstetra = pnombreobstetra;
            InitializeComponent();
        }

        private void frmVisitaDomiciliaria_Load(object sender, EventArgs e)
        {
            sidthistoriaclinica = "E006H00002";
            tabControl1_SelectedIndexChanged(sender, e);
        }

        private void dtpFechaGestante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtFuaGestante.Focus();
            }
        }

        private void txtFuaGestante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboMotivoGestante.Focus();
            }
        }

        private void cboMotivoGestante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDetalleGestante.Focus();
            }
        }

        private void txtDetalleGestante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnGuardar.Focus();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            saccion = 1;
            if (stipo == "GESTANTE")
            {
                dtpFechaGestante.Value = DateTime.Today;
                txtFuaGestante.Text = "";
                cboMotivoGestante.SelectedIndex = -1;
                txtDetalleGestante.Text = "";
                dtpFechaGestante.Focus();
            }
            else if (stipo == "PUERPERIA / R.NACIDO")
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool bOk = false;
                if (stipo == "GESTANTE")
                {
                    miVisitaDomiciliariaGestante.idtvisitadomiciliariagestante = sidtvisitadomiciliariagestante;
                    miVisitaDomiciliariaGestante.fecha = dtpFechaGestante.Value;
                    miVisitaDomiciliariaGestante.motivo = cboMotivoGestante.Text;
                    miVisitaDomiciliariaGestante.fua = txtFuaGestante.Text;
                    miVisitaDomiciliariaGestante.detalle = txtDetalleGestante.Text;
                    miVisitaDomiciliariaGestante.idthistoriaclinica = sidthistoriaclinica;
                    if (saccion == 1)
                    {
                        CapaDeNegocios.cSiguienteCodigo miSiguienteCodigo = new CapaDeNegocios.cSiguienteCodigo();
                        foreach (DataRow row in miSiguienteCodigo.SiguientesCodigo("tvisitadomiciliariagestante", sidtestablecimientosalud).Rows)
                        {
                            miVisitaDomiciliariaGestante.idtvisitadomiciliariagestante = row[0].ToString();
                        }
                        miVisitaDomiciliariaGestante.CrearVisitaDomiciliariaGestante(miVisitaDomiciliariaGestante);
                        bOk = true;
                    }
                    if (saccion == 2)
                    {
                        miVisitaDomiciliariaGestante.ModificarVisitaDomiciliariaGestante(miVisitaDomiciliariaGestante);
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
                    CargarDatosGestante();
                }
                else if (stipo == "PUERPERIA / R.NACIDO") 
                {

                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (stipo == "GESTANTE")
            {
                if (sidtvisitadomiciliariagestante == "")
                {
                    MessageBox.Show("No existena datos que se puedan Eliminar", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Está seguro que desea eliminar la Visita Domiciliaria.", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }

                miVisitaDomiciliariaGestante.EliminarVisitaDomiciliariaGestante(sidtvisitadomiciliariagestante);
                CargarDatosGestante();
            }
            else if (stipo == "PUERPERIA / R.NACIDO")
            {

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                saccion = 0;
                stipo = "GESTANTE";
                CargarDatosGestante();
            }
            else
            {
                saccion = 0;
                stipo = "PUERPERIA/R.NACIDO";
            }
        }

        private void dgvVisitaDomiciliariaGestante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvVisitaDomiciliariaGestante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                saccion = 2;
                sidtvisitadomiciliariagestante = Convert.ToString(dgvVisitaDomiciliariaGestante.Rows[e.RowIndex].Cells["idtvisitadomiciliaria"].Value);
                dtpFechaGestante.Value = Convert.ToDateTime(dgvVisitaDomiciliariaGestante.Rows[e.RowIndex].Cells["fecha"].Value);
                cboMotivoGestante.Text = Convert.ToString(dgvVisitaDomiciliariaGestante.Rows[e.RowIndex].Cells["motivo"].Value);
                txtFuaGestante.Text = Convert.ToString(dgvVisitaDomiciliariaGestante.Rows[e.RowIndex].Cells["fua"].Value);
                txtDetalleGestante.Text = Convert.ToString(dgvVisitaDomiciliariaGestante.Rows[e.RowIndex].Cells["detalle"].Value);
                dtpFechaGestante.Focus();
            }
        }

        private void CargarDatosGestante()
        {
            try
            {
                dgvVisitaDomiciliariaGestante.Rows.Clear();
                foreach (DataRow row in miVisitaDomiciliariaGestante.ListarVisitaDomiciliariaGestante(sidthistoriaclinica).Rows)
                {
                    dgvVisitaDomiciliariaGestante.Rows.Add(row["idtvisitadomiciliariagestante"].ToString(), row["fecha"].ToString(), row["motivo"].ToString(), row["fua"].ToString(), row["detalle"].ToString());
                }
                if (dgvVisitaDomiciliariaGestante.Rows.Count > 0)
                {
                    dgvVisitaDomiciliariaGestante.ClearSelection();
                    dgvVisitaDomiciliariaGestante.Rows[dgvVisitaDomiciliariaGestante.RowCount-1].Selected = true;
                    DataGridViewCellEventArgs ceo = new DataGridViewCellEventArgs(0, dgvVisitaDomiciliariaGestante.RowCount - 1);
                    dgvVisitaDomiciliariaGestante_CellClick(dgvVisitaDomiciliariaGestante, ceo);
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
    }
}
