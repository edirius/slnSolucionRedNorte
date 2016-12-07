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
        public string CodigoEstablecimiento { get; set; }
        public string CodigoObstetra { get; set; }
        string FechaTexto = "";
        public frmAlertaGestanteBateria()
        {
            InitializeComponent();
            CargarAños();
            DateTime Ahora = DateTime.Today;
            CargarMes(Ahora);
        }
        private void frmAlertaGestanteBateria_Load(object sender, EventArgs e)
        {
            cbMes.Text = FechaTexto;
            cbTipoAlerta.Text = "GESTANTES SIN BATERIA";
            dgvListaBateria.DataSource = miBateria.ListadeAlertasenBateria(cbTipoAlerta.Text, CodigoEstablecimiento, CodigoObstetra, cbMes.Text, cbAños.Text);

        }
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (cbTipoAlerta.Text == "GESTANTES CON ANEMIA")
            {
                Bateria.GestanteConAnemia RPGestanteConAnemia = new GestanteConAnemia();
                RPGestanteConAnemia.SetDataSource(miBateria.AlertaGestanteAnemia(CodigoEstablecimiento, CodigoObstetra, cbMes.Text, cbAños.Text));
                Bateria.frmReporteGestantesSinBateria miFrmReporte = new frmReporteGestantesSinBateria();
                miFrmReporte.crystalReportViewer1.ReportSource = RPGestanteConAnemia;
                miFrmReporte.Show();
            }
            if (cbTipoAlerta.Text == "GESTANTES CON VIH REACTIVO")
            {
                Bateria.GestanteConVIH RPGestanteConVIH = new GestanteConVIH();
                RPGestanteConVIH.SetDataSource(miBateria.AlertaGestanteVIH(CodigoEstablecimiento, CodigoObstetra, cbMes.Text, cbAños.Text));
                Bateria.frmReporteGestantesSinBateria miFrmReporte = new frmReporteGestantesSinBateria();
                miFrmReporte.crystalReportViewer1.ReportSource = RPGestanteConVIH;
                miFrmReporte.Show();
            }
            if (cbTipoAlerta.Text == "GESTANTES CON SIFILIS REACTIVO")
            {
                Bateria.GestanteConSifilis RPGestanteConSifilis = new GestanteConSifilis();
                RPGestanteConSifilis.SetDataSource(miBateria.AlertaGestanteSifilis(cbMes.Text, cbAños.Text));
                Bateria.frmReporteGestantesSinBateria miFrmReporte = new frmReporteGestantesSinBateria();
                miFrmReporte.crystalReportViewer1.ReportSource = RPGestanteConSifilis;
                miFrmReporte.Show();
            }
            if (cbTipoAlerta.Text == "GESTANTES SIN EXAMEN DE ORINA")
            {
                Bateria.GestanteSinExamenOrina RPGestanteSinExamenOrina = new GestanteSinExamenOrina();
                RPGestanteSinExamenOrina.SetDataSource(miBateria.AlertaGestanteSinExamenOrina(CodigoEstablecimiento, CodigoObstetra, cbMes.Text, cbAños.Text));
                Bateria.frmReporteGestantesSinBateria miFrmReporte = new frmReporteGestantesSinBateria();
                miFrmReporte.crystalReportViewer1.ReportSource = RPGestanteSinExamenOrina;
                miFrmReporte.Show();
            }
            if (cbTipoAlerta.Text == "GESTANTES SIN FECHA DE TRATAMIENTO")
            {
                Bateria.GestanteSinTratamiento RPGestanteSinFechaTratamiento = new GestanteSinTratamiento();
                RPGestanteSinFechaTratamiento.SetDataSource(miBateria.AlertaGestanteSinFechaTratamiento(cbMes.Text, cbAños.Text));
                Bateria.frmReporteGestantesSinBateria miFrmReporte = new frmReporteGestantesSinBateria();
                miFrmReporte.crystalReportViewer1.ReportSource = RPGestanteSinFechaTratamiento;
                miFrmReporte.Show();
            }
            if (cbTipoAlerta.Text == "GESTANTES CON INFECCION URINARIA A TRATAR")
            {
                Bateria.GestanteInfeccionUrinaria RPGestanteInfeccionUrinaria = new GestanteInfeccionUrinaria();
                RPGestanteInfeccionUrinaria.SetDataSource(miBateria.AlertaGestanteOrina(CodigoEstablecimiento, CodigoObstetra, cbMes.Text, cbAños.Text));
                Bateria.frmReporteGestantesSinBateria miFrmReporte = new frmReporteGestantesSinBateria();
                miFrmReporte.crystalReportViewer1.ReportSource = RPGestanteInfeccionUrinaria;
                miFrmReporte.Show();
            }
            if (cbTipoAlerta.Text == "GESTANTES SIN BATERIA")
            {
                Bateria.CrystalReport1 RPGestanteSinBateria = new CrystalReport1();
                RPGestanteSinBateria.SetDataSource(miBateria.AlertaGestanteSinBateria(CodigoEstablecimiento, CodigoObstetra, cbMes.Text, cbAños.Text));
                Bateria.frmReporteGestantesSinBateria miFrmReporte = new frmReporteGestantesSinBateria();
                miFrmReporte.crystalReportViewer1.ReportSource = RPGestanteSinBateria;
                miFrmReporte.Show();
            }


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
            try
            {
                dgvListaBateria.DataSource = miBateria.ListadeAlertasenBateria(cbTipoAlerta.Text, CodigoEstablecimiento, CodigoObstetra, cbMes.Text, cbAños.Text);
            }
            catch { }
            
        }

        private void cbAños_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvListaBateria.DataSource = miBateria.ListadeAlertasenBateria(cbTipoAlerta.Text, CodigoEstablecimiento, CodigoObstetra, cbMes.Text, cbAños.Text);
            }
            catch { }
        }

        private void cbTipoAlerta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvListaBateria.DataSource = miBateria.ListadeAlertasenBateria(cbTipoAlerta.Text, CodigoEstablecimiento, CodigoObstetra, cbMes.Text, cbAños.Text);
            }
            catch { }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
