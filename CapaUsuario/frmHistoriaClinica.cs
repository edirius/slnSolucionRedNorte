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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp;
using System.Windows.Forms.VisualStyles;

namespace CapaUsuario
{
    public partial class frmHistoriaClinica : Form
    {

        string folderPath = "C:\\PDFs\\";
        PdfPCell cell;

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
        public System.Drawing.Color _backDisabledColor { get; private set; }

        bool bnivel0 = false, bnivel1 = false, bnivel2 = false, bnivel3 = false, bnivel4 = false, bnivel5 = false;

        int i = 0;
        string obstetra = "";

        int año = 0;
        int mes = 0;

        int mes_numero = 0;
        int año_numero = 0;
        //Image backgroundimage;
        int mitad_cantidad_cronograma = 0;

        
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

        /*
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
        }
        */

        private void frmHistoriaClinica_Load(object sender, EventArgs e)
        {
            DataTable odtHistoriaClinica = new DataTable();
            CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();
            CapaDeNegocios.EstablecimientoSalud.cEstablecimientoSalud oEstablecimientoSalud = new CapaDeNegocios.EstablecimientoSalud.cEstablecimientoSalud();


            /*Año y mes de historia clinica*/

            /*datetimepicker property*/
            //this.SetStyle(ControlStyles.UserPaint, true);


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
            dgvEcografia.Columns[2].Width = 110;
            dgvEcografia.Columns[3].Width = 110;
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
            CapaUsuario.frmGestante fGestante = new CapaUsuario.frmGestante(IdEstablecimiento);

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
            dtpFecha.Focus();

            if (fGestante.ShowDialog() == DialogResult.OK)
            {
                txtDNI.Text = fGestante.DNI;
                txtNombreCompleto.Text = fGestante.nombres + ", " + fGestante.app + " " + fGestante.apm;
                txtHistoriaClinica.Text = fGestante.codigohistoriaclinica;

                DateTime fn_ = fGestante.fn;

                DateTime now = DateTime.Today;
                int age = now.Year - fn_.Year;
                if (now < fn_.AddYears(age)) age--;

                txtEdad.Text = age.ToString();
                idtpaciente = fGestante.idtpaciente;
                
                //nudGestas.Focus();
                dtpFecha.Focus();

                
            }

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
                    oHistoriaClinica.oPaciente.codigohistoriaclinica = buscar;
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
            /*Maximizar ventana*/
            this.WindowState = FormWindowState.Maximized;
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
            try{ 

            CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();
            CapaDeNegocios.cEcografia oEcografia = new CapaDeNegocios.cEcografia();
            CapaDeNegocios.cOdontologia oOdontologia = new CapaDeNegocios.cOdontologia();

            DataTable odtHistoriaClinica = new DataTable();
            bool completo = false;
            string mensaje = "";



            oHistoriaClinica.Idtestablecimientosalud = IdEstablecimiento;
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
            oHistoriaClinica.Semanaapn = Convert.ToString(nudSemanas.Value);
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

            if (oHistoriaClinica.Semanaapn == "")
            {
                completo = true;
                mensaje = "Porfavor llenar Semana(s) APN.";
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
                                //nueva_historia_clinica();
                                
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
                                IdtHistoriaClinica = dgvHC[0, rowIndex].Value.ToString();
                                Codigo_Historia_Clinica = dgvHC[3, rowIndex].Value.ToString();

                                    cargar_hc();

                                    if (cbArchivado.Checked)
                                        Archivado = true;
                                    else
                                        Archivado = false;

                                }
                        }
                    }
                }
            }

            
        }
        catch (Exception ex)
        {
            MessageBox.Show( ex.StackTrace +' ' + ex.Source +' '+ ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        
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
                buAgregarOdontologia.Focus();
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
            //dtpEcografia.Focus();
            txtObservaciones.Focus();
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

        private void buVisitaDomiciliaria_Click(object sender, EventArgs e)
        {

            if (Codigo_Historia_Clinica != null)
            {
                VisitaDomiciliaria.frmMantenimientoVisitaDomiciliaria fMantenimientoVisitaDomiciliaria = new VisitaDomiciliaria.frmMantenimientoVisitaDomiciliaria(IdtHistoriaClinica);
                fMantenimientoVisitaDomiciliaria.ShowDialog();
            }
            else
                MessageBox.Show("Porfavor seleccione una Historia Clinica.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnTerminoGestacion_Click(object sender, EventArgs e)
        {
            if (Codigo_Historia_Clinica != null)
            {
                TerminoGestacion.frmMantenimientoTerminoGestacion fMantenimientoTerminoGestacion = new TerminoGestacion.frmMantenimientoTerminoGestacion(IdtHistoriaClinica);
                fMantenimientoTerminoGestacion.ShowDialog();
            }
            else
                MessageBox.Show("Porfavor seleccione una Historia Clinica.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buControlPuerperio_Click(object sender, EventArgs e)
        {
            if (Codigo_Historia_Clinica != null)
            {
                ControlPeuperio.frmMantenimientoControlPeuperio fMantenimientoControlPuerperio = new ControlPeuperio.frmMantenimientoControlPeuperio(IdtHistoriaClinica);
                fMantenimientoControlPuerperio.ShowDialog();
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
            buAgregarOdontologia.Enabled = bandera;
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
                        lblArchivado.BackColor = System.Drawing.Color.Green;
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
                    lblArchivado.BackColor = System.Drawing.Color.Red;
                    bloquear_hc(true);
                }
            }
            else {
                if (cbArchivado.Checked == true)
                {
                    lblArchivado.Text = "ARCHIVADO";
                    lblArchivado.BackColor = System.Drawing.Color.Green;
                    cbArchivado.Checked = true;
                    bloquear_hc(false);
                }

                if (cbArchivado.Checked == false)
                {
                    lblArchivado.Text = "SIN ARCHIVAR";
                    lblArchivado.BackColor = System.Drawing.Color.Red;
                    bloquear_hc(true);
                }
            }

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void buAgregarOdontologia_Click_2(object sender, EventArgs e)
        {
            DataRow drOdontologo = odtOdontologo.NewRow();


            drOdontologo = odtOdontologo.NewRow();
            i = odtOdontologo.Rows.Count;
            i++;
            drOdontologo[0] = i;
            drOdontologo[1] = dtpOdontologo.Value.ToString("yyyy - MM - dd");
            //drOdontologo[2] = 
            odtOdontologo.Rows.InsertAt(drOdontologo, i);
            //dtpOdontologo.Focus();
            dtpEcografia.Focus();
        }

        private void dtpFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                nudGestas.Focus();
                nudGestas.Select(0, nudGestas.Text.Length);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void rbPrimerTrimestre_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void verificar_niveles(DataTable odt, int indice) {

            if (odt.Rows[0][indice].ToString() == "") bnivel0 = true; else bnivel0 = false;
            if (odt.Rows[1][indice].ToString() == "") bnivel1 = true; else bnivel1 = false;
            if (odt.Rows[2][indice].ToString() == "") bnivel2 = true; else bnivel2 = false;
            if (odt.Rows[3][indice].ToString() == "") bnivel3 = true; else bnivel3 = false;
            if (odt.Rows[4][indice].ToString() == "") bnivel4 = true; else bnivel4 = false;
            
            //if (odt.Rows[5][indice].ToString() == "") bnivel5 = true; else bnivel5 = false;

        }

        private DataTable interceptar_campos(int inicio, int fin, DataTable odt) {

            DataTable odtIntercepcion = new DataTable();
            DataRow drFilaIntercepcion = odtIntercepcion.NewRow();
            odtIntercepcion.Columns.Add("INTERCEPCION", typeof(string));
            string fecha = "";
            string prox_fecha = "";
            string etiqueta_fecha = "";
            string etiqueta_fecha_parto = "";
            string etiqueta_hoy = "";
            int j = 0;
            int l = 0;

            for (int i = inicio; i < fin-l; i++) {
                fecha = odt.Rows[5][i].ToString();
                prox_fecha = odt.Rows[5][i+1].ToString();
                if (fecha == prox_fecha)
                {
                    drFilaIntercepcion = odtIntercepcion.NewRow();
                    drFilaIntercepcion[0] = i+1;
                    odtIntercepcion.Rows.InsertAt(drFilaIntercepcion, j);
                    j++;

                    /*pasando la etiqueta de un lado a otro*/
                    verificar_niveles(odt,i);
                    etiqueta_fecha = odt.Rows[4][i+1].ToString();

                    /*intercepcion parto*/
                    etiqueta_fecha_parto = odt.Rows[0][i + 1].ToString();
                    if (etiqueta_fecha_parto != "")
                        odt.Rows[0][i] = etiqueta_fecha_parto;

                    /*intercepcion hoy*/
                    
                    etiqueta_hoy = odt.Rows[6][i + 1].ToString();
                    if (etiqueta_hoy != "" )
                        odt.Rows[6][i] = etiqueta_hoy;

                    if (bnivel4) {
                        odt.Rows[4][i] = etiqueta_fecha;
                        bnivel0 = false; bnivel1 = false; bnivel2 = false; bnivel3 = false;
                    }
                    if (bnivel3) {
                        odt.Rows[3][i] = etiqueta_fecha;
                        bnivel0 = false; bnivel1 = false; bnivel2 = false; bnivel4 = false;
                    }
                    if (bnivel2) {
                        odt.Rows[2][i] = etiqueta_fecha;
                        bnivel0 = false; bnivel1 = false; bnivel3 = false; bnivel4 = false;
                    }
                    if (bnivel1) {
                        odt.Rows[1][i] = etiqueta_fecha;
                        bnivel0 = false; bnivel2 = false; bnivel3 = false; bnivel4 = false;
                    }
                    if (bnivel0) {
                        odt.Rows[0][i] = etiqueta_fecha;
                        bnivel1 = false; bnivel2 = false; bnivel3 = false; bnivel4 = false;
                    }

                    /*eliminando columna*/
                    odt.Columns.RemoveAt(i+1);
                    l++;
                }
            }
 

            return odt;
        }

        private DataTable ordenar_fechas(DataTable odt)
        {
            DateTime fecha;
            DateTime prox_fecha;

            string etiqueta_fecha;
            string Fecha;

            for (int i = 0; i < odt.Columns.Count-1 ; i++)
            {
                etiqueta_fecha = odt.Rows[4][i].ToString();
                fecha = Convert.ToDateTime(odt.Rows[5][i]) ;
                prox_fecha = Convert.ToDateTime( odt.Rows[5][i + 1]);
                
                if (fecha > prox_fecha)
                {
                    odt.Rows[4][i] = odt.Rows[1][i+1].ToString();
                    odt.Rows[5][i] = odt.Rows[2][i+1].ToString();

                    odt.Rows[4][i+1] = etiqueta_fecha;
                    odt.Rows[5][i+1] = fecha.ToString("dd/MM/yyyy");
                }
            }

            return odt;
        }

        private PdfPTable pdf_cronograma_parte_1(int alineacion, int ancho)
        {
            PdfPTable pdfTableE = new PdfPTable(mitad_cantidad_cronograma);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);
            string celda = "";
            string valor = "";

            if (dgvCronograma.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas_parte_1(dgvCronograma);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;
 
                /* -------------------------------INICIO DGVCRONOGRAMA */
                for (int i = 0; i < dgvCronograma.RowCount; i++)
                {
                    for (int j = 0; j < dgvCronograma.ColumnCount; j++)
                    {
                        //valor = ;
                        if (dgvCronograma[j, i].Value == null)
                            celda = "";
                        else
                            celda = dgvCronograma[j, i].Value.ToString();


                        if (j < mitad_cantidad_cronograma) {
                            cell = new PdfPCell((new Phrase( celda , new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                            cell.BorderColorLeft = CMYKColor.BLACK;
                            cell.BorderColorRight = CMYKColor.BLACK;
                            cell.BorderColorTop = CMYKColor.BLACK;
                            cell.BorderColorBottom = CMYKColor.BLACK;
                            cell.BorderWidthLeft = 1f;
                            cell.BorderWidthRight = 1f;
                            cell.BorderWidthTop = 0f;
                            cell.BorderWidthBottom = 0f;

                            if ( i==0 )
                                cell.BorderWidthTop = 1f;

                            if (i == 7)
                                cell.BorderWidthBottom = 1f;

                            pdfTableE.AddCell(cell);
                        }
                    }
                    pdfTableE.CompleteRow();
                }
                /* -------------------------------FIN DGVCRONOGRAMA */

            }

            return pdfTableE;
        }

        private PdfPTable pdf_cronograma_parte_2(int alineacion, int ancho)
        {
            PdfPTable pdfTableE = new PdfPTable(dgvCronograma.ColumnCount- mitad_cantidad_cronograma);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);
            string celda = "";
            string valor = "";

            if (dgvCronograma.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas_parte_2(dgvCronograma);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;

                /* -------------------------------INICIO DGVCRONOGRAMA */
                for (int i = 0; i < dgvCronograma.RowCount; i++)
                {
                    for (int j = 0; j < dgvCronograma.ColumnCount; j++)
                    {
                        //valor = ;
                        if (dgvCronograma[j, i].Value == null)
                            celda = "";
                        else
                            celda = dgvCronograma[j, i].Value.ToString();


                        if (j >= mitad_cantidad_cronograma) { 
                            cell = new PdfPCell((new Phrase(celda, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                            cell.BorderColorLeft = CMYKColor.BLACK;
                            cell.BorderColorRight = CMYKColor.BLACK;
                            cell.BorderColorTop = CMYKColor.BLACK;
                            cell.BorderColorBottom = CMYKColor.BLACK;
                            cell.BorderWidthLeft = 1f;
                            cell.BorderWidthRight = 1f;
                            cell.BorderWidthTop = 0f;
                            cell.BorderWidthBottom = 0f;

                            if (i == 0)
                                cell.BorderWidthTop = 1f;

                            if (i == 7)
                                cell.BorderWidthBottom = 1f;

                            pdfTableE.AddCell(cell);
                        }
                    }
                    pdfTableE.CompleteRow();
                }
                /* -------------------------------FIN DGVCRONOGRAMA */

            }

            return pdfTableE;
        }


        const int WM_ERASEBKGND = 0x14;

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == WM_ERASEBKGND)
            {
                Graphics g = Graphics.FromHdc(m.WParam);
                g.FillRectangle(new SolidBrush(System.Drawing.Color.LightSkyBlue), ClientRectangle);
                g.Dispose();
                return;
            }

            base.WndProc(ref m);
        }

        private void dtpFecha_Enter(object sender, EventArgs e)
        {
            //dtpFecha.SetStyle(UserPaint, true). = System.Drawing.Color.LightSkyBlue;
            gbFecha.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void txtEdad_Enter(object sender, EventArgs e)
        {
            txtEdad.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            txtEdad.BackColor = System.Drawing.Color.White;
        }

        private void dtpFecha_Leave(object sender, EventArgs e)
        {
            gbFecha.BackColor = System.Drawing.Color.White;
        }

        private void nudGestas_Enter(object sender, EventArgs e)
        {
            nudGestas.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void nudGestas_Leave(object sender, EventArgs e)
        {
            nudGestas.BackColor = System.Drawing.Color.White;

        }

        private void nudPartos_Enter(object sender, EventArgs e)
        {
            nudPartos.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void nudPartos_Leave(object sender, EventArgs e)
        {
            nudPartos.BackColor = System.Drawing.Color.White;
        }

        private void nudAbortos_Enter(object sender, EventArgs e)
        {
            nudAbortos.BackColor = System.Drawing.Color.LightSkyBlue;

        }

        private void nudAbortos_Leave(object sender, EventArgs e)
        {
            nudAbortos.BackColor = System.Drawing.Color.White;
        }

        private void nudHv_Enter(object sender, EventArgs e)
        {
            nudHv.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void nudHv_Leave(object sender, EventArgs e)
        {
            nudHv.BackColor = System.Drawing.Color.White;
        }

        private void nudHm_Enter(object sender, EventArgs e)
        {
            nudHm.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void nudHm_Leave(object sender, EventArgs e)
        {
            nudHm.BackColor = System.Drawing.Color.White;
        }

        private void gbFechas_Enter(object sender, EventArgs e)
        {
            gbFechas.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void dtpFUR_Leave(object sender, EventArgs e)
        {
            gbFechas.BackColor = System.Drawing.Color.White;
        }

        private void cboTipoLlegada_Enter(object sender, EventArgs e)
        {
            cboTipoLlegada.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void cboTipoLlegada_Leave(object sender, EventArgs e)
        {
            cboTipoLlegada.BackColor = System.Drawing.Color.White;
        }

        private void cboTipoLlegada_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                dtpTiempoLlegada.Focus();
        }

        private void cboTipoLlegada_Enter_1(object sender, EventArgs e)
        {
            gbEESS.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void cboTipoLlegada_Leave_1(object sender, EventArgs e)
        {
            gbEESS.BackColor = System.Drawing.Color.White;
        }

        private void dtpTiempoLlegada_Enter(object sender, EventArgs e)
        {
            gbEESS.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void dtpTiempoLlegada_Leave(object sender, EventArgs e)
        {
            gbEESS.BackColor = System.Drawing.Color.White;
        }

        private void nudSemanas_Enter(object sender, EventArgs e)
        {
            nudSemanas.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void nudSemanas_Leave(object sender, EventArgs e)
        {
            nudSemanas.BackColor = System.Drawing.Color.White;
        }

        private void dtpOdontologo_Enter(object sender, EventArgs e)
        {
            gbOdontologico.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void dtpOdontologo_Leave(object sender, EventArgs e)
        {
            gbOdontologico.BackColor = System.Drawing.Color.White;
        }

        private void buAgregarOdontologia_Enter(object sender, EventArgs e)
        {
            gbOdontologico.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void buAgregarOdontologia_Leave(object sender, EventArgs e)
        {
            gbOdontologico.BackColor = System.Drawing.Color.White;
        }

        private void dtpEcografia_Enter(object sender, EventArgs e)
        {
            gbEcografia.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void dtpEcografia_Leave(object sender, EventArgs e)
        {
            gbEcografia.BackColor = System.Drawing.Color.White;
        }

        private void nudEdadGestacional_Enter(object sender, EventArgs e)
        {
            nudEdadGestacional.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void nudEdadGestacional_Leave(object sender, EventArgs e)
        {
            nudEdadGestacional.BackColor = System.Drawing.Color.White;
        }

        private void nudDiasEcografia_Enter(object sender, EventArgs e)
        {
            nudDiasEcografia.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void nudDiasEcografia_Leave(object sender, EventArgs e)
        {
            nudDiasEcografia.BackColor = System.Drawing.Color.White;
        }

        private void buAgregarEcografia_Enter(object sender, EventArgs e)
        {
            gbEcografia.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void buAgregarEcografia_Leave(object sender, EventArgs e)
        {
            gbEcografia.BackColor = System.Drawing.Color.White;
        }

        private void txtObservaciones_Enter(object sender, EventArgs e)
        {
            txtObservaciones.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void txtObservaciones_Leave(object sender, EventArgs e)
        {
            txtObservaciones.BackColor = System.Drawing.Color.White;
        }

        private void cbTranseunte_Enter(object sender, EventArgs e)
        {
            cbTranseunte.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void cbTranseunte_Leave(object sender, EventArgs e)
        {
            cbTranseunte.BackColor = System.Drawing.Color.White;
        }

        private void txtOrigenEESS_Enter(object sender, EventArgs e)
        {
            txtOrigenEESS.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void txtOrigenEESS_Leave(object sender, EventArgs e)
        {
            txtOrigenEESS.BackColor = System.Drawing.Color.White;
        }

        private void cbArchivado_Enter(object sender, EventArgs e)
        {
            cbArchivado.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void cbArchivado_Leave(object sender, EventArgs e)
        {
            cbArchivado.BackColor = System.Drawing.Color.White;
        }

        private void gbBuscar_Enter(object sender, EventArgs e)
        {
            gbBuscar.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void gbBuscar_Leave(object sender, EventArgs e)
        {
            gbBuscar.BackColor = System.Drawing.Color.White;
        }

        private void gbFiltrar_Enter(object sender, EventArgs e)
        {
            gbFiltrar.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void gbFiltrar_Leave(object sender, EventArgs e)
        {
            gbFiltrar.BackColor = System.Drawing.Color.White;
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                dtpFecha.Focus();
        }

        private void buCronograma_Click(object sender, EventArgs e)
        {
            CapaDeNegocios.cHistoriaClinica oHistoriClinica = new CapaDeNegocios.cHistoriaClinica();
            CapaDeNegocios.CitaPreNatal.cCitaPrenatal oCitaPrenatal = new CapaDeNegocios.CitaPreNatal.cCitaPrenatal();
            CapaDeNegocios.TerminoGestacion.cTerminoGestacion oTerminoGestacion = new CapaDeNegocios.TerminoGestacion.cTerminoGestacion();
            CapaDeNegocios.ControlPeuperio.cControlPeuperio oControlPuerperio = new CapaDeNegocios.ControlPeuperio.cControlPeuperio();
            CapaDeNegocios.cUtilitarios oUtilitarios = new CapaDeNegocios.cUtilitarios();

            DataTable odt = new DataTable();
            DataTable odtCronograma = new DataTable();

            DateTime cita;
            DateTime proxCita;

            string etiqueta_cita = "";
            string etiqueta_prox_cita = "";

            string etiqueta_termino_gestacion = "";
            DateTime termino_gestacion;

            DateTime FUR;
            DateTime FPP;

            DataRow drFiladt = odt.NewRow();
            DataRow drFilaCronograma = odtCronograma.NewRow();

            int indice_termino_gestacion = 0;
            DateTime fecha;
            DateTime prox_fecha;

            bool bandera_abrir_fecha_tg = false;
            bool bandera_repite_fecha_tg = false;

            DateTime control_puerperio_7;
            DateTime control_puerperio_30;
            DateTime control_puerperio;
            DateTime Hoy;

            int cantidad_columnas_cronograma = 0;
            int numero_control_puerperio = 0;
            if (IdtHistoriaClinica == "")
            {
                MessageBox.Show("Porfavor seleccione una Historia Clinica.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {

                /*Inicio FUR y FPP*/
                oHistoriClinica.Idthistoriaclinica = IdtHistoriaClinica;
                odt = oHistoriClinica.ListarHistoriaClinicaLargo();
                FUR = Convert.ToDateTime(odt.Rows[0]["FUR"]);
                FPP = Convert.ToDateTime(odt.Rows[0]["FPP"]);

                odtCronograma.Columns.Add("", typeof(string));
                odtCronograma.Columns.Add("", typeof(string));

                drFilaCronograma = odtCronograma.NewRow();
                odtCronograma.Rows.InsertAt(drFilaCronograma, 0);

                drFilaCronograma = odtCronograma.NewRow();
                odtCronograma.Rows.InsertAt(drFilaCronograma, 1);

                drFilaCronograma = odtCronograma.NewRow();
                odtCronograma.Rows.InsertAt(drFilaCronograma, 2);

                drFilaCronograma = odtCronograma.NewRow();
                odtCronograma.Rows.InsertAt(drFilaCronograma, 3);

                drFilaCronograma = odtCronograma.NewRow();
                drFilaCronograma[0] = "FUR";
                drFilaCronograma[1] = "FPP";
                odtCronograma.Rows.InsertAt(drFilaCronograma, 4);

                drFilaCronograma = odtCronograma.NewRow();
                drFilaCronograma[0] = FUR.ToString("dd/MM/yyyy");
                drFilaCronograma[1] = FPP.ToString("dd/MM/yyyy");
                odtCronograma.Rows.InsertAt(drFilaCronograma, 5);

                drFilaCronograma = odtCronograma.NewRow();
                odtCronograma.Rows.InsertAt(drFilaCronograma, 6);

                oCitaPrenatal.HistoriaClinica.Idthistoriaclinica = IdtHistoriaClinica;
                odt = oCitaPrenatal.ListaCitasPreNatal();
                /*fin FUR y FPP*/

                /*inicio citas prenatales*/
                for (int i = odt.Rows.Count - 1; i > -1; i--) {
                    odtCronograma.Columns.Add("", typeof(string)).SetOrdinal(1);
                    odtCronograma.Columns.Add("", typeof(string)).SetOrdinal(1);
                    cita = Convert.ToDateTime (odt.Rows[i]["FECHA CITA"] );
                    proxCita = Convert.ToDateTime(odt.Rows[i]["FECHA PROXIMA CITA"]);

                    etiqueta_cita = oUtilitarios.GenerarNumero( Convert.ToInt16(odt.Rows[i]["NUMERO DE CITA"]) ) + " CITA ASISTIDA";
                    etiqueta_prox_cita = oUtilitarios.GenerarNumero(Convert.ToInt16(odt.Rows[i]["NUMERO DE CITA"])+1) + " CITA PROGRAMADA";

                    odtCronograma.Rows[4][1] = etiqueta_cita;
                    odtCronograma.Rows[5][1] = cita.ToString("dd/MM/yyyy") ;
                    odtCronograma.Rows[4][2] = etiqueta_prox_cita;
                    odtCronograma.Rows[5][2] = proxCita.ToString("dd/MM/yyyy");
                }
                dgvCronograma.DataSource = odtCronograma;
                
                odtCronograma = burbuja(odtCronograma);

                /*fin citas prenatales*/

                /*Inicio termino gestacion*/

                odt = oTerminoGestacion.ListarTerminoGestacion(IdtHistoriaClinica);
                /*Ubicar fecha de termino de gestacion en cronograma*/

                if (odt.Rows.Count > 0)
                {
                    etiqueta_termino_gestacion = odt.Rows[0]["GESTACION"].ToString();
                    if (etiqueta_termino_gestacion == "Normal")
                        etiqueta_termino_gestacion = "Parto normal";

                    etiqueta_termino_gestacion = etiqueta_termino_gestacion.ToUpper();
                    termino_gestacion = Convert.ToDateTime(odt.Rows[0]["FECHA"]);

                    for (int i = 0; i < odtCronograma.Columns.Count - 1; i++)
                    {
                        fecha = Convert.ToDateTime(odtCronograma.Rows[5][i]);
                        prox_fecha = Convert.ToDateTime(odtCronograma.Rows[5][i + 1]);
                        if (i == odtCronograma.Columns.Count - 2)
                        {
                            if (termino_gestacion > prox_fecha)
                            {
                                bandera_abrir_fecha_tg = true;
                                indice_termino_gestacion = i + 2;
                            }
                            if (termino_gestacion == prox_fecha)
                            {
                                bandera_repite_fecha_tg = true;
                                indice_termino_gestacion = i + 1;
                            }
                        }
                        if (termino_gestacion > fecha && termino_gestacion < prox_fecha)
                        {
                            bandera_abrir_fecha_tg = true;
                            indice_termino_gestacion = i + 1;
                        }
                        if (termino_gestacion == fecha && termino_gestacion < prox_fecha)
                        {
                            bandera_repite_fecha_tg = true;
                            indice_termino_gestacion = i;
                        }
                    }

                    /*escribir en el cronograma el termino de gestacion*/
                    if (bandera_abrir_fecha_tg)
                    {
                        odtCronograma.Columns.Add("", typeof(string)).SetOrdinal(indice_termino_gestacion);
                        odtCronograma.Rows[0][indice_termino_gestacion] = etiqueta_termino_gestacion.ToString();
                        odtCronograma.Rows[5][indice_termino_gestacion] = termino_gestacion.ToString("dd/MM/yyyy");
                    }
                    if (bandera_repite_fecha_tg)
                    {
                        odtCronograma.Rows[0][indice_termino_gestacion] = etiqueta_termino_gestacion.ToString();
                    }
                }
                else {
                    termino_gestacion = FPP;
                }

                /*Fin termino gestacion*/

                /*Inicio control puerperio programado 7 dias despues y 30 dias despues*/

                control_puerperio_7 = termino_gestacion.AddDays(7);
                control_puerperio_30 = control_puerperio_7.AddDays(30);

                cantidad_columnas_cronograma = odtCronograma.Columns.Count;
                odtCronograma.Columns.Add("", typeof(string)).SetOrdinal(cantidad_columnas_cronograma);
                odtCronograma.Columns.Add("", typeof(string)).SetOrdinal(cantidad_columnas_cronograma);

                odtCronograma.Rows[4][cantidad_columnas_cronograma] = oUtilitarios.GenerarNumeroMasculino(1) + " CONTROL PUERPERIO PROGRAMADO";
                odtCronograma.Rows[5][cantidad_columnas_cronograma] = control_puerperio_7.ToString("dd/MM/yyyy");

                odtCronograma.Rows[4][cantidad_columnas_cronograma+1] = oUtilitarios.GenerarNumeroMasculino(2) + " CONTROL PUERPERIO PROGRAMADO";
                odtCronograma.Rows[5][cantidad_columnas_cronograma+1] = control_puerperio_30.ToString("dd/MM/yyyy");
                /*Fin control puerperio*/

                /*Inicio control puerperio */
                odt = oControlPuerperio.ListarControlPeuperio(IdtHistoriaClinica);
                for (int i = 0; i < odt.Rows.Count ; i++)
                {
                    control_puerperio = Convert.ToDateTime( odt.Rows[i]["FECHA"]);
                    numero_control_puerperio = Convert.ToInt16(odt.Rows[i]["NUMERO"]);

                    cantidad_columnas_cronograma = odtCronograma.Columns.Count;
                    odtCronograma.Columns.Add("", typeof(string)).SetOrdinal(cantidad_columnas_cronograma);
                    odtCronograma.Rows[4][cantidad_columnas_cronograma ] = oUtilitarios.GenerarNumeroMasculino( numero_control_puerperio ) + " CONTROL PUERPERIO ASISTIDO";
                    odtCronograma.Rows[5][cantidad_columnas_cronograma ] = control_puerperio.ToString("dd/MM/yyyy");
                }

                /*Agregando la fecha de hoy*/
                Hoy = DateTime.Today;
                cantidad_columnas_cronograma = odtCronograma.Columns.Count;
                odtCronograma.Columns.Add("", typeof(string)).SetOrdinal(cantidad_columnas_cronograma);
                odtCronograma.Rows[6][cantidad_columnas_cronograma] = "HOY";
                odtCronograma.Rows[5][cantidad_columnas_cronograma] = Hoy.ToString("dd/MM/yyyy");

                odtCronograma = burbuja(odtCronograma);
                
                odtCronograma = interceptar_campos(0, odtCronograma.Columns.Count - 1, odtCronograma);
                odtCronograma = interceptar_campos(0, odtCronograma.Columns.Count - 1, odtCronograma);
                odtCronograma = interceptar_campos(0, odtCronograma.Columns.Count - 1, odtCronograma);
                odtCronograma = interceptar_campos(0, odtCronograma.Columns.Count - 1, odtCronograma);

 

                dgvCronograma.DataSource = odtCronograma;
                mitad_cantidad_cronograma = odtCronograma.Columns.Count / 2;
                /*Creacion de pdf*/



                Paragraph paragraph = new Paragraph();
 

                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                //using (FileStream stream = new FileStream(folderPath + "Graphics.pdf", FileMode.Create))
                //{


                // Add a new page to the pdf file
                //pdfDoc.NewPage();
                Document pdfDoc = new Document(PageSize.A4, 9, 9, 10, 10);

                pdfDoc.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());
                //pdfDoc.SetPageSize(iTextSharp.text.PageSize.A4);

                paragraph.Alignment = Element.ALIGN_CENTER;
                paragraph.Font = FontFactory.GetFont(FontFactory.TIMES_BOLD, 14);
                paragraph.Add("CRONOGRAMA DE GESTANTE \n\n\n");

                /*              Llenar datagrids            */
                FileStream fs = new FileStream(folderPath + "Cronograma.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, fs);
                CreateHeaderFooter(ref pdfDoc);
                //Abrir pagina
                pdfDoc.Open();

                //Total de filas en dgvBoletaPago_A, si es mayor a 0 procede a reporte
                //instanciando pdfTable A , B , C , D , E
                PdfPTable pdfTable_Cronograma_parte_1 = new PdfPTable(dgvCronograma.ColumnCount);
                PdfPTable pdfTable_Cronograma_parte_2 = new PdfPTable(dgvCronograma.ColumnCount);

                //Nueva pagina
                pdfDoc.NewPage();

                //obtener pdfTableA,B,C,D,E 
                pdfTable_Cronograma_parte_1 = pdf_cronograma_parte_1(0, 100);
                pdfTable_Cronograma_parte_2 = pdf_cronograma_parte_2(0, 100);

                //Columnas 
                MultiColumnText columns = new MultiColumnText();
                columns.AddRegularColumns(36f, pdfDoc.PageSize.Width - 36f, 24f, 1);

                //Imagen
                string ruta = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));

                //C:\\Users\\ADVANCE\\Source\\Repos\\slnRecursosHumanos\\slnRecursosHumanos\\CapaUsuario\\bin\\Debug
                //C:\\Users\\ADVANCE\\Source\\Repos\\slnRecursosHumanos\\slnRecursosHumanos\\CapaUsuario

                string ruta_imagen = ruta + "\\logo.jpg";

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(ruta_imagen);
                logo.ScalePercent(24f);
                logo.SetAbsolutePosition(35f, pdfDoc.PageSize.Height - 70f);

                //tabla que ecografia y odontologia
                PdfPTable tabla_cronograma_parte_1 = new PdfPTable(1);
                tabla_cronograma_parte_1.DefaultCell.BorderWidth = 0;

                //tabla que ecografia y odontologia
                PdfPTable tabla_cronograma_parte_2 = new PdfPTable(1);
                tabla_cronograma_parte_2.DefaultCell.BorderWidth = 0;

                //var colWidthPercentages = new[] { 45f, 25f, 30f };
                //tabla_cronograma.SetWidths(colWidthPercentages);

                tabla_cronograma_parte_1.WidthPercentage = 100;
                tabla_cronograma_parte_1.AddCell(pdfTable_Cronograma_parte_1);

                tabla_cronograma_parte_2.WidthPercentage = 100;
                tabla_cronograma_parte_2.AddCell(pdfTable_Cronograma_parte_2);

                //Agregando pdfTable A, B, C, D, E a pdfDoc
                columns.AddElement(paragraph);
                columns.AddElement(tabla_cronograma_parte_1);
                columns.AddElement(tabla_cronograma_parte_2);

                pdfDoc.Add(logo);
                pdfDoc.Add(columns);
 
                pdfDoc.Close();
                writer.Close();
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.EnableRaisingEvents = false;
                proc.StartInfo.FileName = "C:\\PDFs\\Cronograma.pdf";
                proc.Start();

            }

        }

        public void CreateHeaderFooter(ref Document _document)
        {
            var headerfooter = FontFactory.GetFont("Arial", 8);
            HeaderFooter header = (new HeaderFooter(new Phrase("Cronograma" , headerfooter), false));
            header.BorderColorTop = new iTextSharp.text.Color(System.Drawing.Color.Red);
            header.BorderWidthTop = 0f;
            _document.Header = header;
            HeaderFooter Footer = new HeaderFooter(new Phrase(" ", headerfooter), true);
            //Footer.BorderWidthBottom = 0f;
            Footer.BorderWidthBottom = 0f;
            Footer.BorderWidthTop = 0f;
            Footer.BorderWidthLeft = 0f;
            Footer.BorderWidthRight = 0f;
            _document.Footer = Footer;
        }

        public float[] GetTamañoColumnas_parte_1(DataGridView dg)
        {
            float[] values = new float[mitad_cantidad_cronograma];
            for (int i = 0; i < mitad_cantidad_cronograma; i++)
            {
                //if (i<10)
                    values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }

        public float[] GetTamañoColumnas_parte_2(DataGridView dg)
        {

            float[] values = new float[dg.ColumnCount- mitad_cantidad_cronograma];
            for (int i = 0; i < dg.ColumnCount- mitad_cantidad_cronograma; i++)
            {
                //if (i>=10)
                    values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }

        private DataTable burbuja (DataTable odt)
        {

            string t0,t1,t2,t3,t4,t5,t6;
            DateTime fecha_a, fecha_b;

            for (int a = 1; a < odt.Columns.Count; a++)
                for (int b = odt.Columns.Count - 1; b >= a; b--)
                {
                    fecha_a = Convert.ToDateTime(odt.Rows[5][b - 1]);
                    fecha_b = Convert.ToDateTime(odt.Rows[5][b]);
                    if ( fecha_a > fecha_b)
                    {
                        t0 = odt.Rows[0][b - 1].ToString();
                        t1 = odt.Rows[1][b - 1].ToString();
                        t2 = odt.Rows[2][b - 1].ToString();
                        t3 = odt.Rows[3][b - 1].ToString();
                        t4 = odt.Rows[4][b - 1].ToString();
                        t5 = odt.Rows[5][b - 1].ToString();
                        t6 = odt.Rows[6][b - 1].ToString();

                        odt.Rows[0][b - 1] = odt.Rows[0][b];
                        odt.Rows[1][b - 1] = odt.Rows[1][b];
                        odt.Rows[2][b - 1] = odt.Rows[2][b];
                        odt.Rows[3][b - 1] = odt.Rows[3][b];
                        odt.Rows[4][b - 1] = odt.Rows[4][b];
                        odt.Rows[5][b - 1] = odt.Rows[5][b];
                        odt.Rows[6][b - 1] = odt.Rows[6][b];

                        odt.Rows[0][b] = t0;
                        odt.Rows[1][b] = t1;
                        odt.Rows[2][b] = t2;
                        odt.Rows[3][b] = t3;
                        odt.Rows[4][b] = t4;
                        odt.Rows[5][b] = t5;
                        odt.Rows[6][b] = t6;
                    }
                }

            return odt;
        }

    }



}





