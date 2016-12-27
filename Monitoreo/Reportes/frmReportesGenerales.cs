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
            ruta = "C:\\ReporteGestantes.xlsx";
            OpenMicrosoftExcel(@ruta);
        }

        private void btnPuerperas_Click(object sender, EventArgs e)
        {
            //ruta = directorio + "\\ReportePuerperas.xlsx";
            ruta = "C:\\ReportePuerperas.xlsx";
            OpenMicrosoftExcel(@ruta);
        }

        private void btnVDGestantes_Click(object sender, EventArgs e)
        {
            //ruta = directorio + "\\ReporteVDGestantes.xlsx";
            ruta = "C:\\ReporteVDGestantes.xlsx";
            OpenMicrosoftExcel(@ruta);
        }

        private void btnVDPuerperas_Click(object sender, EventArgs e)
        {
            //ruta = directorio + "\\ReporteVDPuerperas.xlsx";
            ruta = "C:\\ReporteVDPuerperas.xlsx";
            OpenMicrosoftExcel(@ruta);
        }

        static void OpenMicrosoftExcel(string f)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "EXCEL.EXE";
            startInfo.Arguments = f;
            Process.Start(startInfo);
        }
    }
}
