using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CapaUsuario
{
    public partial class frmHistoriaClinica : Form
    { 
        
        public frmMenu frmMenuHC = new frmMenu();
        DataTable odtOdontologo = new DataTable();
        DataTable odtEcografia = new DataTable();
        public string idtpaciente = "";
        public string establecimientosalud = "";

        public string IdObstetra = "";
        public string IdEstablecimiento = "";
        public string IdtHistoriaClinica = "";
        public bool Archivado = false;
        public bool explorando_hc = false;

        public string Codigo_Historia_Clinica { get; set; }
        public string Fecha { get; set; }
        public string DNI { get; set; }
        public string Nombre_Completo { get; set; }
        public string Edad { get; set; }

        int i = 0;
        string obstetra = "";

        int año = 0;
        int mes = 0;

        int mes_numero = 0;
        int año_numero = 0;
        Image backgroundimage;

        bool bandera_combobox_año = false;

        public frmHistoriaClinica(string idObstetra , string idEstablecimiento)
        {
            InitializeComponent();
            IdObstetra = idObstetra;
            IdEstablecimiento = idEstablecimiento;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void cargar_paciente(string dni_, string nombres_, string app_, string apm_, DateTime fn_) {


        }

        private void establecer_combos_fecha_actual() {
            mes_numero = Convert.ToInt16(DateTime.Now.Month.ToString("00"));
            año_numero = Convert.ToInt16(DateTime.Now.Year.ToString("0000"));

            cbYear.SelectedItem = cbYear.Items[0];
            cbMonth.SelectedItem = cbMonth.Items[mes_numero - 1];
        }

        public DataTable enumerar_datatable(DataTable dt, int posicion ) {
            dt.Columns.Add("Nº", typeof(string)).SetOrdinal(posicion);
            for (int i = 0; i < dt.Rows.Count; i++) {
                dt.Rows[i][posicion] = i + 1;
            }
            return dt;
        }

        private void frmHistoriaClinica_Load(object sender, EventArgs e)
        {
            DataTable odtHistoriaClinica = new DataTable();
            CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();
            CapaDeNegocios.EstablecimientoSalud.cEstablecimientoSalud oEstablecimientoSalud = new CapaDeNegocios.EstablecimientoSalud.cEstablecimientoSalud();

            /*Maximizar ventana*/
            this.WindowState = FormWindowState.Maximized;
            /*Año y mes de historia clinica*/



            cbYear.DataSource = oHistoriaClinica.ListarYear();
            cbYear.ValueMember = "yyyy";
            cbYear.DisplayMember = "yyyy";

            establecer_combos_fecha_actual();

            bandera_combobox_año = true;

            año = Convert.ToInt16( this.cbYear.GetItemText(this.cbYear.SelectedItem));
            mes = Convert.ToInt16 (this.cbMonth.GetItemText(this.cbMonth.SelectedIndex));
            mes = mes + 1;
            
            /*datagridview odontologo*/

            odtOdontologo.Columns.Add("N°", typeof(string));
            odtOdontologo.Columns.Add("Segunda visita", typeof(string));

            DataGridViewButtonColumn dgvbOdontologo = new DataGridViewButtonColumn();
            dgvbOdontologo.Name = "Acción";
            dgvbOdontologo.Text = "Eliminar";
            dgvbOdontologo.HeaderText = "Acción";
            dgvbOdontologo.UseColumnTextForButtonValue = true;
            
            int columnIndex = 0;

            dgvOdontologia.DataSource = odtOdontologo;
            
            
            dgvOdontologia.Columns.Insert(columnIndex, dgvbOdontologo);

            //dgvOdontologia.Columns[0].Width = 30;
            dgvOdontologia.Columns[1].Width = 30;

            /*datagridview ecografia*/

            DataGridViewButtonColumn dgvbEcografia = new DataGridViewButtonColumn();
            dgvbEcografia.Name = "Acción";
            dgvbEcografia.Text = "Eliminar";
            dgvbEcografia.HeaderText = "Acción";
            dgvbEcografia.UseColumnTextForButtonValue = true;

            odtEcografia.Columns.Add("N°", typeof(string));
            odtEcografia.Columns.Add("Fecha Ecografia", typeof(string));
            odtEcografia.Columns.Add("Semanas edad gestacional", typeof(string));
            odtEcografia.Columns.Add("Dias edad gestacional", typeof(string));

            columnIndex = 0;

            dgvEcografia.DataSource = odtEcografia;
            dgvEcografia.Columns[0].Width = 30;
            dgvEcografia.Columns.Insert(columnIndex, dgvbEcografia);

            /*datetimepicker 24 hrs format*/

            dtpTiempoLlegada.ShowUpDown = true;
            //dtpTiempoLlegada.MinDate
            dtpTiempoLlegada.CustomFormat = "HH:mm";
            dtpTiempoLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

            /*Id de obstetra*/
            oHistoriaClinica.Idtobstetra = IdObstetra;
            oHistoriaClinica.mes = mes;
            oHistoriaClinica.año = año;
            odtHistoriaClinica = enumerar_datatable(oHistoriaClinica.ListarHistoriaClinica(),1);
            dgvHC.DataSource = odtHistoriaClinica;

            dgvHC.Columns[0].Visible = false;

            cbBuscar.SelectedItem = cbBuscar.Items[0];

            string ruta = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));

            //backgroundimage = Image.FromFile(ruta + "\\odontologia.jpg");

            /*            
            //Listar establecimiento de salud
            cbEstablecimientoSalud.DataSource = oEstablecimientoSalud.ListarEstablecimiento();
            cbEstablecimientoSalud.DisplayMember = "Descripcion";
            cbEstablecimientoSalud.ValueMember = "Codigo";

            //seleccionando establecimiento de salud
            cbEstablecimientoSalud.SelectedValue = IdEstablecimiento;
            cbEstablecimientoSalud.Visible = false;
            */

            lblOrigenEESS.Visible = false;
            txtOrigenEESS.Visible = false;
            txtHistoriaClinica.Focus();
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void buAgregarOdontologia_Click(object sender, EventArgs e)
        {
            
        }

        private void borrar_item_odontologo  (int item ){
            
            if (dgvOdontologia.SelectedRows.Count>0)
            {
                //dgvOdontologia.Rows.RemoveAt(dgvOdontologia.CurrentRow.Index);
                dgvOdontologia.Rows.RemoveAt(item);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvOdontologia_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //string col = dgvOdontologia.Rows[e.RowIndex].Cells[0].Value.ToString();
                //bool COL = dgvOdontologia.Rows[e.RowIndex].Cells[0].Selected;
                //string dgvOdontologia.SelectedColumns[i].Index.ToString();

                if (dgvOdontologia.CurrentCell.ColumnIndex == 0)                {
                    
                    int indice = e.RowIndex + 1;

                    if (MessageBox.Show("Está seguro que desea eliminar la visita odontologica Nº "+ indice , "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {
                        //dgvOdontologia.Rows.RemoveAt(e.RowIndex);
                        odtOdontologo.Rows.RemoveAt(e.RowIndex);

                        for (int i=0; i<odtOdontologo.Rows.Count; i++ ) {
                            odtOdontologo.Rows[i][0] = i + 1;
                        }

                        dgvOdontologia.DataSource = odtOdontologo;
                        return;
                    }
                }
            }
        }

        private void buAgregarEcografia_Click(object sender, EventArgs e)
        {

        }

        private void dgvEcografia_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //string col = dgvOdontologia.Rows[e.RowIndex].Cells[0].Value.ToString();
                //bool COL = dgvOdontologia.Rows[e.RowIndex].Cells[0].Selected;
                //string dgvOdontologia.SelectedColumns[i].Index.ToString();

                if (dgvEcografia.CurrentCell.ColumnIndex == 0)
                {

                    int indice = e.RowIndex + 1;

                    if (MessageBox.Show("Está seguro que desea eliminar la Ecografia Nº " + indice, "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {
                        //dgvOdontologia.Rows.RemoveAt(e.RowIndex);
                        odtEcografia.Rows.RemoveAt(e.RowIndex);

                        for (int i = 0; i < odtEcografia.Rows.Count; i++)
                        {
                            odtEcografia.Rows[i][0] = i + 1;
                        }

                        dgvEcografia.DataSource = odtEcografia;
                        return;
                    }
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buGuardar_Click(object sender, EventArgs e)
        {
            


        }

        private void nueva_historia_clinica() {
            txtHistoriaClinica.Text = "";

            dtpTiempoLlegada.Text = "";
            txtEdad.Text = "";
            txtDNI.Text = "";
            txtNombreCompleto.Text = "";

            nudGestas.Value = 0;
            nudPartos.Value = 0;
            nudAbortos.Value = 0;
            nudHv.Value = 0;
            nudHm.Value = 0;

            odtEcografia.Rows.Clear();
            odtOdontologo.Rows.Clear();

            dgvOdontologia.DataSource = odtOdontologo;
            dgvEcografia.DataSource = odtEcografia;
            IdtHistoriaClinica = "";

            dtpFecha.Value = DateTime.Now;

            txtObservaciones.Text = "";
            txtHistoriaClinica.Focus();
            cbTranseunte.Checked = false;
            cbArchivado.Checked = false;
            explorando_hc = false;
        }

 

        private void rbPrimerTrimestre_CheckedChanged(object sender, EventArgs e)
        {
 

        }

        private void rbSegundoTrimestre_CheckedChanged(object sender, EventArgs e)
        {
 
        }

        private void rbTercerTrimestre_CheckedChanged(object sender, EventArgs e)
        {
         }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IdtHistoriaClinica != "") {
                Bateria.frmBateria fBateria = new Bateria.frmBateria(IdtHistoriaClinica,IdEstablecimiento );
                //fBateria.MdiParent = this;
                fBateria.ShowDialog();
            }
            else
                MessageBox.Show("Porfavor seleccione una Historia Clinica.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cargar_hc() {
            DataTable odtHCXIdHC = new DataTable();
            //DataTable odtEcografia = new DataTable();
            //DataTable odtOdontologia = new DataTable();

            CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();
            CapaDeNegocios.cEcografia oEcografia = new CapaDeNegocios.cEcografia();
            CapaDeNegocios.cOdontologia oOdontologia = new CapaDeNegocios.cOdontologia();

            oHistoriaClinica.Idthistoriaclinica = IdtHistoriaClinica;
            odtHCXIdHC = oHistoriaClinica.ListarHistoriaClinicaLargo();

            IdtHistoriaClinica = odtHCXIdHC.Rows[0][0].ToString();
            Codigo_Historia_Clinica = odtHCXIdHC.Rows[0][1].ToString();
            Fecha = odtHCXIdHC.Rows[0][21].ToString();
            DNI = odtHCXIdHC.Rows[0][16].ToString();
            Nombre_Completo = odtHCXIdHC.Rows[0][17].ToString() + ", " + odtHCXIdHC.Rows[0][18].ToString() + " " + odtHCXIdHC.Rows[0][19].ToString();
            Edad = odtHCXIdHC.Rows[0][4].ToString();



            txtDNI.Text = odtHCXIdHC.Rows[0][16].ToString();
            txtNombreCompleto.Text = odtHCXIdHC.Rows[0][17].ToString() + ", " + odtHCXIdHC.Rows[0][18].ToString() + " " + odtHCXIdHC.Rows[0][19].ToString();

            txtHistoriaClinica.Text = odtHCXIdHC.Rows[0][1].ToString();
            cboTipoLlegada.Text = odtHCXIdHC.Rows[0][2].ToString();
            dtpTiempoLlegada.Text = odtHCXIdHC.Rows[0][3].ToString(); ;
            txtEdad.Text = odtHCXIdHC.Rows[0][4].ToString();

            nudGestas.Text = odtHCXIdHC.Rows[0][5].ToString();
            nudPartos.Text = odtHCXIdHC.Rows[0][6].ToString();
            nudAbortos.Text = odtHCXIdHC.Rows[0][7].ToString();
            nudHv.Text = odtHCXIdHC.Rows[0][8].ToString();
            nudHm.Text = odtHCXIdHC.Rows[0][9].ToString();
            dtpFUR.Value = Convert.ToDateTime(odtHCXIdHC.Rows[0][10]);
            dtpFPP.Value = Convert.ToDateTime(odtHCXIdHC.Rows[0][11]);
            int trimestreapn = Convert.ToInt16(odtHCXIdHC.Rows[0][12]);

            if (trimestreapn == 1) rbPrimerTrimestre.Checked = true;
            if (trimestreapn == 2) rbSegundoTrimestre.Checked = true;
            if (trimestreapn == 3) rbTercerTrimestre.Checked = true;


            nudSemanas.Text = odtHCXIdHC.Rows[0][13].ToString();
            txtObservaciones.Text = odtHCXIdHC.Rows[0][14].ToString();


            idtpaciente = odtHCXIdHC.Rows[0][15].ToString();
            IdObstetra = odtHCXIdHC.Rows[0][20].ToString();
            dtpFecha.Value = Convert.ToDateTime(odtHCXIdHC.Rows[0][21].ToString());

            if (odtHCXIdHC.Rows[0][22].ToString() == "1")
                cbTranseunte.Checked = true;
            else
                cbTranseunte.Checked = false;

            

            //cbEstablecimientoSalud.SelectedValue = odtHCXIdHC.Rows[0][23].ToString();

            txtOrigenEESS.Text = odtHCXIdHC.Rows[0][23].ToString();

            explorando_hc = true;

            if (odtHCXIdHC.Rows[0][24].ToString() == "1")
            {
                cbArchivado.Checked = true;
                Archivado = true;
            }
            else
            {
                cbArchivado.Checked = false;
                Archivado = false;
            }

            explorando_hc = false;


            /* Llenando ecografias y odontologia */
            oEcografia.Idthistoriaclinica = IdtHistoriaClinica;
            odtEcografia = oEcografia.ListarEcografiaXIdHC();
            dgvEcografia.DataSource = odtEcografia;

            oOdontologia.Idthistoriaclinica = IdtHistoriaClinica;
            odtOdontologo = oOdontologia.ListarOdontologiaXIdHC();
            dgvOdontologia.DataSource = odtOdontologo;

            dgvOdontologia.Columns[1].Width = 30;
            dgvEcografia.Columns[1].Width = 30;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void dgvHC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text;
            CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();
            CapaDeNegocios.Paciente.cPaciente oPaciente = new CapaDeNegocios.Paciente.cPaciente();

            string seleccionado = this.cbBuscar.GetItemText(this.cbBuscar.SelectedItem);


            

            if (seleccionado == "Historia Clinica") { 

                if (buscar.Length > 1) {
                    oHistoriaClinica.Codigohistoriaclinica = buscar;
                    oHistoriaClinica.Idtobstetra = IdObstetra;
                    dgvHC.DataSource = enumerar_datatable(oHistoriaClinica.ListarHistoriaClinicaXHistoriaClinica(),1);
                    dgvHC.Columns[0].Visible = false;
                }
            }

            if (seleccionado == "Apellido Paterno")
            {
                if (buscar.Length > 1)
                {
                    oPaciente.apellidopaterno = buscar;
                    oPaciente.idtobstetra = IdObstetra;
                    dgvHC.DataSource = enumerar_datatable(oPaciente.ListarHistoriaClinicaXApellidoPaterno(),1);
                    dgvHC.Columns[0].Visible = false;
                }
            }

            if (seleccionado == "Apellido Materno")
            {
                if (buscar.Length > 1)
                {
                    oPaciente.apellidomaterno = buscar;
                    oPaciente.idtobstetra = IdObstetra;
                    dgvHC.DataSource = enumerar_datatable(oPaciente.ListarHistoriaClinicaXApellidoMaterno(),1);
                    dgvHC.Columns[0].Visible = false;
                }
            }

            if (seleccionado == "Nombres")
            {
                if (buscar.Length > 1)
                {
                    oPaciente.nombres = buscar;
                    oPaciente.idtobstetra = IdObstetra;
                    dgvHC.DataSource = enumerar_datatable(oPaciente.ListarHistoriaClinicaXNombres(),1);
                    dgvHC.Columns[0].Visible = false;
                }
            }

            if (seleccionado == "DNI")
            {
                if (buscar.Length > 1)
                {
                    oPaciente.dni = buscar;
                    oPaciente.idtobstetra = IdObstetra;
                    dgvHC.DataSource = enumerar_datatable(oPaciente.ListarHistoriaClinicaXDNI(),1);
                    dgvHC.Columns[0].Visible = false;
                }
            }

            if (buscar.Length < 1)
            {
                oHistoriaClinica.Idtobstetra = IdObstetra;
                oHistoriaClinica.mes = mes;
                oHistoriaClinica.año = año;
                dgvHC.DataSource = enumerar_datatable(oHistoriaClinica.ListarHistoriaClinica(),1);
                dgvHC.Columns[0].Visible = false;
            }




        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void listar_historia_clinica() {

            if (bandera_combobox_año){
                CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();
                DataTable odtHC = new DataTable();
                año = 0; mes = 0;
                año = Convert.ToInt16( cbYear.GetItemText(cbYear.SelectedItem) );
                mes = Convert.ToInt16(cbMonth.GetItemText(cbMonth.SelectedIndex));
                mes = mes + 1;

                oHistoriaClinica.año = año;
                oHistoriaClinica.mes = mes;

                oHistoriaClinica.Idtobstetra = IdObstetra;
                odtHC = enumerar_datatable(oHistoriaClinica.ListarHistoriaClinica(),1);
                dgvHC.DataSource = odtHC ;
            }
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void dgvOdontologia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //DataGridViewRow row = dgvOdontologia.Rows[e.RowIndex];
            //row.DefaultCellStyle.BackColor = Color.Transparent;
        }

        private void dgvOdontologia_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //e.Graphics.DrawImage(backgroundimage, e.RowBounds);
        }

        private void nudSemanas_ValueChanged_1(object sender, EventArgs e)
        {
            /* 
                nudSemanas.Minimum = 1;
                nudSemanas.Maximum = 12;

                nudSemanas.Minimum = 13;
                nudSemanas.Maximum = 28;

                nudSemanas.Minimum = 29;
                nudSemanas.Maximum = 42; 
              */

            
            int trimestre = Convert.ToInt16(nudSemanas.Value);

            if (trimestre >=1 && trimestre <= 12){
                rbTercerTrimestre.Checked = false;
                rbSegundoTrimestre.Checked = false;
                rbPrimerTrimestre.Checked = true;
            }
            if (trimestre >= 13 && trimestre <= 28) {
                rbTercerTrimestre.Checked = false;
                rbPrimerTrimestre.Checked = false;
                rbSegundoTrimestre.Checked = true;
            }
            if (trimestre >= 29 && trimestre <= 42) {
                rbTercerTrimestre.Checked = true;
                rbSegundoTrimestre.Checked = false;
                rbPrimerTrimestre.Checked = false;
            } 
            
            

        }

        private void btnAtencionPrenatal_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (IdtHistoriaClinica != "")
            {
                CitaPreNatal.frmCitaPreNatal fCitaPrenatal = new CitaPreNatal.frmCitaPreNatal();
                fCitaPrenatal.HistoriaClinica = IdtHistoriaClinica;
                fCitaPrenatal.Establecimiento = IdEstablecimiento;
                fCitaPrenatal.ShowDialog();

            }
            else
                MessageBox.Show("Porfavor seleccione una Historia Clinica.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRecienNacido_Click(object sender, EventArgs e)
        {
            if (IdtHistoriaClinica != "")
            {
                RecienNacido.frmRecienNacido miRecienNacido = new RecienNacido.frmRecienNacido(IdtHistoriaClinica, IdEstablecimiento);
                //fBateria.MdiParent = this;
                miRecienNacido.ShowDialog();
            }
            else
                MessageBox.Show("Porfavor seleccione una Historia Clinica.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtHistoriaClinica_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtHistoriaClinica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                buAgregarOdontologia.Focus();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void cbTranseunte_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbTranseunte.Checked == false)
            {
                lblOrigenEESS.Visible = false;
                //cbEstablecimientoSalud.Visible = false;
                txtOrigenEESS.Visible = false;
            }
            else {
                lblOrigenEESS.Visible = true;
                //cbEstablecimientoSalud.Visible = true;
                txtOrigenEESS.Visible = true;
            }


        }

        private void dtpFUR_ValueChanged_1(object sender, EventArgs e)
        {
           
        }

        private void dtpFUR_KeyUp_1(object sender, KeyEventArgs e)
        {
            hallar_FPP();
        }


        private void hallar_FPP (){
            DateTime FUR = dtpFUR.Value;
            FUR = FUR.AddDays(7);
            FUR = FUR.AddMonths(-3);
            FUR = FUR.AddYears(1);
            dtpFPP.Value = FUR;
        }

        private void nudGestas_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void nudPartos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void nudAbortos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void nudHv_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void nudHm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dtpFUR_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                cboTipoLlegada.Focus();
        }

        private void cboTipoLlegada_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dtpTiempoLlegada_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void nudSemanas_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dtpOdontologo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dtpEcografia_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void nudEdadGestacional_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void nudDiasEcografia_KeyPress(object sender, KeyPressEventArgs e)
        {
  
        }

        private void txtObservaciones_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbTranseunte_KeyPress(object sender, KeyPressEventArgs e)
        {



        }

        private void cbEstablecimientoSalud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                buGuardar.Focus();

        }

        private void cbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
   
        }

        private void frmHistoriaClinica_Activated(object sender, EventArgs e)
        {
            txtHistoriaClinica.Focus();
        }

        private void nudEdadGestacional_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                nudDiasEcografia.Focus();
                nudDiasEcografia.Select(0, nudDiasEcografia.Text.Length);
            }
        }

        private void nudDiasEcografia_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                buAgregarEcografia.Focus();
            }
        }

        private void buAgregarEcografia_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void buGuardar_Click_1(object sender, EventArgs e)
        {
            //try{ 

            CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();
            CapaDeNegocios.cEcografia oEcografia = new CapaDeNegocios.cEcografia();
            CapaDeNegocios.cOdontologia oOdontologia = new CapaDeNegocios.cOdontologia();

            DataTable odtHistoriaClinica = new DataTable();
            bool completo = false;
            string mensaje = "";



            oHistoriaClinica.Idtestablecimientosalud = IdEstablecimiento;
            oHistoriaClinica.Codigohistoriaclinica = txtHistoriaClinica.Text;
            oHistoriaClinica.Tipollegada = cboTipoLlegada.Text;
            oHistoriaClinica.Tiempollegada = dtpTiempoLlegada.Text;
            if (txtEdad.Text != "")
                oHistoriaClinica.Edad = Convert.ToInt16(txtEdad.Text);

            oHistoriaClinica.Gestas = Convert.ToInt16(nudGestas.Text);
            oHistoriaClinica.Partos = Convert.ToInt16(nudPartos.Text);
            oHistoriaClinica.Abortos = Convert.ToInt16(nudAbortos.Text);
            oHistoriaClinica.Hijosvivos = Convert.ToInt16(nudHv.Text);
            oHistoriaClinica.Hijosmuertos = Convert.ToInt16(nudHm.Text);
            oHistoriaClinica.Fur = dtpFUR.Value.Date;
            oHistoriaClinica.Fpp = dtpFPP.Value.Date;

            bool isChecked1ertrimestre = rbPrimerTrimestre.Checked;
            bool isChecked2dotrimestre = rbSegundoTrimestre.Checked;
            bool isChecked3ertrimestre = rbTercerTrimestre.Checked;

            int respuesta_radiobutton = 1;


            if (isChecked1ertrimestre)
                respuesta_radiobutton = 1;

            if (isChecked2dotrimestre)
                respuesta_radiobutton = 2;

            if (isChecked3ertrimestre)
                respuesta_radiobutton = 3;

            oHistoriaClinica.Trimestreapn = respuesta_radiobutton;
            oHistoriaClinica.Diaapn = Convert.ToString(nudSemanas.Value);
            oHistoriaClinica.Observaciones = txtObservaciones.Text;
            oHistoriaClinica.Idtpaciente = idtpaciente;
            oHistoriaClinica.Idtobstetra = IdObstetra;
            oHistoriaClinica.Fecha = dtpFecha.Value;

            if (cbTranseunte.Checked == true)
            {
                oHistoriaClinica.Transeunte = 1;
                oHistoriaClinica.OrigenEESS = txtOrigenEESS.Text.ToString();
            }
            else
            {
                oHistoriaClinica.Transeunte = 0;
                oHistoriaClinica.OrigenEESS = "";
            }

            if (cbArchivado.Checked == true)
            {
                oHistoriaClinica.Archivado = 1; 
            }
            else {
                oHistoriaClinica.Archivado = 0;
            }

            /*Validando datos*/

            if (dgvOdontologia.Rows.Count < 0)
            {
                completo = true;
                mensaje = "Porfavor agregar fecha(s) del servicio de Odontologia.";
            }

            if (dgvEcografia.Rows.Count < 0)
            {
                completo = true;
                mensaje = "Porfavor agregar fecha(s) del servicio de Ecografia Obstetrica.";
            }

            if (oHistoriaClinica.Diaapn == "")
            {
                completo = true;
                mensaje = "Porfavor llenar dia(s) APN.";
            }

            if (oHistoriaClinica.Tiempollegada == "00:00")
            {
                completo = true;
                mensaje = "Porfavor seleccionar Tiempo de llegada.";
            }

            if (oHistoriaClinica.Tipollegada == "")
            {
                completo = true;
                mensaje = "Porfavor seleccionar tipo de llegada.";
            }

            if (idtpaciente == "")
            {
                completo = true;
                mensaje = "Porfavor seleccionar una gestante.";
            }

            if (oHistoriaClinica.Codigohistoriaclinica == "")
            {
                completo = true;
                mensaje = "Porfavor llenar Codigo de Historia Clinica";
            }

            DataTable dtEcografia = new DataTable();
            DataTable dtOdontologia = new DataTable();
            DataTable dtEcografia2 = new DataTable();
            DataTable dtOdontologia2 = new DataTable();


            if (Archivado) { 
                if (cbArchivado.Checked)
                    Archivado = true;
                else
                    Archivado = false;
            }

            if (completo)
            {
                MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Archivado)
                {
                    MessageBox.Show("Control de gestante archivado. No se puede modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    


                    if (IdtHistoriaClinica != "")
                    {
                        oHistoriaClinica.Idthistoriaclinica = IdtHistoriaClinica;
                        odtHistoriaClinica = oHistoriaClinica.ModificarHistoriaClinica();

                        oEcografia.Idthistoriaclinica = IdtHistoriaClinica;
                        dtEcografia = oEcografia.EliminarEcografia();

                        oOdontologia.Idthistoriaclinica = IdtHistoriaClinica;
                        dtOdontologia = oOdontologia.EliminarOdontologia();
                    }
                    else
                        odtHistoriaClinica = oHistoriaClinica.CrearHistoriaClinica();

                    foreach (DataRow row in odtHistoriaClinica.Rows)
                    {

                        string respuesta_historia_clinica = row[0].ToString().Trim();

                        string[] words = respuesta_historia_clinica.Split('*');

                        string exito = words[0].ToString();
                        string respuesta = words[1].ToString();
                        string idthistoriaclinica = words[2].ToString();
                        string searchValue = idthistoriaclinica;

                        int suma_ecografia = 0;
                        int suma_odontologia = 0;
                        int cantidad_filas_ecografia = 0;
                        int cantidad_filas_odontologia = 0;
                        string[] words_ecografia;
                        string[] words_odontologia;
                        string respuesta_ecografia = "";
                        string respuesta_odontologia = "";

                        if (exito == "0")
                            MessageBox.Show(respuesta, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (exito == "1")
                        {
                            cantidad_filas_ecografia = dgvEcografia.Rows.Count;
                            for (int i = 0; i < cantidad_filas_ecografia; i++)
                            {
                                respuesta_ecografia = dgvEcografia[3, i].Value.ToString();

                                oEcografia.Fecha_servicio = Convert.ToDateTime(dgvEcografia[2, i].Value.ToString());
                                oEcografia.Edadgestacional = dgvEcografia[3, i].Value.ToString();
                                oEcografia.Diagestacional = dgvEcografia[4, i].Value.ToString();
                                oEcografia.Idtestablecimientosalud = IdEstablecimiento;

                                if (IdtHistoriaClinica != "")
                                    oEcografia.Idthistoriaclinica = IdtHistoriaClinica;
                                else
                                    oEcografia.Idthistoriaclinica = idthistoriaclinica;

                                dtEcografia = oEcografia.CrearEcografia();

                                foreach (DataRow row_e in dtEcografia.Rows)
                                {
                                    respuesta_ecografia = row_e[0].ToString().Trim();
                                    words_ecografia = respuesta_ecografia.Split('-');
                                    suma_ecografia = suma_ecografia + Convert.ToInt16(words_ecografia[0].ToString());
                                }
                            }


                            cantidad_filas_odontologia = dgvOdontologia.Rows.Count;
                            for (int i = 0; i < cantidad_filas_odontologia; i++)
                            {
                                oOdontologia.Fecha_servicio = Convert.ToDateTime(dgvOdontologia[2, i].Value.ToString());
                                oOdontologia.Idtestablecimientosalud = IdEstablecimiento;

                                if (IdtHistoriaClinica != "")
                                    oOdontologia.Idthistoriaclinica = IdtHistoriaClinica;
                                else
                                    oOdontologia.Idthistoriaclinica = idthistoriaclinica;

                                dtOdontologia = oOdontologia.CrearOdontologia();
                                foreach (DataRow row_o in dtOdontologia.Rows)
                                {
                                    respuesta_odontologia = row_o[0].ToString().Trim();
                                    words_odontologia = respuesta_odontologia.Split('-');
                                    suma_odontologia = suma_odontologia + Convert.ToInt16(words_odontologia[0].ToString());
                                }
                            }

                            if (cantidad_filas_ecografia == suma_ecografia && suma_odontologia == cantidad_filas_odontologia)
                            {
                                MessageBox.Show(respuesta, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                año = año_numero;
                                mes = mes_numero;

                                establecer_combos_fecha_actual();

                                oHistoriaClinica.año = dtpFecha.Value.Year;
                                oHistoriaClinica.mes = dtpFecha.Value.Month;

                                cbYear.SelectedValue = dtpFecha.Value.Year;
                                cbMonth.SelectedItem = cbMonth.Items[dtpFecha.Value.Month - 1];

                                oHistoriaClinica.Idtobstetra = IdObstetra;
                                dgvHC.DataSource = enumerar_datatable(oHistoriaClinica.ListarHistoriaClinica(), 1);
                                dgvHC.Columns[0].Visible = false;
                                nueva_historia_clinica();

                                int rowIndex = 0;
                                string item = "";


                                /*Buscando indice del item agregado o modificado*/
                                for (int i = 0; i < dgvHC.Rows.Count; i++)
                                {
                                    item = dgvHC.Rows[i].Cells[0].Value.ToString();
                                    if (item.Trim() == searchValue.Trim())
                                    {
                                        rowIndex = i;
                                        break;
                                    }
                                }

                                dgvHC.Rows[rowIndex].Selected = true;
                                dgvHC.CurrentCell = dgvHC.Rows[rowIndex].Cells[1];

                            }
                        }
                    }
                }
            }

            /*
        }
        catch (Exception ex)
        {
            MessageBox.Show( ex.StackTrace +' ' + ex.Source +' '+ ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        */
        }

        private void txtHistoriaClinica_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                buAgregarOdontologia.Focus();
        }

        private void buAgregarOdontologia_Click_1(object sender, EventArgs e)
        {
            frmGestante frmGestanteHC = new frmGestante(IdEstablecimiento);
            //frmGestante.MdiParent = this;
            if (frmGestanteHC.ShowDialog() == DialogResult.OK)
            {
                txtDNI.Text = frmGestanteHC.DNI;
                txtNombreCompleto.Text = frmGestanteHC.nombres + ", " + frmGestanteHC.app + " " + frmGestanteHC.apm;

                DateTime fn_ = frmGestanteHC.fn;

                DateTime now = DateTime.Today;
                int age = now.Year - fn_.Year;
                if (now < fn_.AddYears(age)) age--;

                txtEdad.Text = age.ToString();
                idtpaciente = frmGestanteHC.idtpaciente;
                nudGestas.Focus();
                nudGestas.Select(0, nudGestas.Text.Length);
            }
        }

        private void nudGestas_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                nudPartos.Focus();
                nudPartos.Select(0, nudPartos.Text.Length);
            }
        }

        private void nudPartos_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                nudAbortos.Focus();
                nudAbortos.Select(0, nudAbortos.Text.Length);
            }
        }

        private void nudAbortos_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                nudHv.Focus();
                nudHv.Select(0, nudHv.Text.Length);
            }
        }

        private void nudHv_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                nudHm.Focus();
                nudHm.Select(0, nudHm.Text.Length);
            }
        }

        private void nudHm_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudHm_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                dtpFUR.Focus();
        }

        private void dtpFUR_ValueChanged(object sender, EventArgs e)
        {
            hallar_FPP();
        }

        private void cboTipoLlegada_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                dtpTiempoLlegada.Focus();
        }

        private void dtpTiempoLlegada_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                nudSemanas.Focus();
                nudSemanas.Select(0, nudSemanas.Text.Length);
            }
        }

        private void nudSemanas_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                dtpOdontologo.Focus();
        }

        private void dtpOdontologo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                button2.Focus();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DataRow drOdontologo = odtOdontologo.NewRow();


            drOdontologo = odtOdontologo.NewRow();
            i = odtOdontologo.Rows.Count;
            i++;
            drOdontologo[0] = i;
            drOdontologo[1] = dtpOdontologo.Value.ToString("yyyy - MM - dd");
            //drOdontologo[2] = 
            odtOdontologo.Rows.InsertAt(drOdontologo, i);
            dtpOdontologo.Focus();
        }

        private void dtpEcografia_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                nudEdadGestacional.Focus();
                nudEdadGestacional.Select(0, nudEdadGestacional.Text.Length);
            }
        }

        private void nudEdadGestacional_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                nudDiasEcografia.Focus();
                nudDiasEcografia.Select(0, nudDiasEcografia.Text.Length);
            }
        }

        private void nudDiasEcografia_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                buAgregarEcografia.Focus();
        }

        private void buAgregarEcografia_Click_1(object sender, EventArgs e)
        {
            DataRow drEcografia = odtEcografia.NewRow();
            drEcografia = odtEcografia.NewRow();
            i = odtEcografia.Rows.Count;
            i++;
            drEcografia[0] = i;
            drEcografia[1] = dtpEcografia.Value.ToString("yyyy - MM - dd");
            drEcografia[2] = nudEdadGestacional.Value;
            drEcografia[3] = nudDiasEcografia.Value;
            odtEcografia.Rows.InsertAt(drEcografia, i);
            dtpEcografia.Focus();
        }

        private void txtObservaciones_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                cbTranseunte.Focus();
        }

        private void cbTranseunte_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (cbTranseunte.Checked == false)
                {
                    //buGuardar.Focus();
                    cbArchivado.Focus();
                }
                else
                {
                    //cbEstablecimientoSalud.Focus();
                    txtOrigenEESS.Focus();
                }
            }
        }

        private void txtOrigenEESS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                cbArchivado.Focus();
        }

        private void cbArchivado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                buGuardar.Focus();
        }

        private void cbBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtBuscar.Focus();
        }

        private void txtBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                cbYear.Focus();
        }

        private void cbYear_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                cbMonth.Focus();
        }

        private void cbMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                dgvHC.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            nueva_historia_clinica();
        }

        private void cbYear_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listar_historia_clinica();
        }

        private void cbMonth_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listar_historia_clinica();
        }

        private void buMorbilidad_Click(object sender, EventArgs e)
        {
            
            if (Codigo_Historia_Clinica != null) {

                frmMorbilidad fMorbilidad = new frmMorbilidad();
                fMorbilidad.Codigo_Historia_Clinica = Codigo_Historia_Clinica;
                fMorbilidad.Id_Historia_Clinica = IdtHistoriaClinica;
                fMorbilidad.Fecha = Fecha;
                fMorbilidad.DNI = DNI;
                fMorbilidad.Nomnbre_Completo = Nombre_Completo;
                fMorbilidad.Edad = Edad;
                fMorbilidad.IdEstablecimiento = IdEstablecimiento;
                fMorbilidad.Archivado = Archivado;

                fMorbilidad.ShowDialog();
            }else
                MessageBox.Show("Porfavor seleccione una Historia Clinica.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buControlPuerperio_Click(object sender, EventArgs e)
        {

            if (Codigo_Historia_Clinica != null)
            {
                ControlPeuperio.frmMantenimientoControlPeuperio fMantenimientoControlPuerperio = new ControlPeuperio.frmMantenimientoControlPeuperio(IdtHistoriaClinica);
                fMantenimientoControlPuerperio.Show();
            }
            else
                MessageBox.Show("Porfavor seleccione una Historia Clinica.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void buVisitaDomiciliaria_Click(object sender, EventArgs e)
        {

            if (Codigo_Historia_Clinica != null)
            {
                VisitaDomiciliaria.frmMantenimientoVisitaDomiciliaria fMantenimientoVisitaDomiciliaria = new VisitaDomiciliaria.frmMantenimientoVisitaDomiciliaria(IdtHistoriaClinica);
                fMantenimientoVisitaDomiciliaria.Show();
            }
            else
                MessageBox.Show("Porfavor seleccione una Historia Clinica.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            

            if (Codigo_Historia_Clinica != null)
            {
                TerminoGestacion.frmMantenimientoTerminoGestacion fMantenimientoTerminoGestacion = new TerminoGestacion.frmMantenimientoTerminoGestacion(IdtHistoriaClinica);
                fMantenimientoTerminoGestacion.Show();
            }
            else
                MessageBox.Show("Porfavor seleccione una Historia Clinica.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                IdtHistoriaClinica = dgvHC[0, e.RowIndex].Value.ToString();
                cargar_hc();
            }
        }

        private void dgvHC_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                IdtHistoriaClinica = dgvHC[0, e.RowIndex].Value.ToString();
                cargar_hc();
            }
        }

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bloquear_hc(bool bandera){

            txtHistoriaClinica.Enabled = bandera;
            cboTipoLlegada.Enabled = bandera;
            dtpTiempoLlegada.Enabled = bandera;
            txtEdad.Enabled = bandera;
            nudGestas.Enabled = bandera;
            nudPartos.Enabled = bandera;
            nudAbortos.Enabled = bandera;
            nudHv.Enabled = bandera;
            nudHm.Enabled = bandera;
            dtpFUR.Enabled = bandera;
            dtpFPP.Enabled = bandera;
            nudSemanas.Enabled = bandera;
            txtObservaciones.Enabled = bandera;
            cbTranseunte.Enabled = bandera;
            txtOrigenEESS.Enabled = bandera;
            dtpFecha.Enabled = bandera;
            buAgregarEcografia.Enabled = bandera;
            button2.Enabled = bandera;
            dgvEcografia.Enabled = bandera;
            dgvOdontologia.Enabled = bandera;
        }

        private void cbArchivado_CheckedChanged(object sender, EventArgs e)
        {
            if (!explorando_hc)
            {
                if (cbArchivado.Checked == true)
                {
                    if (MessageBox.Show("El presente control de gestante se bloqueara. ¿Está seguro de archivar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        lblArchivado.Text = "ARCHIVADO";
                        lblArchivado.BackColor = Color.Green;
                        cbArchivado.Checked = true;
                        bloquear_hc(false);
                    }
                    else
                    {
                        cbArchivado.Checked = false;
                        bloquear_hc(true);
                    }
                }

                if (cbArchivado.Checked == false)
                {
                    lblArchivado.Text = "SIN ARCHIVAR";
                    lblArchivado.BackColor = Color.Red;
                    bloquear_hc(true);
                }
            }
            else {
                if (cbArchivado.Checked == true)
                {
                    lblArchivado.Text = "ARCHIVADO";
                    lblArchivado.BackColor = Color.Green;
                    cbArchivado.Checked = true;
                    bloquear_hc(false);
                }

                if (cbArchivado.Checked == false)
                {
                    lblArchivado.Text = "SIN ARCHIVAR";
                    lblArchivado.BackColor = Color.Red;
                    bloquear_hc(true);
                }
            }

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }
    }
}


