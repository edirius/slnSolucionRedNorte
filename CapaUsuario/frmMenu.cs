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
            HacerConeccion();
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
        }
        public void HacerConeccion()
        {
            try
            {
                Conexion.IniciarSesion(Settings.Default.ConexionMySql, "bdcontrolgestantes", "root", "root");
                MessageBox.Show(String.Format("{0}", "Se conecto exitosamente"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mantenimientoPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paciente.frmMantenimientoPaciente fMantenimientoPaciente = new Paciente.frmMantenimientoPaciente(IdEstablecimientoSalud);
            fMantenimientoPaciente.MdiParent = this;
            fMantenimientoPaciente.Show();
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
            frmHistoriaClinica.MdiParent = this;
            frmHistoriaClinica.Show();
        }
        

        private void microredToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EstablecimientoSalud.frmMicrored miMicrored = new EstablecimientoSalud.frmMicrored();
            miMicrored.MdiParent = this;
            miMicrored.Show();

        }

        private void establecimientoSaludToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EstablecimientoSalud.frmEstablecimientoSalud frmEstable = new EstablecimientoSalud.frmEstablecimientoSalud();
            frmEstable.MdiParent = this;
            frmEstable.Show();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cItasPreNatalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CitaPreNatal.frmCitaPreNatal fCitaPreNatal = new CitaPreNatal.frmCitaPreNatal();
            fCitaPreNatal.Establecimiento = "E006";
            fCitaPreNatal.HistoriaClinica = "E006H00001";
            fCitaPreNatal.MdiParent = this;
            fCitaPreNatal.Show();
        }

        private void alertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alertas.frmAlerta fAlerta = new Alertas.frmAlerta();
            fAlerta.CodigoEstablecimiento = IdEstablecimientoSalud;
            fAlerta.MdiParent = this;
            fAlerta.Show(); 
        }

        private void visitaDomiciliariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitaDomiciliaria.frmMantenimientoVisitaDomiciliaria fMantenimientoVisitaDomiciliaria= new VisitaDomiciliaria.frmMantenimientoVisitaDomiciliaria(IdEstablecimientoSalud, NombreObstetra);
            fMantenimientoVisitaDomiciliaria.MdiParent = this;
            fMantenimientoVisitaDomiciliaria.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoMorbilidad fMantenimientoMorbilidad = new frmMantenimientoMorbilidad();
            fMantenimientoMorbilidad.CodigoEstablecimiento = IdEstablecimientoSalud;
            fMantenimientoMorbilidad.MdiParent = this;
            fMantenimientoMorbilidad.Show();
        }

        private void transeunteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTranseunte fTranseunte = new frmTranseunte();

            fTranseunte.CodigoEstablecimiento = IdEstablecimientoSalud;
            fTranseunte.MdiParent = this;
            fTranseunte.Show();
        }

        private void controlPeuperioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlPeuperio.frmMantenimientoControlPeuperio fMantenimientoControlPeuperio = new ControlPeuperio.frmMantenimientoControlPeuperio(IdEstablecimientoSalud, NombreObstetra);
            fMantenimientoControlPeuperio.MdiParent = this;
            fMantenimientoControlPeuperio.Show();
        }

        private void terminoGestaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerminoGestacion.frmMantenimientoTerminoGestacion fMantenimientoTerminoGestacion = new TerminoGestacion.frmMantenimientoTerminoGestacion(IdEstablecimientoSalud, NombreObstetra);
            fMantenimientoTerminoGestacion.MdiParent = this;
            fMantenimientoTerminoGestacion.Show();
        }
    }
}
