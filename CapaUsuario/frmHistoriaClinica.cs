﻿using System;
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
        public frmGestante frmGestanteHC = new frmGestante();
        DataTable odtOdontologo = new DataTable();
        DataTable odtEcografia = new DataTable();
        string idtpaciente = "";
        int i = 0;
        string obstetra = "";

        public frmHistoriaClinica()
        {
            InitializeComponent();
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
            obstetra = "E006O00001";


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
            CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();
            DataTable odtHistoriaClinica = new DataTable();
            bool completo = false;
            string mensaje = "";


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
            oHistoriaClinica.Fur = dtpFUR.Value;
            oHistoriaClinica.Fpp = dtpFPP.Value;

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
            oHistoriaClinica.Idtobstetra = obstetra;


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
                //odtHistoriaClinica = oHistoriaClinica.CrearHistoriaClinica( oHistoriaClinica );
                odtHistoriaClinica = oHistoriaClinica.CrearHistoriaClinica();
                //int re = oHistoriaClinica.CrearHistoriaClinica();
                //odtHistoriaClinica = oHistoriaClinica.CrearHistoriaClinica( oHistoriaClinica.Codigohistoriaclinica , oHistoriaClinica.Tipollegada, oHistoriaClinica.Tiempollegada, oHistoriaClinica.Edad, oHistoriaClinica.Gestas, oHistoriaClinica.Partos, oHistoriaClinica.Abortos, oHistoriaClinica.Hijosvivos, oHistoriaClinica.Hijosmuertos,oHistoriaClinica.Fur, oHistoriaClinica.Fpp, oHistoriaClinica.Trimestreapn, oHistoriaClinica.Diaapn, oHistoriaClinica.Observaciones, oHistoriaClinica.Idtpaciente, oHistoriaClinica.Idtobstetra);
                foreach (DataRow row in odtHistoriaClinica.Rows)
                {

                    string respuesta_historia_clinica = row[0].ToString().Trim();

                    string[] words = respuesta_historia_clinica.Split(' ');

                    foreach (string word in words)
                    {
                        string exito = word[0].ToString();
                        string respuesta = word[1].ToString();
                        if (exito == "0")
                            MessageBox.Show(respuesta, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (exito == "1")
                        {
                            MessageBox.Show(respuesta, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    
                }
            }



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
    }
}


