using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocios;
using CapaDeNegocios.CitaPreNatal;

namespace CapaUsuario.CitaPreNatal
{
    public partial class frmCitaPreNatal : Form
    {
        public frmCitaPreNatal()
        {
            InitializeComponent();
        }

        public string Establecimiento
        { get; set; }

        public string HistoriaClinica
        { get; set; }

        public DateTime FUR
        { get; set; }

        public DateTime FPP
        { get; set; }

        public DateTime Fecha_Registro
        { get; set; }

        public int Semana_Gestacional
        { get; set; }

        public double dias_gestacional
        { get; set; }

        

        public int edad_gestacional_citas = 0;

        public cCitaPrenatal oCitaPrenatal = new cCitaPrenatal();
        private int limitePresionArterialS = 140;
        private int limitePresionArterialD = 85;

        private string estado = "nuevo";

        private void frmCitaPreNatal_Load(object sender, EventArgs e)
        {
            VerificarTerminoGestacion();
            //MessageBox.Show(Establecimiento);
            CargarDatos();
            


            realizar_atencion_citas_gestante();
            //if (dtgCitasMedicas.Rows.Count > 0)
            //{
            //    btnGuardar.Enabled = true;
            //}
            //else
            //{
            //    btnGuardar.Enabled = false;
            //}
            estado = "nuevo";
        }

