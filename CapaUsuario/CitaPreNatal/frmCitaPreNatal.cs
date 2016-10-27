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
using CapaDeNegocios.CitaPreNatal;

namespace CapaUsuario.CitaPreNatal
{
    public partial class frmCitaPreNatal : Form
    {
        public frmCitaPreNatal()
        {
            InitializeComponent();
        }

        public string Establecimiento
        { get; set; }

        public string HistoriaClinica
        { get; set; }
        public cCitaPrenatal oCitaPrenatal;

        private void frmCitaPreNatal_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Establecimiento);
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                dtgCitasMedicas.DataSource = oCitaPrenatal.ListaCitasPreNatal();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al cargar Datos: " + e.Message);
            }
            
        }
    }
}
