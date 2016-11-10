using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoreo
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {

        }

        private void frmMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void administradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrador.frmMantenimientoAdministrador fMantenimientoAdministrador = new Administrador.frmMantenimientoAdministrador();
            fMantenimientoAdministrador.MdiParent = this;
            fMantenimientoAdministrador.Show();
        }

        private void microRedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmReporteMicroRED fReporteMicroRED = new Reportes.frmReporteMicroRED();
            fReporteMicroRED.MdiParent = this;
            fReporteMicroRED.Show();
        }

        private void establecimientosDeSaludToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmReporteEstablecimientoSalud fReporteEstablecimientoSalud = new Reportes.frmReporteEstablecimientoSalud();
            fReporteEstablecimientoSalud.MdiParent = this;
            fReporteEstablecimientoSalud.Show();
        }
    }
}