        private DataTable realizar_citas(DataTable odtCitas)
        {
            CapaDeNegocios.CitaPreNatal.cCitaPrenatal oCitaPrenatal = new CapaDeNegocios.CitaPreNatal.cCitaPrenatal();
            DataTable odtCitaPrenatal = new DataTable();
            DateTime fecha_cita, fecha_prox_cita, fecha_fin;
            int semana_gestacional = 0;
            DataRow odrCitas = odtCitas.NewRow();
            int k = 0;
            bool ocupado = false;
            /*calculando numero de cita*/

            fecha_cita = Fecha_Registro;
            fecha_prox_cita = Fecha_Registro.AddMonths(1);
            //fecha_fin = Fecha_Registro.AddDays(28);
            semana_gestacional = edad_gestacional_citas;
            
            while ( semana_gestacional <= 42 && Fecha_Registro.Date < FPP.Date ) {

                /*nº cita, fecha cita, edad gestacional */
                odrCitas = odtCitas.NewRow();

                /*Numero de cita prenatal*/
                oCitaPrenatal.HistoriaClinica.Idthistoriaclinica = HistoriaClinica;
                odtCitaPrenatal = oCitaPrenatal.ListaCitasPreNatal();
                if (odtCitaPrenatal.Rows.Count > 0)
                {
                    oCitaPrenatal.NumeroCita = Convert.ToInt16(odtCitaPrenatal.Rows[odtCitaPrenatal.Rows.Count - 1][2]) + 1;
                    odrCitas[0] = Convert.ToInt16(odtCitaPrenatal.Rows[odtCitaPrenatal.Rows.Count - 1][2]) + 1;
                }
                else { 
                    oCitaPrenatal.NumeroCita = 1;
                    odrCitas[0] = 1;
                }

                /*codigo, codigo historia clinica, n° cita, fecha cita, edad gestacional, fua, presion arterial, sulfato ferroso, presion arterial s, presion arterial d, fecha prox. cita*/


                /*codigo cita prenatal*/
                cSiguienteCodigo miSiguienteCodigo = new cSiguienteCodigo();
                foreach (DataRow row in miSiguienteCodigo.SiguientesCodigo("tcitaprenatal", Establecimiento).Rows)
                {
                    oCitaPrenatal.CodigoCitaPrenatal = row[0].ToString();
                }

                if (k != 0)
                {
                    if (edad_gestacional_citas <= 28 && !ocupado)
                    {
                        edad_gestacional_citas += +4;
                        ocupado = true;
                    }
                    if (edad_gestacional_citas >= 29 && edad_gestacional_citas <= 36 && !ocupado)
                    {
                        edad_gestacional_citas = ((edad_gestacional_citas * 7) + 15) / 7;
                        ocupado = true;
                    }
                    if (edad_gestacional_citas >= 37 && edad_gestacional_citas <= 42 && !ocupado)
                    {
                        edad_gestacional_citas += +1;
                        ocupado = true;
                    }
                    ocupado = false;

                    if (edad_gestacional_citas <= 28 && !ocupado) {
                        Fecha_Registro = Fecha_Registro.AddMonths(1);
                        fecha_cita = fecha_prox_cita;
                        fecha_prox_cita = Fecha_Registro.AddMonths(1);
                        //edad_gestacional_citas += +4;
                        ocupado = true;
                    }
                    if (edad_gestacional_citas >= 29 && edad_gestacional_citas <= 36 && !ocupado)
                    {
                        Fecha_Registro = fecha_prox_cita.AddDays(15);
                        fecha_cita = fecha_prox_cita;
                        fecha_prox_cita = Fecha_Registro;
                        //edad_gestacional_citas = ((edad_gestacional_citas * 7) + 15) / 7;
                        ocupado = true;
                    }
                    if (edad_gestacional_citas >= 37 && edad_gestacional_citas <= 42 && !ocupado)
                    {
                        Fecha_Registro = fecha_prox_cita.AddDays(7);
                        fecha_cita = fecha_prox_cita;
                        fecha_prox_cita = Fecha_Registro;
                        //edad_gestacional_citas += +1;
                        ocupado = true;
                    }
                }
                else {
                    if (edad_gestacional_citas <= 28 && !ocupado)
                    {
                        fecha_cita = Fecha_Registro;
                        fecha_prox_cita = Fecha_Registro.AddMonths(1);
                        Fecha_Registro = fecha_prox_cita;
                        ocupado = true;
                    }
                    if (edad_gestacional_citas >= 29 && edad_gestacional_citas <= 36 && !ocupado)
                    {
                        fecha_cita = Fecha_Registro;
                        fecha_prox_cita = Fecha_Registro.AddDays(15);
                        Fecha_Registro = fecha_prox_cita;
                        ocupado = true;
                    }
                    if (edad_gestacional_citas >= 37 && edad_gestacional_citas <= 42 && !ocupado)
                    {
                        fecha_cita = Fecha_Registro;
                        fecha_prox_cita = Fecha_Registro.AddDays(7);
                        Fecha_Registro = fecha_prox_cita;
                        ocupado = true;
                    }
                }
                ocupado = false;
                odrCitas[1] = Fecha_Registro;
                odrCitas[2] = edad_gestacional_citas;

                odtCitas.Rows.InsertAt(odrCitas,k);
                k++;


                oCitaPrenatal.HistoriaClinica.Idthistoriaclinica = HistoriaClinica;
                oCitaPrenatal.EdadGestacional = edad_gestacional_citas;
                oCitaPrenatal.Fua = "";
                oCitaPrenatal.PresionArterialD = 60;
                oCitaPrenatal.PresionArterialS = 60;
                oCitaPrenatal.SulfatoFerroso = 30;
                /*calculando fecha cita y proxima cita*/
                oCitaPrenatal.FechaCitaPrenatal = fecha_cita;
                oCitaPrenatal.FechaProximaCitaPrenatal = fecha_prox_cita;
                oCitaPrenatal.Asistencia = 0;

                oCitaPrenatal.AgregarCita(oCitaPrenatal);

            }

            oCitaPrenatal.HistoriaClinica.Idthistoriaclinica = HistoriaClinica;
            dtgCitasMedicas.DataSource = oCitaPrenatal.ListaCitasPreNatal();
            pintar_asistencias();
            return odtCitas;


        }

        

