using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario
{
    public partial class frmHistoriaClinica : Form
    {
        public frmHistoriaClinica()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmHistoriaClinica_Load(object sender, EventArgs e)
        {
            DataTable odtHistoriaClinica = new DataTable();
            CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();

            odtHistoriaClinica = oHistoriaClinica.ListarPacienteXDNI();

            cboDNI.DataSource = odtHistoriaClinica;
            cboDNI.DisplayMember = "dni";
            cboDNI.ValueMember = "idtpaciente";


        }
    }
}
