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
    public partial class frmGestantesConRiesgoPresionArterial : Form
    {
        
        public frmGestantesConRiesgoPresionArterial()
        {
            InitializeComponent();
        }

        cAlertas oAlerta = new cAlertas();

        public string CodigoEstablecimiento { get; set;}
         
        private void frmGestantesConRiesgoPresionArterial_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dtgListaGestantes.DataSource = oAlerta.ListarGestanteConRiesgoXPresionArterial(CodigoEstablecimiento, 140, 85);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            rptListaGestantesConRiesgoPresionAltaPrenatal rListaGestantesConRiesgoPresionAlta = new rptListaGestantesConRiesgoPresionAltaPrenatal();
            rListaGestantesConRiesgoPresionAlta.SetDataSource(oAlerta.ListarGestanteConRiesgoXPresionArterial(CodigoEstablecimiento, 140, 85));

            frmReporteListaGestanteConPresionAlta fListaGestanteConPresionAlta = new frmReporteListaGestanteConPresionAlta();
            fListaGestanteConPresionAlta.crystalReportViewer1.ReportSource = rListaGestantesConRiesgoPresionAlta;
            fListaGestanteConPresionAlta.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