        private void realizar_atencion_citas_gestante() {

            DataTable odtCitaPrenatal = new DataTable();
            CapaDeNegocios.CitaPreNatal.cCitaPrenatal oCitaPrenatal = new CapaDeNegocios.CitaPreNatal.cCitaPrenatal();
            DateTime fecha_cita;
            int semana_gestacional = 0;
            DataTable odtCitas = new DataTable();
            /*preparando datatable citas*/


            odtCitas.Columns.Add("N° CITA", typeof(string));
            odtCitas.Columns.Add("FECHA CITA", typeof(string));
            odtCitas.Columns.Add("EDAD GESTACIONAL", typeof(string));
            

            //oCitaPrenatal.HistoriaClinica.Idthistoriaclinica = HistoriaClinica;
            if (dtgCitasMedicas.Rows.Count > 0)
            {
                /*Si primera cita es diferente a fecha de registro se procede a borrar todas las citas del control de gestante y se añaden nuevamente*/
                //fecha_cita = (DateTime) dtgCitasMedicas.Rows[0].Cells["FECHA CITA"].Value;
                fecha_cita = (DateTime)dtgCitasMedicas.Rows[0].Cells[3].Value;
                semana_gestacional = (int) dtgCitasMedicas.Rows[0].Cells[4].Value;
                //FUR = FUR.AddDays(Math.Abs(dias_gestacional));
                if (fecha_cita.ToString("dd/MM/yyyy") != Fecha_Registro.ToString("dd/MM/yyyy") || semana_gestacional != Semana_Gestacional) {
                    oCitaPrenatal.HistoriaClinica.Idthistoriaclinica = HistoriaClinica;
                    oCitaPrenatal.EliminarCitaXHistoriaClinica(oCitaPrenatal);

                    edad_gestacional_citas = Semana_Gestacional;
                    odtCitas = realizar_citas(odtCitas);
                }
            }
            else {
                edad_gestacional_citas = Semana_Gestacional;
                odtCitas = realizar_citas(odtCitas);
                
            }
            /* SE EVALUA LA SEMANA DE LA PRIMERA ATENCION PRENATAL PARA QUE COHINCIDA CON EL PRONOSTICO */

            

        }

