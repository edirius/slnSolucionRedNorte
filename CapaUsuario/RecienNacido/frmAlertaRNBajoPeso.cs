using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario.RecienNacido
{
    public partial class frmAlertaRNBajoPeso : Form
    {
        CapaDeNegocios.RecienNacido.cRecienNacido miRN = new CapaDeNegocios.RecienNacido.cRecienNacido();
        public string CodigoEstablecimiento { get; set; }
        public string CodigoObstetra { get; set; }
        string FechaTexto = "";
        public frmAlertaRNBajoPeso()
        {
            InitializeComponent();
            CargarAños();
            DateTime Ahora = DateTime.Today;
            CargarMes(Ahora);
            cbMes.Text = FechaTexto;
        }
        private void CargarGrid()
        {
            dgvListaRN.DataSource = miRN.ListarRecienNacidoConBajoPeso(cbMes.Text, cbAños.Text);
        }
        private void CargarMes(DateTime FechaActual)
        {
            string Ahora = Convert.ToString(FechaActual.Date.Month);
            switch (Ahora)
            {
                case "1":
                    {
                        FechaTexto = "ENERO";
                        break;
                    }
                case "2":
                    {
                        FechaTexto = "FEBRERO";
                        break;
                    }
                case "3":
                    {
                        FechaTexto = "MARZO";
                        break;
                    }
                case "4":
                    {
                        FechaTexto = "ABRIL";
                        break;
                    }
                case "5":
                    {
                        FechaTexto = "MAYO";
                        break;
                    }
                case "6":
                    {
                        FechaTexto = "JUNIO";
                        break;
                    }
                case "7":
                    {
                        FechaTexto = "JULIO";
                        break;
                    }
                case "8":
                    {
                        FechaTexto = "AGOSTO";
                        break;
                    }
                case "9":
                    {
                        FechaTexto = "SEPTIEMBRE";
                        break;
                    }
                case "10":
                    {
                        FechaTexto = "OCTUBRE";
                        break;
                    }
                case "11":
                    {
                        FechaTexto = "NOVIEMBRE";
                        break;
                    }
                case "12":
                    {
                        FechaTexto = "DICIEMBRE";
                        break;
                    }

            }
        }
        private void CargarAños()
        {
            string años = "";
            for (int i = DateTime.Now.Year; i >= 2000; i--)
            {
                cbAños.Items.Add(i);
            }
            cbAños.Text = años;
            cbAños.Text = Convert.ToString(DateTime.Now.Year);
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvListaRN.DataSource = miRN.ListarRecienNacidoConBajoPeso(cbMes.Text, cbAños.Text);
        }

        private void cbAños_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvListaRN.DataSource = miRN.ListarRecienNacidoConBajoPeso(cbMes.Text, cbAños.Text);
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            RecienNacido.CrystalReport1 RpRNBajoPeso = new CrystalReport1();
            RpRNBajoPeso.SetDataSource(miRN.ListarRecienNacidoConBajoPeso(cbMes.Text, cbAños.Text));
            RecienNacido.frmReporteRNBajoPeso miFrmReporte = new frmReporteRNBajoPeso();
            miFrmReporte.crystalReportViewer1.ReportSource = RpRNBajoPeso;
            miFrmReporte.Show();
        }

        private void frmAlertaRNBajoPeso_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
    }
}
