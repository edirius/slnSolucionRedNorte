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
        CapaDeNegocios.cUtilitarios oUtilitarios = new CapaDeNegocios.cUtilitarios();
        public string IdtHistoriaClinica = "";
        public string IdtEstablecimientoSalud = "";
        public string IdObstetra = "";
        bool seleccionado = false;
        int año = 0;
        int mes = 0;

        int mes_numero = 0;
        int año_numero = 0;

        bool bandera_combobox_año = false;
        int cantidad_control_gesntante = 0;
        int cantidad_años = 0;

        public fBuscarCicloGestante()
        {
            InitializeComponent();
        }

        private void establecer_combos_fecha_actual()
        {
            mes_numero = Convert.ToInt16(DateTime.Now.Month.ToString("00"));
            año_numero = Convert.ToInt16(DateTime.Now.Year.ToString("0000"));

            cbMonth.SelectedItem = cbMonth.Items[mes_numero - 1];
            mes = Convert.ToInt16(this.cbMonth.GetItemText(this.cbMonth.SelectedIndex));
            mes = mes + 1;

            if (cantidad_años > 0)
            {
                //cbYear.SelectedItem = cbYear.Text[año_numero];
                cbYear.Text = año_numero.ToString();
                año = Convert.ToInt16(this.cbYear.GetItemText(this.cbYear.SelectedItem));
                cbMonth.Enabled = true;
            }
            else
                cbMonth.Enabled = false;
                
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
                    if (buscar.Length >= 10)
                        oHistoriaClinica.oPaciente.codigohistoriaclinica = buscar.Substring(0, 9);

                    if (buscar.Length <= 10)
                        oHistoriaClinica.oPaciente.codigohistoriaclinica = buscar;


                    oHistoriaClinica.Idtobstetra = IdObstetra;
                    oHistoriaClinica.Idtestablecimientosalud = IdtEstablecimientoSalud;
                    dgvHC.DataSource = oUtilitarios.enumerar_datatable(oHistoriaClinica.ListarHistoriaClinicaXHistoriaClinica(), 0);
                    dgvHC.Columns[1].Visible = false;
                }
            }

            if (seleccionado == "Apellido Paterno")
            {
                if (buscar.Length > 1)
                {
                    if (buscar.Length >= 150)
                        oPaciente.apellidopaterno = buscar.Substring(0, 149);

                    if (buscar.Length <= 150)
                        oPaciente.apellidopaterno = buscar;

                    oPaciente.idtobstetra = IdObstetra;
                    oPaciente.idtestablecimientosalud = IdtEstablecimientoSalud;
                    dgvHC.DataSource = oUtilitarios.enumerar_datatable(oPaciente.ListarHistoriaClinicaXApellidoPaterno(), 0);
                    dgvHC.Columns[1].Visible = false;
                }
            }

            if (seleccionado == "Apellido Materno")
            {
                if (buscar.Length > 1)
                {
                    if (buscar.Length >= 150)
                        oPaciente.apellidomaterno = buscar.Substring(0, 149);

                    if (buscar.Length <= 150)
                        oPaciente.apellidomaterno = buscar;

                    oPaciente.idtobstetra = IdObstetra;
                    oPaciente.idtestablecimientosalud = IdtEstablecimientoSalud;
                    dgvHC.DataSource = oUtilitarios.enumerar_datatable(oPaciente.ListarHistoriaClinicaXApellidoMaterno(), 0);
                    dgvHC.Columns[1].Visible = false;
                }
            }

            if (seleccionado == "Nombres")
            {
                if (buscar.Length > 1)
                {
                    if (buscar.Length >= 150)
                        oPaciente.nombres = buscar.Substring(0, 149);

                    if (buscar.Length <= 150)
                        oPaciente.nombres = buscar;

                    oPaciente.idtobstetra = IdObstetra;
                    oPaciente.idtestablecimientosalud = IdtEstablecimientoSalud;
                    dgvHC.DataSource = oUtilitarios.enumerar_datatable(oPaciente.ListarHistoriaClinicaXNombres(), 0);
                    dgvHC.Columns[1].Visible = false;
                }
            }

            if (seleccionado == "DNI")
            {
                if (buscar.Length > 1)
                {
                    if (buscar.Length>=8)
                        oPaciente.dni = buscar.Substring(0, 7);

                    if (buscar.Length <= 8)
                        oPaciente.dni = buscar;

                    oPaciente.idtobstetra = IdObstetra;
                    oPaciente.idtestablecimientosalud = IdtEstablecimientoSalud;
                    dgvHC.DataSource = oUtilitarios.enumerar_datatable(oPaciente.ListarHistoriaClinicaXDNI(), 0);
                    dgvHC.Columns[1].Visible = false;
                }
            }

            if (buscar.Length < 1)
            {
                oHistoriaClinica.Idtobstetra = IdObstetra;
                oHistoriaClinica.Idtestablecimientosalud = IdtEstablecimientoSalud;
                oHistoriaClinica.mes = mes;
                oHistoriaClinica.año = año;
                dgvHC.DataSource = oUtilitarios.enumerar_datatable(oHistoriaClinica.ListarHistoriaClinica(),0);
                dgvHC.Columns[1].Visible = false;
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
                año = Convert.ToInt16( cbYear.GetItemText(cbYear.SelectedItem) );
                mes = Convert.ToInt16(cbMonth.GetItemText(cbMonth.SelectedIndex));
                mes = mes + 1;

                oHistoriaClinica.año = año;
                oHistoriaClinica.mes = mes;

                oHistoriaClinica.Idtobstetra = IdObstetra;
                oHistoriaClinica.Idtestablecimientosalud = IdtEstablecimientoSalud;
                odtHC = oUtilitarios.enumerar_datatable(oHistoriaClinica.ListarHistoriaClinica(),0);
                dgvHC.DataSource = odtHC ;
                dgvHC.Columns[1].Visible = false;
            }
        }

        private void fBuscarCicloGestante_Load(object sender, EventArgs e)
        {
            CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();
            
            cbYear.DataSource = oHistoriaClinica.ListarYear();
            cbYear.ValueMember = "yyyy";
            cbYear.DisplayMember = "yyyy";

            cantidad_años = oHistoriaClinica.ListarYear().Rows.Count;

            establecer_combos_fecha_actual();
            txtBuscar.Text = "";
            cbBuscar.SelectedItem = cbBuscar.Items[0];

            /*Id de obstetra*/
            oHistoriaClinica.Idtobstetra = IdObstetra;
            oHistoriaClinica.Idtestablecimientosalud = IdtEstablecimientoSalud;
            oHistoriaClinica.mes = mes;
            oHistoriaClinica.año = año;
            dgvHC.DataSource = oUtilitarios.enumerar_datatable(oHistoriaClinica.ListarHistoriaClinica(), 0);
            dgvHC.Columns[1].Visible = false;
            //dgvHC.DataSource = odtHistoriaClinica;
            seleccionado = false;

            bandera_combobox_año = true;
        }

        private void dgvHC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void dgvHC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void llenar_datos_hc(DataGridViewCellEventArgs e)
        {
 
            if (e.RowIndex != -1)
            {
                IdtHistoriaClinica = dgvHC.Rows[e.RowIndex].Cells[1].Value.ToString();
                seleccionado = true;
            }
        }

        private void dgvHC_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHC_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvHC_DoubleClick_1(object sender, EventArgs e)
        {
           
        }

        private void dgvHC_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buAgregar_Click(object sender, EventArgs e)
        {
            if (dgvHC.Rows.Count > 0 && !seleccionado) { 
                IdtHistoriaClinica = dgvHC.Rows[0].Cells[1].Value.ToString();
                DialogResult = DialogResult.OK;
            }
            
            if (dgvHC.Rows.Count == 0)
                MessageBox.Show("No hay registros disponibles.","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (seleccionado)
                DialogResult = DialogResult.OK;

        }

        private void dgvHC_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            llenar_datos_hc(e);
        }

        private void dgvHC_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            llenar_datos_hc(e);
        }

        private void dgvHC_DoubleClick_2(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void dgvHC_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
            

        }

        private void fBuscarCicloGestante_Activated(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }

        private void dgvHC_KeyDown(object sender, KeyEventArgs e)
        {

            int indice;
            

            if ((e.KeyData & Keys.KeyCode) == Keys.Enter) {
                indice = dgvHC.CurrentRow.Index;

                if (dgvHC.Rows.Count > 0 && !seleccionado)
                {
                    IdtHistoriaClinica = dgvHC.Rows[indice].Cells[1].Value.ToString();
                    DialogResult = DialogResult.OK;
                }

                if (dgvHC.Rows.Count == 0)
                    MessageBox.Show("No hay registros disponibles.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (seleccionado) {
                    IdtHistoriaClinica = dgvHC.Rows[indice].Cells[1].Value.ToString();
                    DialogResult = DialogResult.OK;

                }
                return;
            }
            else
                base.OnKeyDown(e);

        }
    }
}
