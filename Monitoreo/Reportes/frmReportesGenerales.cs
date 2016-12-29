using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Monitoreo.Reportes
{
    public partial class frmReportesGenerales : Form
    {
        string directorio = "";
        string ruta = "";
        public frmReportesGenerales()
        {
            InitializeComponent();
        }

        private void frmReportesGenerales_Load(object sender, EventArgs e)
        {
            directorio = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void btnGestantes_Click(object sender, EventArgs e)
        {
            try
            {
                ruta = directorio + "ReporteGestantes.xlsx";
                Process.Start(ruta);
            }
            catch
            {

            }
        }

        private void btnPuerperas_Click(object sender, EventArgs e)
        {
            try
            {
                ruta = directorio + "ReportePuerperas.xlsx";
                Process.Start(ruta);
            }
            catch
            {

            }
        }

        private void btnVDGestantes_Click(object sender, EventArgs e)
        {
            try
            {
                ruta = directorio + "ReporteVDGestantes.xlsx";
                Process.Start(ruta);
            }
            catch
            {

            }
        }

        private void btnVDPuerperas_Click(object sender, EventArgs e)
        {
            try
            {
                ruta = directorio + "ReporteVDPuerperas.xlsx";
                Process.Start(ruta);
            }
            catch
            {

            }
        }
    }
}
