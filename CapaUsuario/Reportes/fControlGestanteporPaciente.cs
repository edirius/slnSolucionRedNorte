using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario.Reportes
{
    public partial class fControlGestanteporPaciente : Form
    {

        public string IdObstetra = "";

        public fControlGestanteporPaciente()
        {
            InitializeComponent();
        }

        private void dgvListaGestantesReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGestante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fControlGestanteporPaciente_Load(object sender, EventArgs e)
        {
            CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();
            CapaDeNegocios.cUtilitarios oUtilitarios = new CapaDeNegocios.cUtilitarios();
            DataTable odt = new DataTable();

            int mes_numero = Convert.ToInt16(DateTime.Now.Month.ToString("00"));
            int año_numero = Convert.ToInt16(DateTime.Now.Year.ToString("0000"));

            int año = Convert.ToInt16(this.cbYear.GetItemText(this.cbYear.SelectedItem));
            int mes = Convert.ToInt16(this.cbMonth.GetItemText(this.cbMonth.SelectedIndex));
            mes = mes + 1;

            cbYear.SelectedItem = cbYear.Items[0];
            cbMonth.SelectedItem = cbMonth.Items[mes_numero - 1];
            cbBuscar.SelectedItem = cbBuscar.Items[0];

            oHistoriaClinica.Idtobstetra = IdObstetra;
            oHistoriaClinica.mes = mes;
            oHistoriaClinica.año = año;
            odt = oUtilitarios.enumerar_datatable(oHistoriaClinica.ListarHistoriaClinica(), 0);
            dgvGestante.DataSource = odt;
        }
    }
}
