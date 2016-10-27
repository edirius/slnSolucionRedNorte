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
        public frmGestante frmGestanteHC = new frmGestante();
        public frmMenu frmMenuHC = new frmMenu();
        DataTable odtOdontologo = new DataTable();
        DataTable odtEcografia = new DataTable();
        public string idtpaciente = "";
        public string establecimientosalud = "";

        public string IdObstetra = "";
        public string IdEstablecimiento = "";
        public string IdtHistoriaClinica = "";
        int i = 0;
        string obstetra = "";

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

        private void frmHistoriaClinica_Load(object sender, EventArgs e)
        {
            DataTable odtHistoriaClinica = new DataTable();
            CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();

            /*datagridview odontologo*/

            odtOdontologo.Columns.Add("N°", typeof(string));
            odtOdontologo.Columns.Add("Segunda visita", typeof(string));

            DataGridViewButtonColumn dgvbOdontologo = new DataGridViewButtonColumn();
            dgvbOdontologo.Name = "Acción";
            dgvbOdontologo.Text = "Eliminar";
            dgvbOdontologo.HeaderText = "Acción";
            dgvbOdontologo.UseColumnTextForButtonValue = true;
            
            int columnIndex = 2;

            dgvOdontologia.DataSource = odtOdontologo;
            dgvOdontologia.Columns[0].Width = 30;
            dgvOdontologia.Columns[1].Width = 110;
            
            dgvOdontologia.Columns.Insert(columnIndex, dgvbOdontologo);

            /*datagridview ecografia*/

            DataGridViewButtonColumn dgvbEcografia = new DataGridViewButtonColumn();
            dgvbEcografia.Name = "Acción";
            dgvbEcografia.Text = "Eliminar";
            dgvbEcografia.HeaderText = "Acción";
            dgvbEcografia.UseColumnTextForButtonValue = true;

            odtEcografia.Columns.Add("N°", typeof(string));
            odtEcografia.Columns.Add("Fecha Ecografia", typeof(string));
            odtEcografia.Columns.Add("Edad Gestacional", typeof(string));

            columnIndex = 3;

            dgvEcografia.DataSource = odtEcografia;
            dgvEcografia.Columns[0].Width = 30;
            dgvEcografia.Columns.Insert(columnIndex, dgvbEcografia);

            /*datetimepicker 24 hrs format*/

            dtpTiempoLlegada.ShowUpDown = true;
            dtpTiempoLlegada.CustomFormat = "HH:MM";
            dtpTiempoLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

            /*Id de obstetra*/
            oHistoriaClinica.Idtobstetra = IdObstetra;
            dgvHC.DataSource = oHistoriaClinica.ListarHistoriaClinica();


        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void buAgregarOdontologia_Click(object sender, EventArgs e)
        {

            //frmGestante.MdiParent = this;
            if (frmGestanteHC.ShowDialog() == DialogResult.OK)
            {
                txtDNI.Text = frmGestanteHC.DNI;
                txtNombres.Text = frmGestanteHC.nombres;
                txtApellidoPaterno.Text = frmGestanteHC.app;
                txtApellidoMaterno.Text = frmGestanteHC.apm;
                DateTime fn_ = frmGestanteHC.fn;

                DateTime now = DateTime.Today;
                int age = now.Year - fn_.Year;
                if (now < fn_.AddYears(age)) age--;

                txtEdad.Text = age.ToString();
                idtpaciente = frmGestanteHC.idtpaciente;
            }
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
            DataRow drOdontologo = odtOdontologo.NewRow();
            

            drOdontologo = odtOdontologo.NewRow();
            i = odtOdontologo.Rows.Count;
            i++;
            drOdontologo[0] = i;
            drOdontologo[1] = dtpOdontologo.Value.ToString("yyyy - MM - dd");
            //drOdontologo[2] = 
            odtOdontologo.Rows.InsertAt(drOdontologo,i);
        }

        private void dgvOdontologia_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            DataRow drEcografia = odtEcografia.NewRow();

            
                drEcografia = odtEcografia.NewRow();
                i = odtEcografia.Rows.Count;
                i++;
                drEcografia[0] = i;
                drEcografia[1] = dtpEcografia.Value.ToString("yyyy - MM - dd") ;
                drEcografia[2] = nudEdadGestacional.Value;
                odtEcografia.Rows.InsertAt(drEcografia, i);
            
        }

        private void dgvEcografia_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            //try{ 

            CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();
            CapaDeNegocios.cEcografia oEcografia = new CapaDeNegocios.cEcografia();
            CapaDeNegocios.cOdontologia oOdontologia = new CapaDeNegocios.cOdontologia();

            DataTable odtHistoriaClinica = new DataTable();
                bool completo = false;
                string mensaje = "";

                

                oHistoriaClinica.Idtestablecimientosalud = IdEstablecimiento;
                oHistoriaClinica.Codigohistoriaclinica = txtHistoriaClinica.Text;
                oHistoriaClinica.Tipollegada =  cboTipoLlegada.Text;
                oHistoriaClinica.Tiempollegada = dtpTiempoLlegada.Text ;
                if (txtEdad.Text != "")
                    oHistoriaClinica.Edad = Convert.ToInt16( txtEdad.Text);
            
                oHistoriaClinica.Gestas = Convert.ToInt16( nudGestas.Text );
                oHistoriaClinica.Partos= Convert.ToInt16(nudPartos.Text);
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
                oHistoriaClinica.Diaapn = Convert.ToString( nudEdadGestacional.Value );
                oHistoriaClinica.Observaciones = txtObservaciones.Text;
                oHistoriaClinica.Idtpaciente = idtpaciente;
                oHistoriaClinica.Idtobstetra = IdObstetra;


                /*Validando datos*/

                if (dgvEcografia.Rows.Count < 1)
                {
                    completo = true;
                    mensaje = "Porfavor agregar fecha(s) al servicio de Odontologia.";
                }

                if (dgvEcografia.Rows.Count < 1)
                {
                    completo = true;
                    mensaje = "Porfavor agregar fecha(s) al servicio de Ecografia Obstetrica.";
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

                if (oHistoriaClinica.Codigohistoriaclinica == "") {
                    completo = true;
                    mensaje = "Porfavor llenar Codigo de Historia Clinica";
                }

           
                if (completo) { 
                    MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    odtHistoriaClinica = oHistoriaClinica.CrearHistoriaClinica();
                    foreach (DataRow row in odtHistoriaClinica.Rows)
                    {

                        string respuesta_historia_clinica = row[0].ToString().Trim();

                        string[] words = respuesta_historia_clinica.Split('*');
                        
                        string exito = words[0].ToString();
                        string respuesta = words[1].ToString();
                        string idthistoriaclinica = words[2].ToString();
                        DataTable dtEcografia = new DataTable();
                        DataTable dtOdontologia = new DataTable();
                        DataTable dtEcografia2 = new DataTable();
                        DataTable dtOdontologia2 = new DataTable();
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
                            for (int i=0; i< cantidad_filas_ecografia; i++){
                                respuesta_ecografia = dgvEcografia[3, i].Value.ToString();
                                
                                oEcografia.Fecha_servicio = Convert.ToDateTime (dgvEcografia[2, i].Value.ToString() );
                                oEcografia.Edadgestacional = dgvEcografia[3, i].Value.ToString();
                                oEcografia.Idthistoriaclinica = idthistoriaclinica ;
                                dtEcografia = oEcografia.CrearEcografia();
                                foreach (DataRow row_e in dtEcografia.Rows){
                                    respuesta_ecografia = row_e[0].ToString().Trim();
                                    words_ecografia = respuesta_ecografia.Split('-');
                                    suma_ecografia = suma_ecografia + Convert.ToInt16(words_ecografia[0].ToString());
                                }
                            }


                        cantidad_filas_odontologia = dgvOdontologia.Rows.Count;
                        for (int i = 0; i < cantidad_filas_odontologia; i++)
                        {
                            oOdontologia.Fecha_servicio = Convert.ToDateTime(dgvOdontologia[2, i].Value.ToString() );
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
                            MessageBox.Show(respuesta, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            nueva_historia_clinica();
                            oHistoriaClinica.Idtobstetra = IdObstetra;
                            dgvHC.DataSource= oHistoriaClinica.ListarHistoriaClinica();
                        
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

        private void nueva_historia_clinica() {
            txtHistoriaClinica.Text = "";

            dtpTiempoLlegada.Text = "";
            txtEdad.Text = "";
            txtDNI.Text = "";
            txtNombres.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";


            nudGestas.Value = 0;
            nudPartos.Value = 0;
            nudAbortos.Value = 0;
            nudHv.Value = 0;
            nudHm.Value = 0;

            
            txtObservaciones.Text = "";
            txtDNI.Focus();
        }

        private void dtpFUR_ValueChanged(object sender, EventArgs e)
        {

           
        }

        private void dtpFUR_KeyUp(object sender, KeyEventArgs e)
        {
            DateTime FUR = dtpFUR.Value;
            FUR = FUR.AddDays(7);
            FUR = FUR.AddMonths(-3);
            dtpFPP.Value = FUR;
        }

        private void rbPrimerTrimestre_CheckedChanged(object sender, EventArgs e)
        {
            nupSemanas.Minimum = 1;
            nupSemanas.Maximum = 12;

        }

        private void rbSegundoTrimestre_CheckedChanged(object sender, EventArgs e)
        {
            nupSemanas.Minimum = 13;
            nupSemanas.Maximum = 28;
        }

        private void rbTercerTrimestre_CheckedChanged(object sender, EventArgs e)
        {
            nupSemanas.Minimum = 29;
            nupSemanas.Maximum = 42;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdtHistoriaClinica = dgvHC[0, e.RowIndex].Value.ToString();
            
        }

        private void dgvHC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdtHistoriaClinica = dgvHC[0,e.RowIndex].Value.ToString();

        }
    }
}


