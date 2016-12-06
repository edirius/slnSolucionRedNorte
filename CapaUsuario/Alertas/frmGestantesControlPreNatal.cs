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
using CapaDeNegocios.Alertas;

namespace CapaUsuario.Alertas
{
    public partial class frmGestantesControlPreNatal : Form
    {

        public frmGestantesControlPreNatal()
        {
            InitializeComponent();
        }

        public cAlertas oAlertas = new cAlertas();
        public string codigoEstablecimiento { get; set; }

        private void frmGestantesControlPreNatal_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dtgListaGestantes.DataSource = oAlertas.ListarGestantesQueNoAcudenCita(codigoEstablecimiento);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            rptListaGestantesControlPreNatal rListaGestantesControlPrenatal = new rptListaGestantesControlPreNatal();
            dsListaGestantesControlPreNatal ds = new dsListaGestantesControlPreNatal();
            ds.Tables.Add(oAlertas.ListarGestantesQueNoAcudenCita(codigoEstablecimiento));
            rListaGestantesControlPrenatal.SetDataSource(oAlertas.ListarGestantesQueNoAcudenCita(codigoEstablecimiento));

            frmReporteListaGestantesQueNoAcudenCitaPreNatal reporteListaGestantes = new frmReporteListaGestantesQueNoAcudenCitaPreNatal();
            reporteListaGestantes.crystalReportViewer1.ReportSource = rListaGestantesControlPrenatal;
            reporteListaGestantes.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
