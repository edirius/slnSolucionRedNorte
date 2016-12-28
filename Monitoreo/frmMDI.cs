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

        private void microRedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EstablecimientoSalud.frmMicrored miMicrored = new EstablecimientoSalud.frmMicrored();
            miMicrored.MdiParent = this;
            miMicrored.Show();
        }

        private void establecimientoSaludToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstablecimientoSalud.frmEstablecimientoSalud frmEstable = new EstablecimientoSalud.frmEstablecimientoSalud();
            frmEstable.MdiParent = this;
            frmEstable.Show();
        }

        private void morbilidadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Morbilidad.frmMantenimientoMorbilidad fMantenimientoMorbilidad = new Morbilidad.frmMantenimientoMorbilidad();
            CapaDeNegocios.cUtilitarios oUtilitarios = new CapaDeNegocios.cUtilitarios();
            if (oUtilitarios.verificarventanaabierta("frmMantenimientoMorbilidad"))
            {
                fMantenimientoMorbilidad.MdiParent = this;
                fMantenimientoMorbilidad.Show();
            }
        }

        private void generalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmReportesGenerales fReportesGenerales = new Reportes.frmReportesGenerales();
            fReportesGenerales.MdiParent = this;
            fReportesGenerales.Show();
        }

        private void porMicroREDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmReporteMicroRED fReporteMicroRED = new Reportes.frmReporteMicroRED();
            fReporteMicroRED.MdiParent = this;
            fReporteMicroRED.Show();
        }

        private void porEstablecimientoDeSaludToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmReporteEstablecimientoSalud fReporteEstablecimientoSalud = new Reportes.frmReporteEstablecimientoSalud();
            fReporteEstablecimientoSalud.MdiParent = this;
            fReporteEstablecimientoSalud.Show();
        }

        private void importaciónDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Importacion.frmImportarDatos Importar = new Importacion.frmImportarDatos();
            //Importar.IdEstablecimientoSalud = IdEstablecimientoSalud;
            //Importar.NombreEstablecimientoSalud = NombreEstablecimientoSalud;
            //Importar.NombreObstetra = NombreObstetra;
            //Importar.IdObstetra = IdObstetra;
            Importar.MdiParent = this;
            Importar.Show();
        }
    }
}
