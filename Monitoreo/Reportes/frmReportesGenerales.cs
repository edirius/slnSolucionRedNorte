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
        public frmReportesGenerales()
        {
            InitializeComponent();
        }

        private void btnGestantes_Click(object sender, EventArgs e)
        {
            OpenMicrosoftExcel(@"D:\ReporteGestantes.xlsx");
        }

        private void btnPuerperas_Click(object sender, EventArgs e)
        {
            OpenMicrosoftExcel(@"D:\ReportePuerperas.xlsx");
        }

        private void btnVDGestantes_Click(object sender, EventArgs e)
        {
            OpenMicrosoftExcel(@"D:\ReporteVDGestantes.xlsx");
        }

        private void btnVDPuerperas_Click(object sender, EventArgs e)
        {
            OpenMicrosoftExcel(@"D:\ReporteVDPuerperas.xlsx");
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
