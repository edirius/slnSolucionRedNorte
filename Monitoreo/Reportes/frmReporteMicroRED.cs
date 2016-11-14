using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoreo.Reportes
{
    public partial class frmReporteMicroRED : Form
    {
        string sidtmicrored = "";

        public frmReporteMicroRED()
        {
            InitializeComponent();
        }

        private void frmReporteObstetras_Load(object sender, EventArgs e)
        {
            cboMes.Text = Convert.ToString(DateTime.Now.ToString("MMMM"));
            CargarAños();
            CargarMicroRED();
        }

        private void dgvMicroRED_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                sidtmicrored = Convert.ToString(dgvMicroRED.Rows[e.RowIndex].Cells["idtmicrored"].Value);
            }
        }

        private void CargarMicroRED()
        {
            try
            {
                CapaDeNegocios.EstablecimientoSalud.cMicrored miMicrored = new CapaDeNegocios.EstablecimientoSalud.cMicrored();
                dgvMicroRED.Rows.Clear();
                foreach (DataRow row in miMicrored.ListarMicrored().Rows)
                {
                    dgvMicroRED.Rows.Add(row["idtmicrored"].ToString(), row["microred"].ToString(), row["direccion"].ToString());
                }
                if (dgvMicroRED.Rows.Count > 0)
                {
                    dgvMicroRED.ClearSelection();
                    dgvMicroRED.Rows[0].Selected = true;
                    DataGridViewCellEventArgs ceo = new DataGridViewCellEventArgs(0, 0);
                    dgvMicroRED_CellClick(dgvMicroRED, ceo);
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void CargarAños()
        {
            for (int i = DateTime.Now.Year; i >= 2000; i--)
            {
                cboAño.Items.Add(i);
            }
            cboAño.Text = Convert.ToString(DateTime.Now.Year);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporObstetras_Click(object sender, EventArgs e)
        {
            frmVistaReportes frmVistaReportes = new frmVistaReportes();
            frmVistaReportes.ReporteObstetra("ReporteObstetra");
            frmVistaReportes.Show();
        }

        private void btnNominalGestante_Click(object sender, EventArgs e)
        {
            frmVistaReportes frmVistaReportes = new frmVistaReportes();
            frmVistaReportes.ReporteNominalGestante("ReporteNominalGestante");
            frmVistaReportes.Show();
        }
    }
}
