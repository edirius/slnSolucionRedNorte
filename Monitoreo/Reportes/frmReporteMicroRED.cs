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
            CargarAños();
            cboMes.Text = Convert.ToString(DateTime.Now.ToString("MMMM"));
            CargarMicroRED();
        }

        private void cboAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMes.SelectedIndex = 0;
        }

        private void cboMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvMicroRED_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        string Mes(string pmes)
        {
            string x = "";
            switch (pmes)
            {
                case "TODOS":
                    x = "TODOS";
                    break;
                case "ENERO":
                    x = "01";
                    break;
                case "FEBRERO":
                    x = "02";
                    break;
                case "MARZO":
                    x = "03";
                    break;
                case "ABRIL":
                    x = "04";
                    break;
                case "MAYO":
                    x = "05";
                    break;
                case "JUNIO":
                    x = "06";
                    break;
                case "JULIO":
                    x = "07";
                    break;
                case "AGOSTO":
                    x = "08";
                    break;
                case "SETIEMBRE":
                    x = "09";
                    break;
                case "OCTUBRE":
                    x = "10";
                    break;
                case "NOVIEMBRE":
                    x = "11";
                    break;
                case "DICIEMBRE":
                    x = "12";
                    break;
            }
            return x;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporObstetras_Click(object sender, EventArgs e)
        {
            frmVistaReportes frmVistaReportes = new frmVistaReportes();
            frmVistaReportes.ReporteObstetra("rptReportesObstetras");
            frmVistaReportes.MdiParent = this.MdiParent;
            frmVistaReportes.Show();
        }

        private void btnNominalGestante_Click(object sender, EventArgs e)
        {
            frmVistaReportes frmVistaReportes = new frmVistaReportes();
            frmVistaReportes.ReporteNominalGestanteMicroRED("rptReporteNominalGestanteMicroRED", cboAño.Text, Mes(cboMes.Text), sidtmicrored);
            frmVistaReportes.MdiParent = this.MdiParent;
            frmVistaReportes.Show();
        }

        private void btnGestantesFechaPP_Click(object sender, EventArgs e)
        {
            frmVistaReportes frmVistaReportes = new frmVistaReportes();
            frmVistaReportes.ReporteGestantesFechaPPMicroRED("rptReporteGestantesFechaPPMicroRED", cboAño.Text, Mes(cboMes.Text), sidtmicrored);
            frmVistaReportes.MdiParent = this.MdiParent;
            frmVistaReportes.Show();
        }

        private void btnGestantesDadoParto_Click(object sender, EventArgs e)
        {
            frmVistaReportes frmVistaReportes = new frmVistaReportes();
            frmVistaReportes.ReporteGestanteDadoPartoMicroRED("rptReporteGestanteDadoPartoMicroRED", cboAño.Text, Mes(cboMes.Text), sidtmicrored);
            frmVistaReportes.MdiParent = this.MdiParent;
            frmVistaReportes.Show();
        }
    }
}