        private void VerificarTerminoGestacion()
        {
            try
            {
                CapaDeNegocios.TerminoGestacion.cTerminoGestacion miTerminoGestacion = new CapaDeNegocios.TerminoGestacion.cTerminoGestacion();
                if (miTerminoGestacion.ListarTerminoGestacion(HistoriaClinica).Rows.Count == 0)
                {

                }
                else
                {
                    MessageBox.Show("No se puede añadir mas Citas Prenatales porque la gestante tiene Termino de Gestacion, ");
                    txtNumeroCita.Enabled = false;
                    dtpFechaCita.Enabled = false;
                    numEdadGestacional.Enabled = false;
                    numPresionArterialD.Enabled = false;
                    numPresionArterialS.Enabled = false;
                    dtpProximaCita.Enabled = false;
                    txtFUA.Enabled = false;
                    dtgCitasMedicas.Enabled = false;
                    btnAgregarControl.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnGuardar.Enabled = false;

                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void pintar_asistencias() {
            string asistencia = "";
            for (int i = 0; i < dtgCitasMedicas.Rows.Count; i++)
            {
                asistencia = dtgCitasMedicas.Rows[i].Cells[11].Value.ToString();
                if (asistencia == "Si")
                {
                    for (int j = 0; j < dtgCitasMedicas.Columns.Count; j++)
                        dtgCitasMedicas.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    for (int j = 0; j < dtgCitasMedicas.Columns.Count; j++)
                        dtgCitasMedicas.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                }
            }
        }

        private void CargarDatos()
        {
            
            try
            {
                
                oCitaPrenatal.HistoriaClinica.Idthistoriaclinica = HistoriaClinica;
                dtpProximaCita.MinDate = dtpFechaCita.Value; 
                dtgCitasMedicas.DataSource = oCitaPrenatal.ListaCitasPreNatal();

                /*marcando de verde asistencias y de azul programacion*/
                pintar_asistencias();

                txtNumeroCita.Text = (dtgCitasMedicas.Rows.Count + 1).ToString();
                if (dtgCitasMedicas.Rows.Count > 0)
                {
                    dtpFechaCita.Value = Convert.ToDateTime( dtgCitasMedicas.Rows[dtgCitasMedicas.Rows.Count - 1].Cells["colFechaProximaCita"].Value) ;
                }
                estado = "nuevo";
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al cargar Datos: " + e.Message);
            }
            
        }

        private void btnAgregarControl_Click(object sender, EventArgs e)
        {
            txtNumeroCita.Text = "";
            txtFUA.Text = "";
            txtNumeroCita.Text = (dtgCitasMedicas.Rows.Count + 1).ToString();
            //btnGuardar.Enabled = true;
            if (dtgCitasMedicas.Rows.Count > 0)
            {
                dtpFechaCita.Value = Convert.ToDateTime(dtgCitasMedicas.Rows[dtgCitasMedicas.Rows.Count - 1].Cells[9].Value);
            }
            estado = "nuevo";
            dtpFechaCita.Focus();
        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            dtpProximaCita.MinDate  = dtpFechaCita.Value;
        }

        private void numPresionArterialS_ValueChanged(object sender, EventArgs e)
        {
            if ((numPresionArterialS.Value > limitePresionArterialS) || (numPresionArterialD.Value > limitePresionArterialD))
            {
                pbAlerta.Visible = true;
                lblAlerta.Visible = true;
                lblAlerta.Text = "Presion Arterial Alta";
                //this.BackColor = Color.DarkRed;
            }
            else
            {
                pbAlerta.Visible = false;
                lblAlerta.Visible = false;
                this.BackColor = Color.White;
            }
        }

        private void numPresionArterialD_ValueChanged(object sender, EventArgs e)
        {
            if ((numPresionArterialS.Value > limitePresionArterialS) || (numPresionArterialD.Value > limitePresionArterialD))
            {
                pbAlerta.Visible = true;
                lblAlerta.Visible = true;
                lblAlerta.Text = "Presion Arterial Alta";
                //this.BackColor = Color.DarkRed;
            }
            else
            {
                pbAlerta.Visible = false;
                lblAlerta.Visible = false;
                
                this.BackColor = Color.White;
            }
        }

        private void dtgCitasMedicas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgCitasMedicas.Rows[e.RowIndex].Cells[0].Value != null)
            {
                if ((Convert.ToInt16 (dtgCitasMedicas.Rows[e.RowIndex].Cells["colpresionarterialS"].Value) > limitePresionArterialS  ) || (Convert.ToInt16(dtgCitasMedicas.Rows[e.RowIndex].Cells["colpresionarterialD"].Value) > limitePresionArterialD))
                {
                    dtgCitasMedicas.Rows[e.RowIndex].Cells["colpresionarterial"].Style.BackColor = Color.Red;
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            rptListaPreNatal rListaPrenatal = new rptListaPreNatal();

            rListaPrenatal.SetDataSource(oCitaPrenatal.ListaCitasPreNatal());

            frmReporteListaPreNatal fReporteListaPrenatal = new frmReporteListaPreNatal();
            fReporteListaPrenatal.crystalReportViewer1.ReportSource = rListaPrenatal;
            fReporteListaPrenatal.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                oCitaPrenatal.HistoriaClinica.Idthistoriaclinica = HistoriaClinica;
                oCitaPrenatal.NumeroCita = Convert.ToInt16(txtNumeroCita.Text);
                oCitaPrenatal.EdadGestacional = Convert.ToInt16(numEdadGestacional.Value);
                oCitaPrenatal.FechaCitaPrenatal = dtpFechaCita.Value;
                oCitaPrenatal.Fua = txtFUA.Text;
                oCitaPrenatal.PresionArterialD = Convert.ToInt16(numPresionArterialD.Value);
                oCitaPrenatal.PresionArterialS = Convert.ToInt16(numPresionArterialS.Value);
                oCitaPrenatal.FechaProximaCitaPrenatal = dtpProximaCita.Value;
                oCitaPrenatal.SulfatoFerroso = Convert.ToInt16( nudSulfatoFerroso.Value  );
                oCitaPrenatal.Asistencia = 1;
                

                switch (estado)
                {
                    case "nuevo":
                        cSiguienteCodigo miSiguienteCodigo = new cSiguienteCodigo();
                        foreach (DataRow row in miSiguienteCodigo.SiguientesCodigo("tcitaprenatal", Establecimiento).Rows)
                        {
                            oCitaPrenatal.CodigoCitaPrenatal = row[0].ToString();
                        }
                        oCitaPrenatal.AgregarCita(oCitaPrenatal);
                        MessageBox.Show("Se agrego la cita Prenatal");
                        break;
                    case "modificar":
                        oCitaPrenatal.CodigoCitaPrenatal = dtgCitasMedicas.SelectedRows[0].Cells["colidtcitaprenatal"].Value.ToString(); 
                        oCitaPrenatal.ModificarCita(oCitaPrenatal);
                        
                        MessageBox.Show("Se Guardo la Cita Prenatal");
                        break;
                    default:
                        break;
                }

                
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgCitasMedicas_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgCitasMedicas.SelectedRows.Count > 0)
            {
                estado = "modificar";
                txtNumeroCita.Text = dtgCitasMedicas.SelectedRows[0].Cells["colnumerocita"].Value.ToString();
                dtpFechaCita.Value = Convert.ToDateTime(dtgCitasMedicas.SelectedRows[0].Cells["colfechacita"].Value);
                numEdadGestacional.Value = Convert.ToDecimal(dtgCitasMedicas.SelectedRows[0].Cells["coledadgestacional"].Value);
                numPresionArterialD.Value = Convert.ToDecimal(dtgCitasMedicas.SelectedRows[0].Cells["colPresionArterialD"].Value);
                numPresionArterialS.Value = Convert.ToDecimal(dtgCitasMedicas.SelectedRows[0].Cells["colpresionarterials"].Value);
                nudSulfatoFerroso.Value = Convert.ToDecimal(dtgCitasMedicas.SelectedRows[0].Cells["SULFATOFERROSO"].Value);
                txtFUA.Text = dtgCitasMedicas.SelectedRows[0].Cells["colFUA"].Value.ToString();
                dtpProximaCita.Value = Convert.ToDateTime(dtgCitasMedicas.SelectedRows[0].Cells["colFechaProximaCita"].Value);
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgCitasMedicas.SelectedRows.Count > 0)
            {
                if (estado == "modificar")
                {
                    if (MessageBox.Show("Desea Eliminar la Cita Prenatal", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        oCitaPrenatal.CodigoCitaPrenatal = dtgCitasMedicas.SelectedRows[0].Cells["colidtcitaprenatal"].Value.ToString();
                        oCitaPrenatal.EliminarCita(oCitaPrenatal);
                        MessageBox.Show("Se elimino la Cita Pre Natal");
                        CargarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona una Cita Pre Natal");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgCitasMedicas_Click(object sender, EventArgs e)
        {
            if (dtgCitasMedicas.Rows.Count > 0)
            {
                txtNumeroCita.Text = Convert.ToString(dtgCitasMedicas.SelectedRows[0].Cells["colnumerocita"].Value);
                dtpFechaCita.Value = Convert.ToDateTime(dtgCitasMedicas.SelectedRows[0].Cells["colfechacita"].Value);
                numEdadGestacional.Value = Convert.ToDecimal(dtgCitasMedicas.SelectedRows[0].Cells["coledadgestacional"].Value);
                numPresionArterialD.Value = Convert.ToDecimal(dtgCitasMedicas.SelectedRows[0].Cells["colPresionArterialD"].Value);
                numPresionArterialS.Value = Convert.ToDecimal(dtgCitasMedicas.SelectedRows[0].Cells["colpresionarterials"].Value);
                dtpProximaCita.Value = Convert.ToDateTime(dtgCitasMedicas.SelectedRows[0].Cells["colFechaProximaCita"].Value);
                txtFUA.Text = Convert.ToString(dtgCitasMedicas.SelectedRows[0].Cells["colFUA"].Value);
                nudSulfatoFerroso.Value = Convert.ToDecimal( dtgCitasMedicas.SelectedRows[0].Cells["SULFATOFERROSO"].Value );
                estado = "modificar";
            }
        }

        private void dtpFechaCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                numEdadGestacional.Focus();
        }

        private void numEdadGestacional_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                numPresionArterialS.Focus();
        }

        private void numPresionArterialS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                numPresionArterialD.Focus();
        }

        private void numPresionArterialD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                nudSulfatoFerroso.Focus();
        }

        private void nudSulfatoFerroso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                dtpProximaCita.Focus();
        }

        private void dtpProximaCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtFUA.Focus();
        }

        private void txtFUA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnGuardar.Focus();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
