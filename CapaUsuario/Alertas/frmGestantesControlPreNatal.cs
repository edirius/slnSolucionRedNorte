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
using CapaDeNegocios.Alertas;

namespace CapaUsuario.Alertas
{
    public partial class frmGestantesControlPreNatal : Form
    {

        public frmGestantesControlPreNatal()
        {
            InitializeComponent();
        }

        public cAlertas oAlertas = new cAlertas();
        public string codigoEstablecimiento { get; set; }

        private void frmGestantesControlPreNatal_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dtgListaGestantes.DataSource = oAlertas.ListarGestantesQueNoAcudenCita(codigoEstablecimiento);
        }
    }
}
