using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocios;
using CrystalDecisions.CrystalReports.Engine;

namespace CapaUsuario.Bateria
{
    public partial class frmAlertaGestanteBateria : Form
    {
        CapaDeNegocios.cBateria miBateria = new cBateria();
        public string CodigoEstablecimiento;
        public frmAlertaGestanteBateria(string idEstablecimiento)
        {
            InitializeComponent();
            CodigoEstablecimiento = idEstablecimiento;
            dgvListaBateria.DataSource = miBateria.ListarGestantesQueNoTienenBateria(CodigoEstablecimiento);
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            Bateria.CrystalReport1 RpGestanteSinBateria = new CrystalReport1();
            RpGestanteSinBateria.SetDataSource(miBateria.ListarGestantesQueNoTienenBateria(CodigoEstablecimiento));
            Bateria.frmReporteGestantesSinBateria miFrmReporte = new frmReporteGestantesSinBateria();
            miFrmReporte.crystalReportViewer1.ReportSource = RpGestanteSinBateria;
            miFrmReporte.Show();
        }
    }
}
