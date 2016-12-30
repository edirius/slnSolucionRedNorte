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
using System.Reflection;

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
        bool bsemana_16 = false;
        bool bsemana_36 = false;
        bool bcero = false;

        public string IdObstetra = "";
        public string nombreObstetra = "";
        public string IdEstablecimiento = "";
        public string IdtHistoriaClinica = "";
        public bool Archivado = false;
        public bool explorando_hc = false;
        public int edad_gestacional = 0;
        public double dias_gestacional = 0;
        public string ID_HC = "";

        public DateTime FUR;
        public DateTime FPP;
        public DateTime fecha_reg;
        public string Codigo_Historia_Clinica { get; set; }
        public string Fecha { get; set; }
        public string DNI { get; set; }
        public string Nombre_Completo { get; set; }
        public string Edad { get; set; }
        public System.Drawing.Color _backDisabledColor { get; private set; }
        CapaDeNegocios.cUtilitarios oUtilitarios = new CapaDeNegocios.cUtilitarios();

        string nombre = "";
        string app = "";
        string apm = "";

        bool bnivel0 = false, bnivel1 = false, bnivel2 = false, bnivel3 = false, bnivel4 = false, bnivel5 = false;

        CapaUsuario.fBuscarCicloGestante fBuscarCicloGestante = new CapaUsuario.fBuscarCicloGestante();

        int i = 0;
        string obstetra = "";

        int año = 0;
        int mes = 0;

        int mes_numero = 0;
        int año_numero = 0;
        //Image backgroundimage;
        int mitad_cantidad_cronograma_parte_1 = 0;
        int mitad_cantidad_cronograma_parte_2 = 0;


        bool bandera_combobox_año = false;

        public void ancho_odo_eco_dgv() {
            dgvOdontologia.Columns[0].Width = 80;
            dgvOdontologia.Columns[1].Width = 40;
            dgvOdontologia.Columns[2].Width = 110;
            //dgvOdontologia.Columns["NRO"].Width = 25;

            dgvEcografia.Columns[0].Width = 80;
            dgvEcografia.Columns[1].Width = 40;
            dgvEcografia.Columns[2].Width = 90;
            dgvEcografia.Columns[3].Width = 90;
            //dgvOdontologia.Columns["NRO"].Width = 70;
        }

        public frmHistoriaClinica(string idObstetra , string idEstablecimiento, string NombreObstetra)
        {
            InitializeComponent();
            IdObstetra = idObstetra;
            IdEstablecimiento = idEstablecimiento;
            nombreObstetra = NombreObstetra;

            //txtTalla.KeyUp -= new KeyEventHandler(txtTalla_KeyUp);

            //txtTalla.KeyDown -= new System.Windows.Forms.KeyEventHandler(txtTalla_KeyDown);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void cargar_paciente(string dni_, string nombres_, string app_, string apm_, DateTime fn_) {


        }
 
        
 

        private void frmHistoriaClinica_Load(object sender, EventArgs e)
        {
            DataTable odtHistoriaClinica = new DataTable();
            CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();
            CapaDeNegocios.EstablecimientoSalud.cEstablecimientoSalud oEstablecimientoSalud = new CapaDeNegocios.EstablecimientoSalud.cEstablecimientoSalud();
            CapaDeNegocios.cUtilitarios oUtilitarios = new CapaDeNegocios.cUtilitarios();

            /*ocultando picture box de color*/
            pbMM.Visible = false;
            pbAPN.Visible = false;
            pbRB.Visible = false;
            pbVD.Visible = false;
            pbTG.Visible = false;
            pbCP.Visible = false;
            pbARN.Visible = false;
            pbCR.Visible = false;

            //Codigo_Historia_Clinica = "";


            bandera_combobox_año = true;

         
            /*datagridview odontologo*/

            odtOdontologo.Columns.Add("NRO", typeof(string));
            odtOdontologo.Columns.Add("VISITA", typeof(string));
            odtOdontologo.Columns.Add("ID_ODO", typeof(string));

            DataGridViewButtonColumn dgvbOdontologo = new DataGridViewButtonColumn();
            dgvbOdontologo.Name = "ACCION";
            dgvbOdontologo.Text = "Eliminar";
            dgvbOdontologo.HeaderText = "ACCION";
            dgvbOdontologo.UseColumnTextForButtonValue = true;
            
            int columnIndex = 0;

            dgvOdontologia.DataSource = odtOdontologo;
            
            
            dgvOdontologia.Columns.Insert(columnIndex, dgvbOdontologo);

            
            

            /*datagridview ecografia*/

            DataGridViewButtonColumn dgvbEcografia = new DataGridViewButtonColumn();
            dgvbEcografia.Name = "ACCION";
            dgvbEcografia.Text = "Eliminar";
            dgvbEcografia.HeaderText = "ACCION";
            dgvbEcografia.UseColumnTextForButtonValue = true;

            odtEcografia.Columns.Add("NRO", typeof(string));
            odtEcografia.Columns.Add("FECHA", typeof(string));
            odtEcografia.Columns.Add("SEMANA(S)", typeof(string));
            odtEcografia.Columns.Add("DIA(S)", typeof(string));
            odtEcografia.Columns.Add("ID_ECO", typeof(string));

            columnIndex = 0;

            dgvEcografia.DataSource = odtEcografia;

            
            dgvEcografia.Columns.Insert(columnIndex, dgvbEcografia);
            ancho_odo_eco_dgv();
            /*datetimepicker 24 hrs format*/

            dtpTiempoLlegada.ShowUpDown = true;
            //dtpTiempoLlegada.MinDate
            dtpTiempoLlegada.CustomFormat = "HH:mm";
            dtpTiempoLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

            dgvEcografia.Columns[5].Visible = false;
            dgvOdontologia.Columns[3].Visible = false;

            //dgvHC.Columns[0].Visible = false;

            //cbBuscar.SelectedItem = cbBuscar.Items[0];

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
            CapaDeNegocios.cOdontologia oOdo = new CapaDeNegocios.cOdontologia();
            string idtodontologia = "";
            string r = "";
            DataTable dtOdontologia = new DataTable();

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

                        //¿existe odontologia?
                        idtodontologia = odtOdontologo.Rows[e.RowIndex][2].ToString();
                        oOdo.Idtodontologia = idtodontologia;
                        dtOdontologia = oOdo.ExisteOdontologia();
                        r = dtOdontologia.Rows[0][0].ToString();

                        if (r == "1") {
                            oOdo.Idtodontologia = idtodontologia;
                            oOdo.EliminarOdontologia();
                        }

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
            CapaDeNegocios.cEcografia oEco = new CapaDeNegocios.cEcografia();
            string idtecografia = "";
            string r = "";
            

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

                        //¿existe odontologia?
                        idtecografia = odtEcografia.Rows[e.RowIndex][4].ToString();
                        oEco.Idtecografia = idtecografia;
                        
                        r = oEco.ExisteEcografia().Rows[0][0].ToString();

                        if (r == "1")
                        {
                            oEco.Idtecografia = idtecografia;
                            oEco.EliminarEcografia();
                        }


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
            txtApellidoMaterno.Text = "";
            txtApellidoPaterno.Text = "";

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
            txtPeso.Text = "";
            txtTalla.Text = "";
            lblIMC.Text="";
            txtOrigenEESS.Text = "";

            idtpaciente = "";

            if (fGestante.ShowDialog() == DialogResult.OK)
            {
                txtDNI.Text = fGestante.DNI;
                txtNombreCompleto.Text = fGestante.nombres;
                txtApellidoPaterno.Text = fGestante.app;
                txtApellidoMaterno.Text = fGestante.apm;
                txtHistoriaClinica.Text = fGestante.codigohistoriaclinica;
                Codigo_Historia_Clinica= fGestante.codigohistoriaclinica;

                nombre = fGestante.nombres.Trim();
                app = fGestante.app.Trim();
                apm = fGestante.apm.Trim();

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
                Bateria.frmBateria fBateria = new Bateria.frmBateria(IdtHistoriaClinica,IdEstablecimiento);
                fBateria.IdObstetra = IdObstetra;
                fBateria.Archivado = Archivado;
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

            if (IdtHistoriaClinica != "") { 

                oHistoriaClinica.Idthistoriaclinica = IdtHistoriaClinica;
                odtHCXIdHC = oHistoriaClinica.ListarHistoriaClinicaLargo();

                IdtHistoriaClinica = odtHCXIdHC.Rows[0][0].ToString();
                Codigo_Historia_Clinica = odtHCXIdHC.Rows[0][1].ToString();
                Fecha = odtHCXIdHC.Rows[0][21].ToString();

                fecha_reg = Convert.ToDateTime( odtHCXIdHC.Rows[0][21].ToString());
                FUR = Convert.ToDateTime(odtHCXIdHC.Rows[0][10]);
                FPP = Convert.ToDateTime(odtHCXIdHC.Rows[0][11]);
                edad_gestacional = (int) odtHCXIdHC.Rows[0][13] ;

                DNI = odtHCXIdHC.Rows[0][16].ToString();
                Nombre_Completo = odtHCXIdHC.Rows[0][17].ToString() + ", " + odtHCXIdHC.Rows[0][18].ToString() + " " + odtHCXIdHC.Rows[0][19].ToString();
                Edad = odtHCXIdHC.Rows[0][4].ToString();

                nombre = odtHCXIdHC.Rows[0][17].ToString().Trim();
                app = odtHCXIdHC.Rows[0][18].ToString().Trim();
                apm = odtHCXIdHC.Rows[0][19].ToString().Trim();

                txtDNI.Text = odtHCXIdHC.Rows[0][16].ToString();
                txtNombreCompleto.Text = odtHCXIdHC.Rows[0][17].ToString();
                txtApellidoPaterno.Text = odtHCXIdHC.Rows[0][18].ToString();
                txtApellidoMaterno.Text = odtHCXIdHC.Rows[0][19].ToString();

                txtHistoriaClinica.Text = odtHCXIdHC.Rows[0][1].ToString();
                cboTipoLlegada.Text = odtHCXIdHC.Rows[0][2].ToString();
                dtpTiempoLlegada.Text = odtHCXIdHC.Rows[0][3].ToString(); ;
                txtEdad.Text = odtHCXIdHC.Rows[0][4].ToString();

                nudGestas.Text = odtHCXIdHC.Rows[0][5].ToString();
                nudPartos.Text = odtHCXIdHC.Rows[0][6].ToString();
                nudAbortos.Text = odtHCXIdHC.Rows[0][7].ToString();
                nudHv.Text = odtHCXIdHC.Rows[0][8].ToString();
                nudHm.Text = odtHCXIdHC.Rows[0][9].ToString();
                dtpFecha.Value = Convert.ToDateTime(odtHCXIdHC.Rows[0][21].ToString());
                dtpFUR.Value = Convert.ToDateTime(odtHCXIdHC.Rows[0][10]);
                dtpFPP.Value = Convert.ToDateTime(odtHCXIdHC.Rows[0][11]);

                hallar_FPP();
                hallar_semana_primera_atencion();

                int trimestreapn = Convert.ToInt16(odtHCXIdHC.Rows[0][12]);

                if (trimestreapn == 1) rbPrimerTrimestre.Checked = true;
                if (trimestreapn == 2) rbSegundoTrimestre.Checked = true;
                if (trimestreapn == 3) rbTercerTrimestre.Checked = true;

                txtPeso.Text = odtHCXIdHC.Rows[0][25].ToString();
                txtTalla.Text = odtHCXIdHC.Rows[0][26].ToString();

                /*
                if (oUtilitarios.es_numerico(txtPeso.Text) || txtPeso.Text != "")
                    txtPeso.Text = odtHCXIdHC.Rows[0][25].ToString();

                if (oUtilitarios.es_numerico(txtTalla.Text) || txtTalla.Text != "")
                    txtTalla.Text = odtHCXIdHC.Rows[0][26].ToString();
                */

                calcular_imc();

                nudSemanas.Text = odtHCXIdHC.Rows[0][13].ToString();
                txtObservaciones.Text = odtHCXIdHC.Rows[0][14].ToString();


                idtpaciente = odtHCXIdHC.Rows[0][15].ToString();
                //IdObstetra = odtHCXIdHC.Rows[0][20].ToString();


                

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

                hallar_semana_primera_atencion();

                /* Llenando ecografias y odontologia */
                oEcografia.Idthistoriaclinica = IdtHistoriaClinica;
                odtEcografia = oEcografia.ListarEcografiaXIdHC();
                dgvEcografia.DataSource = odtEcografia;

                oOdontologia.Idthistoriaclinica = IdtHistoriaClinica;
                odtOdontologo = oOdontologia.ListarOdontologiaXIdHC();
                dgvOdontologia.DataSource = odtOdontologo;

                //dgvOdontologia.Columns[1].Width = 30;
                //dgvEcografia.Columns[1].Width = 30;
            }
        }


        private void calcular_imc() {
            double peso, talla;
            decimal imc;
            double dimc;
            string resultado = "";
            if (Double.TryParse(txtPeso.Text, out peso) && Double.TryParse(txtTalla.Text, out talla))
            {
                double peso2 = Convert.ToDouble(txtPeso.Text);
                double talla2 = Convert.ToDouble(txtTalla.Text);
                if (peso2 != 0 && talla2 != 0) { 
                    imc = Convert.ToDecimal( peso2 / Math.Pow(talla2, 2));
                    imc = Math.Round( imc, 2);
                
                    dimc = Convert.ToDouble(imc);

                    if (dimc < 18.5)
                    {
                        resultado = "Bajo Peso";
                        lblIMC.BackColor = System.Drawing.Color.White;
                    }
                    if (dimc >= 18.5 && dimc <= 24.99)
                    {
                        resultado = "Rango normal";
                        lblIMC.BackColor = System.Drawing.Color.Yellow;
                    }
                    if (dimc >= 25 && dimc <= 29.99)
                    {
                        resultado = "Sobre peso";
                        lblIMC.BackColor = System.Drawing.Color.Orange;
                    }
                    if (dimc >= 30)
                    {
                        resultado = "Obesidad";
                        lblIMC.BackColor = System.Drawing.Color.Red;
                    }

                    lblIMC.Text = imc.ToString() + "\n" + resultado;
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void dgvHC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        /*
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
        */

        private void label12_Click(object sender, EventArgs e)
        {

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

            if (trimestre >=0 && trimestre <= 12){
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

            if  (IdtHistoriaClinica != "")
            {
                CitaPreNatal.frmCitaPreNatal fCitaPrenatal = new CitaPreNatal.frmCitaPreNatal();
                fCitaPrenatal.HistoriaClinica = IdtHistoriaClinica;
                fCitaPrenatal.Establecimiento = IdEstablecimiento;
                fCitaPrenatal.FUR = FUR;
                fCitaPrenatal.FPP = FPP;
                fCitaPrenatal.Fecha_Registro = fecha_reg;
                fCitaPrenatal.Semana_Gestacional = edad_gestacional;
                fCitaPrenatal.dias_gestacional = dias_gestacional;
                fCitaPrenatal.IdObstetra = IdObstetra;
                fCitaPrenatal.Archivado = Archivado;
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
                miRecienNacido.IdObstetra = IdObstetra;
                miRecienNacido.Archivado = Archivado;
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
            FPP = dtpFPP.Value;
            fecha_reg = dtpFecha.Value;
            edad_gestacional = (int) nudSemanas.Value;
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
            button1.Focus();
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
                CapaDeNegocios.TerminoGestacion.cTerminoGestacion oTG = new CapaDeNegocios.TerminoGestacion.cTerminoGestacion();
                DataTable odt = new DataTable();
                DateTime FP = new DateTime();
                DateTime hoy = new DateTime();
                DateTime FR = new DateTime();

                DataTable odtHistoriaClinica = new DataTable();
                bool completo = false;
                string mensaje = "";

                oHistoriaClinica.Idtestablecimientosalud = IdEstablecimiento;
                oHistoriaClinica.Tipollegada = cboTipoLlegada.Text;
                oHistoriaClinica.Tiempollegada = dtpTiempoLlegada.Text;
                if (txtEdad.Text != "")
                    oHistoriaClinica.Edad = Convert.ToInt16(txtEdad.Text);

                DateTime fecha_atencion = dtpFecha.Value ;
                DateTime fur = dtpFUR.Value;

                TimeSpan dias = fecha_atencion - fur;
                //double NrOfDays = dias.TotalDays;
                //double NrOfDays = (fecha_atencion.Date - fur.Date).TotalDays;

                double NrOfDays = dias.TotalDays;

                //int semanas = (int) Math.Ceiling(Math.Abs(NrOfDays / 7));
                int semanas = (int)Math.Abs(NrOfDays / 7);
                dias_gestacional = NrOfDays;

                if (semanas >= nudSemanas.Minimum && semanas <= nudSemanas.Maximum)
                {
                    completo = false;
                }
                else {
                    completo = true;
                    mensaje = "Porfavor ingrese en FUR una fecha que este dentro de tres trimestres del gestante a partir de la fecha de registro.";
                    dtpFUR.Focus();

                }
                
            

                    if (nudGestas.Text == "")
                {
                    completo = true;
                    mensaje = "Porfavor ingresar un valor correcto en Gestas.";
                    nudGestas.Focus();
                }else
                    oHistoriaClinica.Gestas = Convert.ToInt16(nudGestas.Text);

                if (nudPartos.Text == "")
                {
                    completo = true;
                    mensaje = "Porfavor ingresar un valor correcto en Partos.";
                    nudPartos.Focus();
                }else
                     oHistoriaClinica.Partos = Convert.ToInt16(nudPartos.Text);


                if (nudAbortos.Text == "")
                {
                    completo = true;
                    mensaje = "Porfavor ingresar un valor correcto en Abortos.";
                    nudAbortos.Focus();
                }else
                    oHistoriaClinica.Abortos = Convert.ToInt16(nudAbortos.Text);

                if (nudHv.Text == "")
                {
                    completo = true;
                    mensaje = "Porfavor ingresar un valor correcto en Hijos vivos.";
                    nudHv.Focus();
                }else
                    oHistoriaClinica.Hijosvivos = Convert.ToInt16(nudHv.Text);

                if (nudHm.Text == "")
                {
                    completo = true;
                    mensaje = "Porfavor ingresar un valor correcto en Hijos muertos.";
                    nudHm.Focus();
                }else
                    oHistoriaClinica.Hijosmuertos = Convert.ToInt16(nudHm.Text);

                

                if (fecha_reg.Date >= FPP.Date)
                {
                    completo = true;
                    mensaje = "No se puede guardar una fecha de registro mayor a la FPP.";
                    dtpFecha.Focus();
                }

                odt = oTG.ListarTerminoGestacionXCodigoHC(Codigo_Historia_Clinica, nombre, app, apm);

                if (odt.Rows.Count > 0)
                {
                    FP = (DateTime)odt.Rows[0]["FECHA"];

                    hoy = DateTime.Today;
                    ID_HC = odt.Rows[0]["ID HISTORIA CLINICA"].ToString();

                    if (IdtHistoriaClinica != ID_HC)
                    {
                        if (hoy.Date < FP)
                        {
                            completo = true;
                            mensaje = "Paciente gestando, no se puede grabar un nuevo control del gestante hasta un dia despues del parto.";
                            nudHm.Focus();
                        }
                    }
                }
                else {
                    odt = oTG.ListarHistoriaClinicaXPaciente(nombre, app, apm);

                    ID_HC = odt.Rows[0]["idthistoriaclinica"].ToString();

                    if (IdtHistoriaClinica != ID_HC)
                    {
                        if (odt.Rows.Count > 0)
                        {
                            completo = true;
                            mensaje = "Paciente gestando, no se puede grabar un nuevo control del gestante hasta un dia despues del parto.";
                            nudHm.Focus();
                        }
                    }
                }

                /*
                
                */

                /*
                odt = oTG.ListarFPPXCodigoHC(Codigo_Historia_Clinica,nombre,app,apm);
                if (odt.Rows.Count > 0) { 
                    FP = (DateTime)odt.Rows[0]["FECHA"];
                    hoy = DateTime.Today;
                    FR = (DateTime)odt.Rows[0]["FECHA_REG"];
                    ID_HC = odt.Rows[0]["ID_HC"].ToString();

                    if ( IdtHistoriaClinica  != ID_HC) {
                        if ( hoy.Date < FP.Date )
                        {
                            completo = true;
                            mensaje = "Paciente gestando, no se puede grabar un nuevo control del gestante hasta un dia despues del parto.";
                        }
                    }
                }
                */



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
                double peso, talla;

                    /*
                if (Double.TryParse(txtPeso.Text, out peso))
                {
                    oHistoriaClinica.Peso = Convert.ToDecimal(txtPeso.Text);
                }

                if (Double.TryParse(txtPeso.Text, out talla))
                {
                    oHistoriaClinica.Talla = Convert.ToDecimal(txtTalla.Text);
                }
                */

                /*
                if (Convert.ToDecimal(txtPeso.Text) > 0 || txtPeso.Text != "")
                    oHistoriaClinica.Peso = Convert.ToDecimal(txtPeso.Text);

                    if (Convert.ToDecimal(txtTalla.Text) > 0 || txtTalla.Text != "")
                    oHistoriaClinica.Talla = Convert.ToDecimal(txtTalla.Text);

                if (Convert.ToDecimal(txtPeso.Text)<0) {
                    completo = true;
                    mensaje = "Porfavor ingresar el peso de la gestante.";
                }
                */

                if ( oUtilitarios.es_numerico(txtPeso.Text)  || txtPeso.Text != "")
                    oHistoriaClinica.Peso = Convert.ToDecimal(txtPeso.Text);

                if ( oUtilitarios.es_numerico(txtTalla.Text) || txtTalla.Text != "")
                    oHistoriaClinica.Talla = Convert.ToDecimal(txtTalla.Text);

                    bool bpeso = oUtilitarios.es_numerico(txtPeso.Text);
                    bool btalla = oUtilitarios.es_numerico(txtTalla.Text);






                    if ( !bpeso  || Convert.ToDecimal(txtPeso.Text) < 0 || Convert.ToDecimal(txtPeso.Text) > 400 )
                {
                    completo = true;
                    mensaje = "Porfavor ingresar un peso correcto de la gestante.";
                }

                if ( !btalla || Convert.ToDecimal(txtTalla.Text) < 0 || Convert.ToDecimal(txtTalla.Text) > 3)
                {
                    completo = true;
                    mensaje = "Porfavor ingresar una talla correcta de la gestante.";
                }

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

                if ( dtpFUR.Value.Date > dtpFecha.Value.Date )
                {
                    completo = true;
                    mensaje = "Porfavor llenar una fecha de registro mayor o igual a FUR.";
                    dtpFUR.Focus();
                }
                    
                /*
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
                */

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
                            oHistoriaClinica.Idthistoriaclinica = IdtHistoriaClinica.Trim();
                            odtHistoriaClinica = oHistoriaClinica.ModificarHistoriaClinica();

                        
                        }
                        else
                            odtHistoriaClinica = oHistoriaClinica.CrearHistoriaClinica();

                        foreach (DataRow row in odtHistoriaClinica.Rows)
                        {

                            string respuesta_historia_clinica = row[0].ToString().Trim();

                            string[] words = respuesta_historia_clinica.Split('*');

                            string exito = words[0].ToString();
                            string respuesta = words[1].ToString();
                            string idthistoriaclinica = words[2].ToString().Trim();
                            string searchValue = idthistoriaclinica;

                            IdtHistoriaClinica = idthistoriaclinica;

 
                            int cantidad_filas_ecografia = 0;
                            int cantidad_filas_odontologia = 0;
 
                            string respuesta_ecografia = "";
                            string respuesta_odontologia = "";
                              string r = "";

                            if (exito == "0")
                                MessageBox.Show(respuesta, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else if (exito == "1")
                            {
                                cantidad_filas_ecografia = dgvEcografia.Rows.Count;
                                for (int i = 0; i < cantidad_filas_ecografia; i++)
                                {
                                    //si existe no agregar
                                    oEcografia.Idtecografia = dgvEcografia[5, i].Value.ToString(); ;
                                 

                                    dtEcografia = oEcografia.ExisteEcografia();
                                    r = dtEcografia.Rows[0][0].ToString();
                                

                                    if (r != "1")
                                    {
                                        respuesta_ecografia = dgvEcografia[3, i].Value.ToString();
                                        oEcografia.Fecha_servicio = Convert.ToDateTime(dgvEcografia[2, i].Value.ToString());
                                        oEcografia.Edadgestacional = Convert.ToInt16(dgvEcografia[3, i].Value).ToString();
                                        oEcografia.Diagestacional = Convert.ToInt16(dgvEcografia[4, i].Value).ToString();
                                        oEcografia.Idtestablecimientosalud = IdEstablecimiento;

                                        oEcografia.Idthistoriaclinica = IdtHistoriaClinica;
                                        oEcografia.Idtobstetra = IdObstetra;

                                        dtEcografia = oEcografia.CrearEcografia();
                                   }

                                 }

                                cantidad_filas_odontologia = dgvOdontologia.Rows.Count;
                                for (int i = 0; i < cantidad_filas_odontologia; i++)
                                {
                                    oOdontologia.Fecha_servicio = Convert.ToDateTime(dgvOdontologia[2, i].Value.ToString());
                                    oOdontologia.Idtestablecimientosalud = IdEstablecimiento;
                                    oOdontologia.Idtobstetra = IdObstetra;

                                    //si existe no agregar
                                    oOdontologia.Idtodontologia = dgvOdontologia[3, i].Value.ToString(); ;
                                    oOdontologia.Idthistoriaclinica = IdtHistoriaClinica;

                                    dtOdontologia = oOdontologia.ExisteOdontologia();
                                    r = dtOdontologia.Rows[0][0].ToString();
                                    
                                    if (r != "1")
                                    {
                                        dtOdontologia = oOdontologia.CrearOdontologia();
                                    }
                                 
                                }

                            
                                MessageBox.Show(respuesta, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                año = año_numero;
                                mes = mes_numero;
 
                                oHistoriaClinica.año = dtpFecha.Value.Year;
                                oHistoriaClinica.mes = dtpFecha.Value.Month;
 
                                oHistoriaClinica.Idtobstetra = IdObstetra;
 
                                cargar_hc();
                                ancho_odo_eco_dgv();

                                if (cbArchivado.Checked)
                                    Archivado = true;
                                else
                                    Archivado = false;

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
          
        }

        private void hallar_semana_primera_atencion() {

            

            DateTime fecha_atencion = dtpFecha.Value;
            DateTime fur = dtpFUR.Value;

            if (fecha_atencion.Date >= fur.Date) {
                TimeSpan dias = fecha_atencion - fur;
                //double NrOfDays = dias.TotalDays;
                //double NrOfDays = (fecha_atencion.Date - fur.Date).TotalDays;

                double NrOfDays = dias.TotalDays;

                //int semanas = (int) Math.Ceiling(Math.Abs(NrOfDays / 7));
                 int semanas = (int) Math.Abs(NrOfDays / 7);
                dias_gestacional = NrOfDays;
                if (semanas >= nudSemanas.Minimum && semanas <= nudSemanas.Maximum)
                {
                    nudSemanas.Value = semanas;
                    nudEdadGestacional.Value = semanas;
                }
                else
                    MessageBox.Show("Porfavor ingrese en FUR una fecha que este dentro de tres trimestres del gestante a partir de la fecha de registro.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Porfavor ingrese en FUR una fecha menor o igual a la fecha de registro.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            if (System.Text.RegularExpressions.Regex.IsMatch(nudSemanas.Text, @"\d{0,2}"))
                e.Handled = true;

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
            txtPeso.Focus();
        }

        private void txtObservaciones_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cbTranseunte_KeyPress_1(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtOrigenEESS_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void cbArchivado_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cbBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyChar == (char)13)
                txtBuscar.Focus();
                */
        }

        private void txtBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyChar == (char)13)
                cbYear.Focus();
                */
        }

        private void cbYear_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyChar == (char)13)
                cbMonth.Focus();
                */
        }

        private void cbMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyChar == (char)13)
                dgvHC.Focus();
                */
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            nueva_historia_clinica();

        }

        private void cbYear_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //listar_historia_clinica();
        }

        private void cbMonth_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //listar_historia_clinica();
        }

        private void buMorbilidad_Click(object sender, EventArgs e)
        {
            if (IdtHistoriaClinica != "") {

                frmMorbilidad fMorbilidad = new frmMorbilidad();
                fMorbilidad.Codigo_Historia_Clinica = Codigo_Historia_Clinica;
                fMorbilidad.Id_Historia_Clinica = IdtHistoriaClinica;
                fMorbilidad.Fecha = Fecha;
                fMorbilidad.DNI = DNI;
                fMorbilidad.Nomnbre_Completo = Nombre_Completo;
                fMorbilidad.Edad = Edad;
                fMorbilidad.IdEstablecimiento = IdEstablecimiento;
                fMorbilidad.Archivado = Archivado;
                fMorbilidad.idtobstetra = IdObstetra;
                fMorbilidad.nombreObstetra = nombreObstetra;


                fMorbilidad.ShowDialog();
            }else
                MessageBox.Show("Porfavor seleccione una Historia Clinica.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buVisitaDomiciliaria_Click(object sender, EventArgs e)
        {

            if (IdtHistoriaClinica != "")
            {
                VisitaDomiciliaria.frmMantenimientoVisitaDomiciliaria fMantenimientoVisitaDomiciliaria = new VisitaDomiciliaria.frmMantenimientoVisitaDomiciliaria(IdtHistoriaClinica);
                fMantenimientoVisitaDomiciliaria.Archivado = Archivado;
                fMantenimientoVisitaDomiciliaria.ShowDialog();
            }
            else
                MessageBox.Show("Porfavor seleccione una Historia Clinica.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnTerminoGestacion_Click(object sender, EventArgs e)
        {
            if (IdtHistoriaClinica != "")
            {
                TerminoGestacion.frmMantenimientoTerminoGestacion fMantenimientoTerminoGestacion = new TerminoGestacion.frmMantenimientoTerminoGestacion(IdtHistoriaClinica);
                fMantenimientoTerminoGestacion.Archivado = Archivado;
                fMantenimientoTerminoGestacion.ShowDialog();
            }
            else
                MessageBox.Show("Porfavor seleccione una Historia Clinica.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buControlPuerperio_Click(object sender, EventArgs e)
        {
            if (Codigo_Historia_Clinica != "")
            {
                ControlPeuperio.frmMantenimientoControlPeuperio fMantenimientoControlPuerperio = new ControlPeuperio.frmMantenimientoControlPeuperio(IdtHistoriaClinica);
                fMantenimientoControlPuerperio.Archivado = Archivado;
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
                //IdtHistoriaClinica = dgvHC[0, e.RowIndex].Value.ToString();
                cargar_hc();
            }
        }

        private void dgvHC_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //IdtHistoriaClinica = dgvHC[0, e.RowIndex].Value.ToString();
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
            CapaDeNegocios.cUtilitarios oUtilitarios = new CapaDeNegocios.cUtilitarios();
            string fecha = "";
            string prox_fecha = "";
            string etiqueta_fecha = "";
            string etiqueta_fecha_parto = "";
            string etiqueta_hoy = "";
            int j = 0;
            int l = 0;
            string stipo_a = "", stipo_b = "";
            int indice_a = 0, indice_b = 0;
            

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

                    /* Paciente asistio a su control puerperio y cita prenatal */
                    
                    indice_b = Convert.ToInt16(odt.Rows[7][i + 1].ToString());
                    indice_a = Convert.ToInt16(odt.Rows[7][i].ToString());
                    stipo_a = odt.Rows[8][i].ToString();
                    stipo_b = odt.Rows[8][i + 1].ToString();

                    if (indice_a == indice_b && stipo_a == stipo_b)
                    {
                        if (stipo_a == "C") { 
                            odt.Rows[4][i] = oUtilitarios.GenerarNumero(Convert.ToInt16(odt.Rows[7][i])) + " CITA ASISTIDA";
                            etiqueta_fecha = "";
                        }
                        if (stipo_a == "P")
                        {
                            odt.Rows[4][i] = oUtilitarios.GenerarNumero(Convert.ToInt16(odt.Rows[7][i])) + " CONTROL PUERPERIO ASISTIDO";
                            etiqueta_fecha = "";
                        }

                    }
                    /*intercepcion hoy*/

                    etiqueta_hoy = odt.Rows[6][i + 1].ToString();
                    if (etiqueta_hoy != "")
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

        

        private PdfPTable pdf_Odontologia(int alineacion, int ancho)
        {

            PdfPTable pdfTableE = new PdfPTable(dgvOdonto.ColumnCount);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);
            string celda = "";

            if (dgvOdonto.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas(dgvOdonto);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;


                /* -------------------------------INICIO DGVBOLETA_E */
                int k = 0;

                cell = new PdfPCell((new Phrase("ATENCION ODONTOLOGICA", new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                cell.Colspan = 3;
                cell.Rowspan = 1;
                cell.HorizontalAlignment = 1;
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTableE.AddCell(cell);

                foreach (DataGridViewColumn column in dgvOdonto.Columns)
                {
                    cell = new PdfPCell((new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);

                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfTableE.AddCell(cell);
                }

                for (int i = 0; i < dgvOdonto.RowCount-1; i++)
                {
                    for (int j = 0; j < dgvOdonto.ColumnCount; j++)
                    {
                        if(dgvOdonto[j, i].Value == null)
                            celda = "";
                        else
                            celda = dgvOdonto[j, i].Value.ToString();

                        if (oUtilitarios.es_fecha(celda))
                        {
                            DateTime celda_fecha = Convert.ToDateTime(dgvOdonto[j, i].Value);
                            cell = new PdfPCell((new Phrase(celda_fecha.ToString("dd/MM/yyyy"), new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                        }
                        else
                        {
                            cell = new PdfPCell((new Phrase(celda, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                        }

                        pdfTableE.AddCell(cell);
                    }
                    pdfTableE.CompleteRow();

                }
            }
            return pdfTableE;
        }

        private PdfPTable pdf_Ecografia(int alineacion, int ancho)
        {

            PdfPTable pdfTableE = new PdfPTable(dgvEco.ColumnCount);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);


            if (dgvEco.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas(dgvEco);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;


                /* -------------------------------INICIO DGVBOLETA_E */
                int k = 0;

                cell = new PdfPCell((new Phrase("ATENCION ECOGRAFIA", new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                cell.Colspan = 3;
                cell.Rowspan = 1;
                cell.HorizontalAlignment = 1;
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTableE.AddCell(cell);
                string celda = "";

                foreach (DataGridViewColumn column in dgvEco.Columns)
                {
                    cell = new PdfPCell((new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);

                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfTableE.AddCell(cell);
                }

                for (int i = 0; i < dgvEco.RowCount-1; i++)
                {
                    for (int j = 0; j < dgvEco.ColumnCount; j++)
                    {
                        if (dgvEco[j, i].Value == null)
                            celda = "";
                        else
                            celda = dgvEco[j, i].Value.ToString();

                        if (oUtilitarios.es_fecha(celda))
                        {
                            DateTime celda_fecha = Convert.ToDateTime(dgvEco[j, i].Value);
                            cell = new PdfPCell((new Phrase(celda_fecha.ToString("dd/MM/yyyy"), new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                        }
                        else
                        {
                            cell = new PdfPCell((new Phrase(celda, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                        }

                        pdfTableE.AddCell(cell);
                    }
                    pdfTableE.CompleteRow();

                }
            }
            return pdfTableE;
        }

        private PdfPTable pdf_Bateria(int alineacion, int ancho)
        {

            PdfPTable pdfTableE = new PdfPTable(dgvBat.ColumnCount);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);


            if (dgvBat.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas(dgvBat);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;
                string celda = "";

                /* -------------------------------INICIO DGVBOLETA_E */
                int k = 0;

                cell = new PdfPCell((new Phrase("ATENCION BATERIA", new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                cell.Colspan = 3;
                cell.Rowspan = 1;
                cell.HorizontalAlignment = 1;
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTableE.AddCell(cell);

                foreach (DataGridViewColumn column in dgvBat.Columns)
                {
                    cell = new PdfPCell((new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);

                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfTableE.AddCell(cell);
                }

                for (int i = 0; i < dgvBat.RowCount-1; i++)
                {
                    for (int j = 0; j < dgvBat.ColumnCount; j++)
                    {
                        if (dgvBat[j, i].Value == null)
                            celda = "";
                        else
                            celda = dgvBat[j, i].Value.ToString();

                        if (oUtilitarios.es_fecha(celda))
                        {
                            DateTime celda_fecha = Convert.ToDateTime(dgvBat[j, i].Value);
                            cell = new PdfPCell((new Phrase(celda_fecha.ToString("dd/MM/yyyy"), new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                        }
                        else
                        {
                            cell = new PdfPCell((new Phrase(celda, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                        }
                        pdfTableE.AddCell(cell);

                    }
                    pdfTableE.CompleteRow();

                }
            }
            return pdfTableE;
        }

 

        private PdfPTable pdf_HC(int alineacion, int ancho)
        {

            PdfPTable pdfTableE = new PdfPTable(dgvHC.ColumnCount);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);
            string celda = "";

            if (dgvHC.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas(dgvHC);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;


                /* -------------------------------INICIO DGVBOLETA_E */
                int k = 0;

                cell = new PdfPCell((new Phrase("DATOS GESTANTE", new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                cell.Colspan = 2;
                cell.Rowspan = 1;
                cell.HorizontalAlignment = 1;
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTableE.AddCell(cell);

                for (int i = 0; i < dgvHC.RowCount-1; i++)
                {
                    for (int j = 0; j < dgvHC.ColumnCount; j++)
                    {
                        if (dgvHC[j, i].Value == null)
                            celda = "";
                        else
                            celda = dgvHC[j, i].Value.ToString();

                        if (oUtilitarios.es_fecha(celda))
                        {
                            DateTime celda_fecha = Convert.ToDateTime(dgvHC[j, i].Value);
                            cell = new PdfPCell((new Phrase(celda_fecha.ToString("dd/MM/yyyy"), new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                        }
                        else
                        {
                            cell = new PdfPCell((new Phrase(celda, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                        }

                        pdfTableE.AddCell(cell);
                    }
                    pdfTableE.CompleteRow();

                }
            }
            return pdfTableE;
        }

        private PdfPTable pdf_citas_parte_1(int alineacion, int ancho)
        {
            PdfPTable pdfTableE = new PdfPTable(mitad_cantidad_cronograma_parte_1);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);
            string celda = "";

            if (dgvCitas1.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas_parte_1(dgvCitas1);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;

                int k = 0;

                cell = new PdfPCell((new Phrase("CONTROLES PRENATALES", new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                cell.Colspan = mitad_cantidad_cronograma_parte_1;
                cell.Rowspan = 1;
                cell.HorizontalAlignment = 1;
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTableE.AddCell(cell);

                foreach (DataGridViewColumn column in dgvCitas1.Columns)
                {
                    if (k < mitad_cantidad_cronograma_parte_1)
                    {
                        cell = new PdfPCell((new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                        cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);

                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTableE.AddCell(cell);
                    }
                    k++;
                }

                for (int i = 0; i < dgvCitas1.RowCount-1; i++)
                {
                    for (int j = 0; j < dgvCitas1.ColumnCount; j++)
                    {
                        if (j < mitad_cantidad_cronograma_parte_1)
                        {
                            if (dgvCitas1[j, i].Value == null)
                                celda = "";
                            else
                                celda = dgvCitas1[j, i].Value.ToString();

                            if (oUtilitarios.es_fecha(celda))
                            {
                                DateTime celda_fecha = Convert.ToDateTime(dgvCitas1[j, i].Value);
                                cell = new PdfPCell((new Phrase(celda_fecha.ToString("dd/MM/yyyy"), new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                            }
                            else
                            {
                                cell = new PdfPCell((new Phrase(celda, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                            }
                            pdfTableE.AddCell(cell);
                        }


                    }
                    pdfTableE.CompleteRow();

                }
            }

            return pdfTableE;
        }

        private PdfPTable pdf_citas_parte_2(int alineacion, int ancho)
        {
            //if (mitad_cantidad_cronograma == 1)
            //    mitad_cantidad_cronograma = 0;
            if (bcero)
                mitad_cantidad_cronograma_parte_2 = 1;

            PdfPTable pdfTableE = new PdfPTable(mitad_cantidad_cronograma_parte_2);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);
            string celda = "";

            if (dgvCitas1.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas_parte_2(dgvCitas1);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;
                int k = 0;
                foreach (DataGridViewColumn column in dgvCitas1.Columns)
                {
                    if (k >= mitad_cantidad_cronograma_parte_1)
                    {
                        cell = new PdfPCell((new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                        cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);

                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTableE.AddCell(cell);
                    }
                    k++;
                }


                for (int i = 0; i < dgvCitas1.RowCount-1; i++)
                {
                    for (int j = 0; j < dgvCitas1.ColumnCount; j++)
                    {
                        if (j >= mitad_cantidad_cronograma_parte_1)
                        {
                            if (dgvCitas1[j, i].Value == null)
                                celda = "";
                            else
                                celda = dgvCitas1[j, i].Value.ToString();

                            if (oUtilitarios.es_fecha(celda))
                            {
                                DateTime celda_fecha = Convert.ToDateTime(dgvCitas1[j, i].Value);
                                cell = new PdfPCell((new Phrase(celda_fecha.ToString("dd/MM/yyyy"), new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                            }
                            else
                            {
                                cell = new PdfPCell((new Phrase(celda, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                            }
                            pdfTableE.AddCell(cell);
                        }


                    }
                    pdfTableE.CompleteRow();

                }
            }

            return pdfTableE;
        }

        private PdfPTable pdf_puerperio(int alineacion, int ancho)
        {

            PdfPTable pdfTableE = new PdfPTable(dgvPuerperio.ColumnCount);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);
            string celda = "";

            if (dgvPuerperio.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas(dgvPuerperio);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;


                /* -------------------------------INICIO DGVBOLETA_E */
                int k = 0;

                cell = new PdfPCell((new Phrase("CONTROL DE PUERPERIO", new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                cell.Colspan = 2;
                cell.Rowspan = 1;
                cell.HorizontalAlignment = 1;
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTableE.AddCell(cell);

                for (int i = 0; i < dgvPuerperio.RowCount-1; i++)
                {
                    for (int j = 0; j < dgvPuerperio.ColumnCount; j++)
                    {
                        if (dgvPuerperio[j, i].Value == null)
                            celda = "";
                        else
                            celda = dgvPuerperio[j, i].Value.ToString();

                        if (oUtilitarios.es_fecha(celda))
                        {
                            DateTime celda_fecha = Convert.ToDateTime(dgvPuerperio[j, i].Value);
                            cell = new PdfPCell((new Phrase(celda_fecha.ToString("dd/MM/yyyy"), new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                        }
                        else
                        {
                            cell = new PdfPCell((new Phrase(celda, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                        }

                        pdfTableE.AddCell(cell);


                    }
                    pdfTableE.CompleteRow();

                }
            }
            return pdfTableE;
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
            gbFecha.BackColor = System.Drawing.Color.Transparent;
            hallar_FPP();
            hallar_semana_primera_atencion();
        }

        private void nudGestas_Enter(object sender, EventArgs e)
        {
            nudGestas.BackColor = System.Drawing.Color.LightSkyBlue;
            nudGestas.Select(0, nudGestas.Text.Length);
        }

        private void nudGestas_Leave(object sender, EventArgs e)
        {
            nudGestas.BackColor = System.Drawing.Color.White;

        }

        private void nudPartos_Enter(object sender, EventArgs e)
        {
            nudPartos.BackColor = System.Drawing.Color.LightSkyBlue;
            nudPartos.Select(0, nudPartos.Text.Length);
        }

        private void nudPartos_Leave(object sender, EventArgs e)
        {
            nudPartos.BackColor = System.Drawing.Color.White;
        }

        private void nudAbortos_Enter(object sender, EventArgs e)
        {
            nudAbortos.BackColor = System.Drawing.Color.LightSkyBlue;
            nudAbortos.Select(0, nudAbortos.Text.Length);
        }

        private void nudAbortos_Leave(object sender, EventArgs e)
        {
            nudAbortos.BackColor = System.Drawing.Color.White;
        }

        private void nudHv_Enter(object sender, EventArgs e)
        {
            nudHv.BackColor = System.Drawing.Color.LightSkyBlue;
            nudHv.Select(0, nudHv.Text.Length);
        }

        private void nudHv_Leave(object sender, EventArgs e)
        {
            nudHv.BackColor = System.Drawing.Color.White;
        }

        private void nudHm_Enter(object sender, EventArgs e)
        {
            nudHm.BackColor = System.Drawing.Color.LightSkyBlue;
            nudHm.Select(0, nudHm.Text.Length);
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
            gbFechas.BackColor = System.Drawing.Color.Transparent;
            hallar_FPP();
            hallar_semana_primera_atencion();
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
            gbEESS.BackColor = System.Drawing.Color.Transparent;
        }

        private void dtpTiempoLlegada_Enter(object sender, EventArgs e)
        {
            gbEESS.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void dtpTiempoLlegada_Leave(object sender, EventArgs e)
        {
            gbEESS.BackColor = System.Drawing.Color.Transparent;
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
            gbOdontologico.BackColor = System.Drawing.Color.Transparent;
        }

        private void buAgregarOdontologia_Enter(object sender, EventArgs e)
        {
            gbOdontologico.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void buAgregarOdontologia_Leave(object sender, EventArgs e)
        {
            gbOdontologico.BackColor = System.Drawing.Color.Transparent;
        }

        private void dtpEcografia_Enter(object sender, EventArgs e)
        {
            gbEcografia.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void dtpEcografia_Leave(object sender, EventArgs e)
        {
            gbEcografia.BackColor = System.Drawing.Color.Transparent;
        }

        private void nudEdadGestacional_Enter(object sender, EventArgs e)
        {
            nudEdadGestacional.BackColor = System.Drawing.Color.LightSkyBlue;
            nudEdadGestacional.Select(0, nudEdadGestacional.Text.Length);
        }

        private void nudEdadGestacional_Leave(object sender, EventArgs e)
        {
            nudEdadGestacional.BackColor = System.Drawing.Color.White;
        }

        private void nudDiasEcografia_Enter(object sender, EventArgs e)
        {
            nudDiasEcografia.BackColor = System.Drawing.Color.LightSkyBlue;
            nudDiasEcografia.Select(0, nudDiasEcografia.Text.Length);
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
            gbEcografia.BackColor = System.Drawing.Color.Transparent;
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
            //gbBuscar.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void gbBuscar_Leave(object sender, EventArgs e)
        {
            //gbBuscar.BackColor = System.Drawing.Color.White;
        }

        private void gbFiltrar_Enter(object sender, EventArgs e)
        {
            //gbFiltrar.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void gbFiltrar_Leave(object sender, EventArgs e)
        {
            //gbFiltrar.BackColor = System.Drawing.Color.White;
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                dtpFecha.Focus();
        }

        
        

        private void buCronograma_Click(object sender, EventArgs e)
        {
            CapaDeNegocios.cHistoriaClinica oHC = new CapaDeNegocios.cHistoriaClinica();
            CapaDeNegocios.TerminoGestacion.cTerminoGestacion oTerminoGestacion = new CapaDeNegocios.TerminoGestacion.cTerminoGestacion();
            CapaDeNegocios.cUtilitarios oUtilitarios = new CapaDeNegocios.cUtilitarios();
            int EdadGestacional = 0;
            DateTime FParto = DateTime.Now;
            bool bFP = false;
            DateTime primera_fecha_max=DateTime.Now  ;
            DateTime segunda_fecha_max=DateTime.Now ;
            int indice_primera_fecha_max = -1;
            int indice_segunda_fecha_max = -1;

            DataTable odt = new DataTable();
            DataRow odr = odt.NewRow();

            DataTable odtHC = new DataTable();
            DataRow odrHC = odtHC.NewRow();

            DataTable odtCitas = new DataTable();
            DataRow odrCitas = odtCitas.NewRow();

            DataTable odtOdontologia = new DataTable();
            DataRow odrOdontologia = odtOdontologia.NewRow();

            DataTable odtEcografia = new DataTable();
            DataRow odrEcografia = odtEcografia.NewRow();

            DataTable odtBateria = new DataTable();
            DataRow odrBateria = odtBateria.NewRow();

            DataTable odtPuerperio = new DataTable();
            DataRow odrPuerperio = odtPuerperio.NewRow();

            DateTime Fecha;
            int sm = 0;

            oHC.Idthistoriaclinica = IdtHistoriaClinica;
            odt = oHC.ListarHistoriaClinicaLargo();

            if (IdtHistoriaClinica != "") { 

            FUR = Convert.ToDateTime(odt.Rows[0]["FUR"]);
            FPP = Convert.ToDateTime(odt.Rows[0]["FPP"]);
            EdadGestacional = (int)odt.Rows[0]["SEMANA APN"];

            if (fecha_reg.Date < FPP.Date)
            {

                odtHC.Columns.Add("", typeof(string));
                odtHC.Columns.Add("", typeof(string));

                odrHC = odtHC.NewRow();
                odrHC[0] = "FUR";
                odrHC[1] = FUR.ToString("dd/MM/yyyy");
                odtHC.Rows.InsertAt(odrHC, 0);

                odrHC = odtHC.NewRow();
                odrHC[0] = "EDAD GESTACIONAL";
                odrHC[1] = EdadGestacional + "sm";
                odtHC.Rows.InsertAt(odrHC, 1);

                odrHC = odtHC.NewRow();
                odrHC[0] = "FPP";
                odrHC[1] = FPP;
                odtHC.Rows.InsertAt(odrHC, 2);

                odt = oUtilitarios.realizar_citas(FPP, fecha_reg, edad_gestacional);

                odtOdontologia.Columns.Add(" ", typeof(string));
                odtOdontologia.Columns.Add("1º ATENCION ODONTOLOGICA", typeof(string));
                odtOdontologia.Columns.Add("2º ATENCION ODONTOLOGICA", typeof(string));

                odrOdontologia = odtOdontologia.NewRow();
                odrOdontologia[0] = "FECHA MAXIMA:";

                /*Determinando 1er control y 2do control*/

                primera_fecha_max = oUtilitarios.determinar_1er_control(odt);
                segunda_fecha_max = oUtilitarios.determinar_2do_control(odt);

                odtCitas = odt;

                odrOdontologia[1] = primera_fecha_max.Date.ToString();
                odrOdontologia[2] = segunda_fecha_max.Date.ToString();

                odtOdontologia.Rows.InsertAt(odrOdontologia, 0);

                odtEcografia.Columns.Add(" ", typeof(string));
                odtEcografia.Columns.Add("1º ECOGRAFIA", typeof(string));
                odtEcografia.Columns.Add("2º ECOGRAFIA", typeof(string));

                odrEcografia = odtEcografia.NewRow();
                odrEcografia[0] = "FECHA MAXIMA";

             
                odrEcografia[1] = primera_fecha_max.Date.ToString();
 
                odrEcografia[2] = segunda_fecha_max.Date.ToString();
       

                odtEcografia.Rows.InsertAt(odrEcografia, 0);

                odtBateria.Columns.Add(" ", typeof(string));
                odtBateria.Columns.Add("1º BATERIA", typeof(string));
                odtBateria.Columns.Add("2º BATERIA", typeof(string));

                odrBateria = odtBateria.NewRow();
                odrBateria[0] = "FECHA MAXIMA";

  
                odrBateria[1] = primera_fecha_max.Date.ToString();
 
                odrBateria[2] = segunda_fecha_max.Date.ToString();
            
                odtBateria.Rows.InsertAt(odrBateria, 0);

                odt.Rows.RemoveAt(2);

                odtPuerperio.Columns.Add(" ", typeof(string));
                odtPuerperio.Columns.Add("  ", typeof(string));

                /*hallando fecha parto*/
                odt = oTerminoGestacion.ListarTerminoGestacion(IdtHistoriaClinica);


                if (odt.Rows.Count > 0) { 
                    FParto = (DateTime) odt.Rows[0]["FECHA"];
                    bFP = true;
                }

                odrPuerperio = odtPuerperio.NewRow();

                if (bFP)
                {
                    odrPuerperio = odtPuerperio.NewRow();
                    odrPuerperio[0] = "FP:";
                    odrPuerperio[1] = FParto.ToString("dd/MM/yyyy");
                    odtPuerperio.Rows.InsertAt(odrPuerperio, 0);

                    odrPuerperio = odtPuerperio.NewRow();
                    odrPuerperio[0] = "1° CP:";
                    Fecha = FParto.AddDays(7);
                    odrPuerperio[1] = Fecha.ToString("dd/MM/yyyy") + " (A los 7 días)"; ;
                    odtPuerperio.Rows.InsertAt(odrPuerperio, 1);

                    odrPuerperio = odtPuerperio.NewRow();
                    Fecha = FParto.AddDays(30);
                    odrPuerperio[0] = "2° CP:";
                    odrPuerperio[1] = Fecha.ToString("dd/MM/yyyy") + " (A los 30 días)";
                    odtPuerperio.Rows.InsertAt(odrPuerperio, 2);
                }
                else {
                    odrPuerperio = odtPuerperio.NewRow();
                    odrPuerperio[0] = "FPP:";
                    odrPuerperio[1] = FPP.ToString("dd/MM/yyyy");
                    odtPuerperio.Rows.InsertAt(odrPuerperio, 0);

                    odrPuerperio = odtPuerperio.NewRow();
                    odrPuerperio[0] = "1° CP:";
                    Fecha = FPP.AddDays(7);
                    odrPuerperio[1] = Fecha.ToString("dd/MM/yyyy") + " (A los 7 días)"; ;
                    odtPuerperio.Rows.InsertAt(odrPuerperio, 1);

                    odrPuerperio = odtPuerperio.NewRow();
                    odrPuerperio[0] = "2° CP:";
                    Fecha = FPP.AddDays(30);
                    odrPuerperio[1] = Fecha.ToString("dd/MM/yyyy") + " (A los 30 días)";
                    odtPuerperio.Rows.InsertAt(odrPuerperio, 2);
                }
            
            

            

                /*Creacion de pdf*/


                FileInfo file = new FileInfo(@"C:\PDFs\Cronograma.pdf");
                bool estaAbierto = false;
                int numero_columnas_dgv = 0;
                int numero_columnas_dgv_2 = 0;
                
                estaAbierto = oUtilitarios.esta_en_uso(file, @"C:\PDFs\Cronograma.pdf");

                if (!estaAbierto)
                {
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
                    paragraph.Add("CRONOGRAMA DE GESTANTE PERTENECIENTE A: \n " + Nombre_Completo + " AL " + DateTime.Now.ToString("dd/MM/yyyy") + "\n\n\n");

                    /*              Llenar datagrids            */
                    FileStream fs = new FileStream(folderPath + "Cronograma.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, fs);
                    CreateHeaderFooter(ref pdfDoc);
                    //Abrir pagina
                    pdfDoc.Open();

                    //Total de filas en dgvBoletaPago_A, si es mayor a 0 procede a reporte
                    //instanciando pdfTable A , B , C , D , E

                    dgvHC.DataSource = odtHC;
                    PdfPTable pdfTable_HC = new PdfPTable(dgvHC.ColumnCount);
                    pdfTable_HC = pdf_HC(0, 100);
                    dgvOdonto.DataSource = odtOdontologia;
                    PdfPTable pdfTable_Odontologia = new PdfPTable(dgvOdonto.ColumnCount);
                    pdfTable_Odontologia = pdf_Odontologia(0, 100);
                    dgvEco.DataSource = odtEcografia;
                    PdfPTable pdfTable_Ecografia = new PdfPTable(dgvEco.ColumnCount);
                    pdfTable_Ecografia = pdf_Ecografia(0, 100);
                    dgvBat.DataSource = odtBateria;
                    PdfPTable pdfTable_Bateria = new PdfPTable(dgvBat.ColumnCount);
                    pdfTable_Bateria = pdf_Bateria(0, 100);
                    dgvCitas1.DataSource = odtCitas;

                    bcero = false;

                    if (dgvCitas1.ColumnCount % 2 != 0) {
                        numero_columnas_dgv = (int)Math.Ceiling((Decimal)dgvCitas1.ColumnCount / 2);
                        numero_columnas_dgv_2 = dgvCitas1.ColumnCount / 2;
                        mitad_cantidad_cronograma_parte_1 = (int)Math.Ceiling((Decimal)dgvCitas1.ColumnCount / 2);
                        mitad_cantidad_cronograma_parte_2 = (int)dgvCitas1.ColumnCount / 2;
                    }
                    else {
                        numero_columnas_dgv = dgvCitas1.ColumnCount / 2;
                        numero_columnas_dgv_2 = dgvCitas1.ColumnCount / 2;
                        mitad_cantidad_cronograma_parte_1 = dgvCitas1.ColumnCount / 2;
                        mitad_cantidad_cronograma_parte_2 = (int)dgvCitas1.ColumnCount / 2;
                    }

                    if (numero_columnas_dgv_2 == 0){ 
                        numero_columnas_dgv_2 = 1;
                        bcero = true;
                    }

                    PdfPTable pdfTable_citas_1 = new PdfPTable(numero_columnas_dgv);
                    pdfTable_citas_1 = pdf_citas_parte_1(0, 100);

                    PdfPTable pdfTable_citas_2 = new PdfPTable(numero_columnas_dgv_2);
                    pdfTable_citas_2 = pdf_citas_parte_2(0, 100);

                    dgvPuerperio.DataSource = odtPuerperio;
                    PdfPTable pdfTable_Puerperio = new PdfPTable(dgvPuerperio.ColumnCount);
                    pdfTable_Puerperio = pdf_puerperio(0, 100);

                    PdfPTable pdfTable_vacio = new PdfPTable(1);

                    //Nueva pagina
                    pdfDoc.NewPage();

                    //Columnas 
                    MultiColumnText columns = new MultiColumnText();
                    columns.AddRegularColumns(36f, pdfDoc.PageSize.Width - 36f, 24f, 1);

                        //Imagen
                        //string ruta = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));

                        //C:\\Users\\ADVANCE\\Source\\Repos\\slnRecursosHumanos\\slnRecursosHumanos\\CapaUsuario\\bin\\Debug
                        //C:\\Users\\ADVANCE\\Source\\Repos\\slnRecursosHumanos\\slnRecursosHumanos\\CapaUsuario

                    string ruta = AppDomain.CurrentDomain.BaseDirectory;

                    //string ruta = "C:\\Program Files\\EDIRIUS SOFT S.A.C\\Sistema Control Gestantes";

                    string ruta_imagen = ruta + "\\logo.jpg";
                    string ruta_imagen_odo = ruta + "\\odontologia.JPG";
                    string ruta_imagen_eco = ruta + "\\ecografia.png";
                    string ruta_imagen_pue = ruta + "\\parto.JPG";
                    string ruta_imagen_bat = ruta + "\\laboratorio.JPG";
                    string ruta_imagen_ges = ruta + "\\gestante.png";
 

                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(ruta_imagen);
                    logo.ScalePercent(24f);
                    logo.SetAbsolutePosition(35f, pdfDoc.PageSize.Height - 70f);

                    iTextSharp.text.Image logo1 = iTextSharp.text.Image.GetInstance(ruta_imagen_odo);
                    logo1.ScalePercent(44f);
                    logo1.SetAbsolutePosition(90f, pdfDoc.PageSize.Height - 370f);

                    iTextSharp.text.Image logo2 = iTextSharp.text.Image.GetInstance(ruta_imagen_eco);
                    logo2.ScalePercent(19f);
                    logo2.SetAbsolutePosition(280f, pdfDoc.PageSize.Height - 370f);

                    iTextSharp.text.Image logo4 = iTextSharp.text.Image.GetInstance(ruta_imagen_bat);
                    logo4.ScalePercent(44f);
                    logo4.SetAbsolutePosition(450f, pdfDoc.PageSize.Height - 370f);

                    iTextSharp.text.Image logo3 = iTextSharp.text.Image.GetInstance(ruta_imagen_pue);
                    logo3.ScalePercent(44f);
                    logo3.SetAbsolutePosition(660f, pdfDoc.PageSize.Height - 370f);
                    
                    iTextSharp.text.Image logo5 = iTextSharp.text.Image.GetInstance(ruta_imagen_ges);
                    logo5.ScalePercent(34f);
                    logo5.SetAbsolutePosition(220f, pdfDoc.PageSize.Height - 190f);



                    //tabla que ecografia y odontologia
                    PdfPTable tabla_cronograma_parte_1 = new PdfPTable(2);

                    tabla_cronograma_parte_1.DefaultCell.BorderWidth = 0;

                    //tabla que ecografia y odontologia
                    PdfPTable tabla_cronograma_parte_2 = new PdfPTable(1);
                    tabla_cronograma_parte_2.DefaultCell.BorderWidth = 0;

                    //var colWidthPercentages = new[] { 45f, 25f, 30f };
                    //tabla_cronograma.SetWidths(colWidthPercentages);

                    //tabla que ecografia y odontologia
                    PdfPTable tabla_fila_1 = new PdfPTable(3);
                    tabla_fila_1.DefaultCell.BorderWidth = 0;

                    //fila 2
                    PdfPTable tabla_fila_2 = new PdfPTable(3);
                    tabla_fila_2.DefaultCell.BorderWidth = 0;

                    //fila 3
                    PdfPTable tabla_fila_3 = new PdfPTable(4);
                    tabla_fila_3.DefaultCell.BorderWidth = 0;

                    //fila 3
                    PdfPTable tabla_fila_4 = new PdfPTable(4);
                    tabla_fila_4.DefaultCell.BorderWidth = 0;

                

                    if (bcero)
                    {
                        //Agrupando tabla titular
                        tabla_fila_1.AddCell(pdfTable_HC);
                        tabla_fila_1.AddCell(pdfTable_vacio);
                        tabla_fila_1.AddCell(pdfTable_citas_1);

                        tabla_fila_2.AddCell(pdfTable_vacio);
                        tabla_fila_2.AddCell(pdfTable_vacio);
                        tabla_fila_2.AddCell(pdfTable_vacio);
                    
                    }
                    else {
                        //Agrupando tabla titular
                        tabla_fila_1.AddCell(pdfTable_HC);
                        tabla_fila_1.AddCell(pdfTable_vacio);
                        tabla_fila_1.AddCell(pdfTable_citas_1);

                        tabla_fila_2.AddCell(pdfTable_vacio);
                        tabla_fila_2.AddCell(pdfTable_vacio);
                        tabla_fila_2.AddCell(pdfTable_citas_2);
                    }

                

                    tabla_fila_3.AddCell(pdfTable_Odontologia);
                    tabla_fila_3.AddCell(pdfTable_Ecografia);
                    tabla_fila_3.AddCell(pdfTable_Bateria);
                    tabla_fila_3.AddCell(pdfTable_Puerperio);

                    tabla_fila_4.AddCell(pdfTable_vacio);
                    tabla_fila_4.AddCell(pdfTable_vacio);
                    tabla_fila_4.AddCell(pdfTable_vacio);
                    tabla_fila_4.AddCell(pdfTable_vacio);

                    var colWidthPercentages = new[] { 20f, 20f, 67f };
                    tabla_fila_1.SetWidths(colWidthPercentages);
                    tabla_fila_1.WidthPercentage = 100;

                    var colWidthPercentages_2 = new[] { 20f, 20f, 67f };
                    tabla_fila_2.SetWidths(colWidthPercentages_2);
                    tabla_fila_2.WidthPercentage = 100;

                    var colWidthPercentages_3 = new[] { 25f, 25f, 25f,25f };
                    tabla_fila_3.SetWidths(colWidthPercentages_3);
                    tabla_fila_3.WidthPercentage = 100;

                    var colWidthPercentages_4 = new[] { 25f, 25f, 25f, 25f };
                    tabla_fila_4.SetWidths(colWidthPercentages_4);
                    tabla_fila_4.WidthPercentage = 100;

                    //Agregando pdfTable A, B, C, D, E a pdfDoc
                    columns.AddElement(paragraph);
                    columns.AddElement(tabla_fila_1);
                    columns.AddElement(tabla_fila_2);
                    columns.AddElement(tabla_fila_4);
                    columns.AddElement(tabla_fila_3);

                    pdfDoc.Add(logo);
                    pdfDoc.Add(logo1);
                    pdfDoc.Add(logo2);
                    pdfDoc.Add(logo3);
                    pdfDoc.Add(logo4);
                    pdfDoc.Add(logo5);

                    pdfDoc.Add(columns);

                    pdfDoc.Close();
                    writer.Close();
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.EnableRaisingEvents = false;
                    proc.StartInfo.FileName = "C:\\PDFs\\Cronograma.pdf";
                    proc.Start();
                }
                else
                {
                    MessageBox.Show("Por favor cerrar Cronograma.pdf", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            else
            {
                MessageBox.Show("No se puede realizar un cronograma que tenga una fecha de registro mayor a la FPP.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            }else
                MessageBox.Show("Porfavor seleccione un control gestante.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void buMorbilidad_MouseEnter(object sender, EventArgs e)
        {
            pbMorbilidad.Visible = false;
            pbMM.Visible = true;
        }

        private void buMorbilidad_MouseLeave(object sender, EventArgs e)
        {
            pbMorbilidad.Visible = true;
            pbMM.Visible = false;
            
        }

        private void buAtencionPrenatal_MouseEnter(object sender, EventArgs e)
        {
            pbPrenatal.Visible = false;
            pbAPN.Visible = true;
        }

        private void buAtencionPrenatal_MouseLeave(object sender, EventArgs e)
        {
            pbPrenatal.Visible = true;
            pbAPN.Visible = false;
        }

        private void buRegistroBateria_MouseEnter(object sender, EventArgs e)
        {
            pbRegBateria.Visible = false;
            pbRB.Visible = true;
        }

        private void buRegistroBateria_MouseLeave(object sender, EventArgs e)
        {
            pbRegBateria.Visible = true;
            pbRB.Visible = false;
        }

        private void buVisitaDomiciliaria_MouseEnter(object sender, EventArgs e)
        {
            pbVisitaDomiciliaria.Visible = false;
            pbVD.Visible = true;
        }

        private void buVisitaDomiciliaria_MouseLeave(object sender, EventArgs e)
        {
            pbVisitaDomiciliaria.Visible = true;
            pbVD.Visible = false;
        }

        private void btnTerminoGestacion_MouseEnter(object sender, EventArgs e)
        {
            pbTerminoGestacion.Visible = false;
            pbTG.Visible = true;
        }

        private void btnTerminoGestacion_MouseLeave(object sender, EventArgs e)
        {
            pbTerminoGestacion.Visible = true;
            pbTG.Visible = false;
        }

        private void buControlPuerperio_MouseEnter(object sender, EventArgs e)
        {
            pbControlPuerperio.Visible = false;
            pbCP.Visible = true;
        }

        private void buControlPuerperio_MouseLeave(object sender, EventArgs e)
        {
            pbControlPuerperio.Visible = true;
            pbCP.Visible = false;
        }

        private void btnRecienNacido_MouseEnter(object sender, EventArgs e)
        {
            pbRecienNAcido.Visible = false;
            pbARN.Visible = true;
        }

        private void btnRecienNacido_MouseLeave(object sender, EventArgs e)
        {
            pbRecienNAcido.Visible = true;
            pbARN.Visible = false;
        }

        private void buCronograma_MouseEnter(object sender, EventArgs e)
        {
            pbCronograma.Visible = false;
            pbCR.Visible = true;
        }

        private void buCronograma_MouseLeave(object sender, EventArgs e)
        {
            pbCronograma.Visible = true;
            pbCR.Visible = false;
        }

        private void buBuscar_Click(object sender, EventArgs e)
        {

            fBuscarCicloGestante.IdObstetra = IdObstetra ;
            fBuscarCicloGestante.IdtEstablecimientoSalud = IdEstablecimiento;

            if (fBuscarCicloGestante.ShowDialog() == DialogResult.OK)
            {
                dtpFecha.Focus();
                IdtHistoriaClinica = fBuscarCicloGestante.IdtHistoriaClinica;
                cargar_hc();
            }
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            calcular_imc();
        }

        private void txtTalla_TextChanged(object sender, EventArgs e)
        {
            calcular_imc();
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            string word = "";
            int inicio = 0, fin = 0;
            //if (e.KeyCode == Keys.Back)
            //inicio = txtPeso.SelectionStart;
            //fin = txtPeso.SelectionLength;

            if (e.KeyChar == 8)
            {
                word = txtPeso.Text.Trim();
                if (word.Length > 0)
                {
                    txtPeso.Text = word.Substring(0, word.Length - 1);
                    txtPeso.Select(txtPeso.Text.Length, 0);
                    e.Handled = true;
                }
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(txtPeso.Text, @"\d{1,4}\.?\d{3,3}"))
                e.Handled = true;

            if (e.KeyChar == (char)13)
                txtTalla.Focus();
            

        }

        private void txtTalla_KeyPress(object sender, KeyPressEventArgs e)  
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')  )
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            string word = txtTalla.Text.Trim();
            //if (e.KeyCode == Keys.Back)
            if (e.KeyChar == 8)
            {
                word = txtTalla.Text.Trim();
                if (word.Length > 0)
                {
                    txtTalla.Text = word.Substring(0, word.Length - 1);
                    txtTalla.Select(txtTalla.Text.Length, 0);
                    e.Handled = true;
                }
            }
 
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTalla.Text, @"\d{0,1}\.?\d{2,2}"))
                e.Handled = true;

            if (e.KeyChar == (char)13)
                txtObservaciones.Focus();
            

        }

        private void txtTalla_KeyDown(object sender, KeyEventArgs e)
        {
  
        }

        private void txtTalla_KeyUp(object sender, KeyEventArgs e)
        {

            
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void lblIMC_Click(object sender, EventArgs e)
        {
            
        }

        private void cbTranseunte_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTranseunte.Checked == false)
            {
                lblOrigenEESS.Visible = false;
                //cbEstablecimientoSalud.Visible = false;
                txtOrigenEESS.Visible = false;
            }
            else
            {
                lblOrigenEESS.Visible = true;
                //cbEstablecimientoSalud.Visible = true;
                txtOrigenEESS.Visible = true;
            }

        }

        private void cbArchivado_CheckedChanged_1(object sender, EventArgs e)
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
                        ancho_odo_eco_dgv();
                    }
                    else
                    {
                        cbArchivado.Checked = false;
                        bloquear_hc(true);
                        ancho_odo_eco_dgv();
                    }
                }

                if (cbArchivado.Checked == false)
                {
                    lblArchivado.Text = "SIN ARCHIVAR";
                    lblArchivado.BackColor = System.Drawing.Color.Red;
                    bloquear_hc(true);
                    ancho_odo_eco_dgv();
                }
            }
            else
            {
                if (cbArchivado.Checked == true)
                {
                    lblArchivado.Text = "ARCHIVADO";
                    lblArchivado.BackColor = System.Drawing.Color.Green;
                    cbArchivado.Checked = true;
                    bloquear_hc(false);
                    ancho_odo_eco_dgv();
                }

                if (cbArchivado.Checked == false)
                {
                    lblArchivado.Text = "SIN ARCHIVAR";
                    lblArchivado.BackColor = System.Drawing.Color.Red;
                    bloquear_hc(true);
                    ancho_odo_eco_dgv();
                }
            }
            ancho_odo_eco_dgv();
        }

        private void txtPeso_Enter(object sender, EventArgs e)
        {
            txtPeso.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void txtPeso_Leave(object sender, EventArgs e)
        {
            txtPeso.BackColor = System.Drawing.Color.White;
        }

        private void txtTalla_Enter(object sender, EventArgs e)
        {
            txtTalla.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void txtTalla_Leave(object sender, EventArgs e)
        {
            txtTalla.BackColor = System.Drawing.Color.White;
        }

        private void txtObservaciones_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                cbTranseunte.Focus();
        }

        private void cbTranseunte_KeyPress_2(object sender, KeyPressEventArgs e)
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

        private void cbArchivado_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                buGuardar.Focus();
        }

        private void txtOrigenEESS_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                cbArchivado.Focus();
        }

        private void dtpFUR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                dtpOdontologo.Focus();
        }

        private void txtObservaciones_Enter_1(object sender, EventArgs e)
        {
            txtObservaciones.Select(0, txtObservaciones.Text.Length);
        }

        private void gbFecha_Enter(object sender, EventArgs e)
        {

        }

        private void pbecografia_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtOrigenEESS_Enter_1(object sender, EventArgs e)
        {
            txtOrigenEESS.Select(0, txtOrigenEESS.Text.Length);
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
            float[] values = new float[mitad_cantidad_cronograma_parte_1];
            for (int i = 0; i < mitad_cantidad_cronograma_parte_1; i++)
            {
                //if (i<10)
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }

        public float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }

        public float[] GetTamañoColumnas_parte_2(DataGridView dg)
        {

            float[] values = new float[mitad_cantidad_cronograma_parte_2];
            for (int i = 0; i < mitad_cantidad_cronograma_parte_2; i++)
            {
                //if (i>=10)
                    values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }

         

    }



}


