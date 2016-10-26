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

        public frmHistoriaClinica frmHistoriaClinica = new frmHistoriaClinica();

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
            Pacientes.frmMantenimientoPaciente fMantenimientoPaciente = new Pacientes.frmMantenimientoPaciente();
            fMantenimientoPaciente.MdiParent = this;
            fMantenimientoPaciente.Show();
        }

        private void historiaClinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmHistoriaClinica.MdiParent = this;
            frmHistoriaClinica.Show();
        }
    }
}
