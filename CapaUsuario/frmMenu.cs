using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaUsuario.Properties;
using CapaDeDatos;

namespace CapaUsuario
{
    public partial class frmMenu : Form
    {
        public CapaDeNegocios.Obstetra.cUsuario miUsuario = new CapaDeNegocios.Obstetra.cUsuario();
        public string NombreObstetra;
        public string IdObstetra;
        public string NombreEstablecimientoSalud;
        public string IdEstablecimientoSalud;

        public frmMenu()
        {
            InitializeComponent();
            //HacerConeccion();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Alertas.frmAlerta fAlerta = new Alertas.frmAlerta();
            fAlerta.CodigoEstablecimiento = IdEstablecimientoSalud;
            fAlerta.CodigoObstetra = IdObstetra;
            fAlerta.MdiParent = this;
            fAlerta.Show();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void obtenerDatos(string LoginUsuario)
        {
            DataTable Tabla = new DataTable();
            Tabla = miUsuario.DatosUsuario(LoginUsuario);
            NombreObstetra = Tabla.Rows[0][0].ToString();
            IdObstetra = Tabla.Rows[0][1].ToString();
            IdEstablecimientoSalud = Tabla.Rows[0][2].ToString();
            NombreEstablecimientoSalud = Tabla.Rows[0][3].ToString();
            slNombre.Text = "Obstetra: " + NombreObstetra;
            slEstablecimiento.Text = "Establecimiento de Salud: " + NombreEstablecimientoSalud;
            PasarDatos();
        }

        public void HacerConeccion()
        {
            try
            {
                Conexion.IniciarSesion(Settings.Default.ConexionMySql, "bdcontrolgestantes2", "root", "root");
                //MessageBox.Show(String.Format("{0}", "Se conecto exitosamente"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mantenimientoObstetrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Obstetra.frmMantenimientoObstetra fMantenimientoObstetra = new Obstetra.frmMantenimientoObstetra(IdEstablecimientoSalud);
            fMantenimientoObstetra.MdiParent = this;
            fMantenimientoObstetra.Show();
        }

        private void historiaClinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistoriaClinica frmHistoriaClinica = new frmHistoriaClinica( IdObstetra, IdEstablecimientoSalud );
            CapaDeNegocios.cUtilitarios oUtilitarios = new CapaDeNegocios.cUtilitarios();

            if (oUtilitarios.verificarventanaabierta("frmHistoriaClinica"))
            {
                frmHistoriaClinica.MdiParent = this;
                frmHistoriaClinica.Show();
            }
        }

        private void alertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alertas.frmAlerta fAlerta = new Alertas.frmAlerta();
            fAlerta.CodigoEstablecimiento = IdEstablecimientoSalud;
            fAlerta.CodigoObstetra = IdObstetra;
            fAlerta.MdiParent = this;
            fAlerta.Show(); 
        }

        private void PasarDatos()
        {
            cVariables.v_idobstetra = IdObstetra;
            cVariables.v_nombreobstetra = NombreObstetra;
            cVariables.v_idestablecimientosalud = IdEstablecimientoSalud;
            cVariables.v_nombreestablecimientosalud = NombreEstablecimientoSalud;
        }

        private void historiaClinicaEntreFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaUsuario.Reportes.fControlGestantesEntreFechas fControlGestantesEntreFechas = new CapaUsuario.Reportes.fControlGestantesEntreFechas();
            fControlGestantesEntreFechas.MdiParent = this;
            fControlGestantesEntreFechas.Idtobstetra = IdObstetra;
            fControlGestantesEntreFechas.Show();
        }

        private void rESUMENCANTIDADDEGESTANTESPORMICROREDEESSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            CapaUsuario.Reportes.fCantidadGestantes frmCantidadGestantes = new CapaUsuario.Reportes.fCantidadGestantes();
            frmCantidadGestantes.MdiParent = this;
            frmCantidadGestantes.Show();
            */
        }

        private void exportarEImportarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exportacion.frmExportacion Exportar = new Exportacion.frmExportacion();
            Exportar.IdEstablecimientoSalud = IdEstablecimientoSalud;
            Exportar.NombreEstablecimientoSalud = NombreEstablecimientoSalud;
            Exportar.NombreObstetra = NombreObstetra;
            Exportar.IdObstetra = IdObstetra;
            Exportar.MdiParent = this;
            Exportar.Show();
        }

        private void historiaClinicaPorPaciwinwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaUsuario.Reportes.fControlGestanteporPaciente fControlGestanteporPaciente = new CapaUsuario.Reportes.fControlGestanteporPaciente();
            CapaDeNegocios.cUtilitarios oUtilitarios = new CapaDeNegocios.cUtilitarios();

            if (oUtilitarios.verificarventanaabierta("fControlGestanteporPaciente"))
            {

                fControlGestanteporPaciente.MdiParent = this;
                fControlGestanteporPaciente.Idtobstetra = IdObstetra;
                fControlGestanteporPaciente.Show();
                
            }
        }

        private void alertasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Alertas.frmAlerta fAlerta = new Alertas.frmAlerta();
            //fAlerta.CodigoEstablecimiento = IdEstablecimientoSalud;
            //fAlerta.CodigoObstetra = IdObstetra;
            //fAlerta.MdiParent = this;
            //fAlerta.Show();
        }
        CapaDeNegocios.cUtilitarios oUtilitarios = new CapaDeNegocios.cUtilitarios();
        private void reportesDeAlertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alertas.frmAlerta fAlerta = new Alertas.frmAlerta();
            fAlerta.CodigoEstablecimiento = IdEstablecimientoSalud;
            fAlerta.CodigoObstetra = IdObstetra;
            if (oUtilitarios.verificarventanaabierta("frmAlerta"))
            {
                fAlerta.MdiParent = this;
                fAlerta.Show();
            }
            
        }

        private void reportesDeMorbilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.fControlGestantePorMorbilidad fCGM = new Reportes.fControlGestantePorMorbilidad();

            if (oUtilitarios.verificarventanaabierta("fControlGestantePorMorbilidad"))
            {
                fCGM.MdiParent = this;
                fCGM.Show();
            }
        }
    }
}
