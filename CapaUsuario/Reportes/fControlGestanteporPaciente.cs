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

        
        public string IdObstetra { get; set; }
        int año = 0;
        int mes = 0;
         
        bool bandera_combobox_año = false;

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

            cbYear.DataSource = oHistoriaClinica.ListarYear();
            cbYear.ValueMember = "yyyy";
            cbYear.DisplayMember = "yyyy";

            int mes_numero = Convert.ToInt16(DateTime.Now.Month.ToString("00"));
            int año_numero = Convert.ToInt16(DateTime.Now.Year.ToString("0000"));

            bandera_combobox_año = true;

            cbYear.SelectedItem = cbYear.Items[0];
            cbMonth.SelectedItem = cbMonth.Items[mes_numero - 1];

            año = Convert.ToInt16(this.cbYear.GetItemText(this.cbYear.SelectedItem));
            mes = Convert.ToInt16(this.cbMonth.GetItemText(this.cbMonth.SelectedIndex));
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

        private void listar_historia_clinica()
        {
            if (bandera_combobox_año)
            {
                CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();
                CapaDeNegocios.cUtilitarios oUtilitarios = new CapaDeNegocios.cUtilitarios();
                DataTable odtHC = new DataTable();
                año = 0; mes = 0;
                año = Convert.ToInt16(cbYear.GetItemText(cbYear.SelectedItem));
                mes = Convert.ToInt16(cbMonth.GetItemText(cbMonth.SelectedIndex));
                mes = mes + 1;

                oHistoriaClinica.año = año;
                oHistoriaClinica.mes = mes;

                oHistoriaClinica.Idtobstetra = IdObstetra;
                odtHC = oUtilitarios.enumerar_datatable(oHistoriaClinica.ListarHistoriaClinica(), 0);
                dgvGestante.DataSource = odtHC;
            }
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            listar_historia_clinica();
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            listar_historia_clinica();
        }
    }
}
