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
    public partial class fBuscarCicloGestante : Form
    {

        public string IdtHistoriaClinica = "";
        public string IdObstetra = "";
        int año = 0;
        int mes = 0;

        int mes_numero = 0;
        int año_numero = 0;

        bool bandera_combobox_año = false;

        public fBuscarCicloGestante()
        {
            InitializeComponent();
        }

        private void establecer_combos_fecha_actual()
        {
            mes_numero = Convert.ToInt16(DateTime.Now.Month.ToString("00"));
            año_numero = Convert.ToInt16(DateTime.Now.Year.ToString("0000"));

            cbYear.SelectedItem = cbYear.Items[0];
            cbMonth.SelectedItem = cbMonth.Items[mes_numero - 1];

            año = Convert.ToInt16(this.cbYear.GetItemText(this.cbYear.SelectedItem));
            mes = Convert.ToInt16(this.cbMonth.GetItemText(this.cbMonth.SelectedIndex));
            mes = mes + 1;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text;
            CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();
            CapaDeNegocios.Paciente.cPaciente oPaciente = new CapaDeNegocios.Paciente.cPaciente();
            CapaDeNegocios.cUtilitarios oUtilitarios = new CapaDeNegocios.cUtilitarios();
            string seleccionado = this.cbBuscar.GetItemText(this.cbBuscar.SelectedItem);

            if (seleccionado == "Historia Clinica")
            {
                if (buscar.Length > 1)
                {
                    oHistoriaClinica.oPaciente.codigohistoriaclinica = buscar;
                    oHistoriaClinica.Idtobstetra = IdObstetra;
                    dgvHC.DataSource = oUtilitarios.enumerar_datatable(oHistoriaClinica.ListarHistoriaClinicaXHistoriaClinica(), 1);
                    dgvHC.Columns[0].Visible = false;
                }
            }

            if (seleccionado == "Apellido Paterno")
            {
                if (buscar.Length > 1)
                {
                    oPaciente.apellidopaterno = buscar;
                    oPaciente.idtobstetra = IdObstetra;
                    dgvHC.DataSource = oUtilitarios.enumerar_datatable(oPaciente.ListarHistoriaClinicaXApellidoPaterno(), 1);
                    dgvHC.Columns[0].Visible = false;
                }
            }

            if (seleccionado == "Apellido Materno")
            {
                if (buscar.Length > 1)
                {
                    oPaciente.apellidomaterno = buscar;
                    oPaciente.idtobstetra = IdObstetra;
                    dgvHC.DataSource = oUtilitarios.enumerar_datatable(oPaciente.ListarHistoriaClinicaXApellidoMaterno(), 1);
                    dgvHC.Columns[0].Visible = false;
                }
            }

            if (seleccionado == "Nombres")
            {
                if (buscar.Length > 1)
                {
                    oPaciente.nombres = buscar;
                    oPaciente.idtobstetra = IdObstetra;
                    dgvHC.DataSource = oUtilitarios.enumerar_datatable(oPaciente.ListarHistoriaClinicaXNombres(), 1);
                    dgvHC.Columns[0].Visible = false;
                }
            }

            if (seleccionado == "DNI")
            {
                if (buscar.Length > 1)
                {
                    oPaciente.dni = buscar;
                    oPaciente.idtobstetra = IdObstetra;
                    dgvHC.DataSource = oUtilitarios.enumerar_datatable(oPaciente.ListarHistoriaClinicaXDNI(), 1);
                    dgvHC.Columns[0].Visible = false;
                }
            }

            if (buscar.Length < 1)
            {
                oHistoriaClinica.Idtobstetra = IdObstetra;
                oHistoriaClinica.mes = mes;
                oHistoriaClinica.año = año;
                dgvHC.DataSource = oUtilitarios.enumerar_datatable(oHistoriaClinica.ListarHistoriaClinica(), 1);
                dgvHC.Columns[0].Visible = false;
            }

        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            listar_historia_clinica();
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            listar_historia_clinica();
        }

        private void listar_historia_clinica()
        {

            if (bandera_combobox_año)
            {
                CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();
                DataTable odtHC = new DataTable();
                año = 0; mes = 0;
                //año = Convert.ToInt16( cbYear.GetItemText(cbYear.SelectedItem) );
                //mes = Convert.ToInt16(cbMonth.GetItemText(cbMonth.SelectedIndex));
                mes = mes + 1;

                oHistoriaClinica.año = año;
                oHistoriaClinica.mes = mes;

                oHistoriaClinica.Idtobstetra = IdObstetra;
                //odtHC = enumerar_datatable(oHistoriaClinica.ListarHistoriaClinica(),1);
                //dgvHC.DataSource = odtHC ;
            }
        }

        private void fBuscarCicloGestante_Load(object sender, EventArgs e)
        {
            CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();
            cbYear.DataSource = oHistoriaClinica.ListarYear();
            cbYear.ValueMember = "yyyy";
            cbYear.DisplayMember = "yyyy";

            establecer_combos_fecha_actual();

            bandera_combobox_año = true;
        }
    }
}
