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

        

        public frmMenu()
        {
            InitializeComponent();
            HacerConeccion();
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
            Paciente.frmMantenimientoPaciente fMantenimientoPaciente = new Paciente.frmMantenimientoPaciente();
            fMantenimientoPaciente.MdiParent = this;
            fMantenimientoPaciente.Show();
        }

        private void mantenimientoObstetrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Obstetra.frmMantenimientoObstetra fMantenimientoObstetra = new Obstetra.frmMantenimientoObstetra();
            fMantenimientoObstetra.MdiParent = this;
            fMantenimientoObstetra.Show();
        }

        private void historiaClinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistoriaClinica frmHistoriaClinica = new frmHistoriaClinica();
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
    }
}
