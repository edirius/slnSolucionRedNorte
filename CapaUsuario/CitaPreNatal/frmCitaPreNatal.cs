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

        public DateTime Fecha_Registro
        { get; set; }

        public int Semana_Gestacional
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

        private void citar_mensual()
        {
            CapaDeNegocios.CitaPreNatal.cCitaPrenatal oCitaPrenatal = new CapaDeNegocios.CitaPreNatal.cCitaPrenatal();
            DataTable odtCitaPrenatal = new DataTable();
            int numero_meses_pronostico = 0;
            DateTime fecha_cita, fecha_prox_cita;
            int calculado_semana_gestacional = 0;
            /*calculando numero de cita*/
            numero_meses_pronostico = (int)  Convert.ToDecimal (28 - Semana_Gestacional)/4 ;
            calculado_semana_gestacional = edad_gestacional_citas;
            int inicio = (int) (calculado_semana_gestacional / 4);
            int fin = (int) ((28-Semana_Gestacional) / 4);
            fecha_cita = Fecha_Registro;
            fecha_prox_cita = Fecha_Registro.AddMonths(1);

            for (int i= inicio ; i <=fin; i++) {
                oCitaPrenatal.HistoriaClinica.Idthistoriaclinica = HistoriaClinica;
                odtCitaPrenatal = oCitaPrenatal.ListaCitasPreNatal();
                if (odtCitaPrenatal.Rows.Count > 0)
                    oCitaPrenatal.NumeroCita = Convert.ToInt16(odtCitaPrenatal.Rows[odtCitaPrenatal.Rows.Count - 1][2]) + 1;
                else
                    oCitaPrenatal.NumeroCita = 1;

                oCitaPrenatal.HistoriaClinica.Idthistoriaclinica = HistoriaClinica;
                oCitaPrenatal.EdadGestacional = edad_gestacional_citas;
                oCitaPrenatal.Fua = "";
                oCitaPrenatal.PresionArterialD = 60;
                oCitaPrenatal.PresionArterialS = 60;
                oCitaPrenatal.SulfatoFerroso = 30;
                /*calculando fecha cita y proxima cita*/
                oCitaPrenatal.FechaCitaPrenatal = fecha_cita;
                oCitaPrenatal.FechaProximaCitaPrenatal = fecha_prox_cita;

                if (i == fin-1){
                    Fecha_Registro = Fecha_Registro.AddMonths(1);
                    fecha_prox_cita = Fecha_Registro.AddDays(15);
                    edad_gestacional_citas += +4;
                }
                else {
                    Fecha_Registro = Fecha_Registro.AddMonths(1);
                    edad_gestacional_citas += +4;
                }
                if (i == fin )
                {
                    Fecha_Registro = Fecha_Registro.AddDays(15);
                    edad_gestacional_citas += +(int)(15) / 7;
                }


                fecha_cita = Fecha_Registro;
                fecha_prox_cita = Fecha_Registro.AddMonths(1);

                cSiguienteCodigo miSiguienteCodigo = new cSiguienteCodigo();
                foreach (DataRow row in miSiguienteCodigo.SiguientesCodigo("tcitaprenatal", Establecimiento).Rows)
                {
                    oCitaPrenatal.CodigoCitaPrenatal = row[0].ToString();
                }
                oCitaPrenatal.AgregarCita(oCitaPrenatal);

            }

             
            
        }

        private void citar_quincenal()
        {
            CapaDeNegocios.CitaPreNatal.cCitaPrenatal oCitaPrenatal = new CapaDeNegocios.CitaPreNatal.cCitaPrenatal();
            DataTable odtCitaPrenatal = new DataTable();
            int numero_quincenal_pronostico = 0;
            
            DateTime fecha_cita, fecha_prox_cita;
            int calculado_semana_gestacional = 0;
            /*calculando numero de cita*/

            numero_quincenal_pronostico = (int)Math.Ceiling(Convert.ToDecimal(28 - Semana_Gestacional) / 4);

            calculado_semana_gestacional = edad_gestacional_citas;

            int inicio = ((calculado_semana_gestacional * 7) / 15);
            int fin = (((36-Semana_Gestacional) * 7) / 15);

            for (int i = inicio; i <= fin; i++)
            {
                oCitaPrenatal.HistoriaClinica.Idthistoriaclinica = HistoriaClinica;
                odtCitaPrenatal = oCitaPrenatal.ListaCitasPreNatal();
                if (odtCitaPrenatal.Rows.Count > 0)
                    oCitaPrenatal.NumeroCita = Convert.ToInt16(odtCitaPrenatal.Rows[odtCitaPrenatal.Rows.Count - 1][2]) + 1;
                else
                    oCitaPrenatal.NumeroCita = 1;

                oCitaPrenatal.HistoriaClinica.Idthistoriaclinica = HistoriaClinica;

                oCitaPrenatal.EdadGestacional = edad_gestacional_citas;
                /*sumar a la edad gestacional una quincena*/
                
                oCitaPrenatal.Fua = "";
                oCitaPrenatal.PresionArterialD = 60;
                oCitaPrenatal.PresionArterialS = 60;
                oCitaPrenatal.SulfatoFerroso = 30;
                /*calculando fecha cita y proxima cita*/
                /*
                if (i == fin-1) { 
                    Fecha_Registro = Fecha_Registro.AddDays(15);
                    //edad_gestacional_citas += +1;
                    edad_gestacional_citas += +(int)(15) / 7;
                }
                else { 
                    Fecha_Registro = Fecha_Registro.AddDays(15);
                    edad_gestacional_citas += +(int)(15) / 7;
                }
                */

                //Fecha_Registro = Fecha_Registro.AddDays(15);
                //edad_gestacional_citas += +(int)(15) / 7;
                if (i == fin - 1)
                {
                    fecha_cita = Fecha_Registro;
                    fecha_prox_cita = Fecha_Registro.AddDays(7);
                }
                else {
                    fecha_cita = Fecha_Registro;
                    fecha_prox_cita = Fecha_Registro.AddDays(15);
                }

                if (i == fin)
                {
                    Fecha_Registro = Fecha_Registro.AddDays(7);
                    edad_gestacional_citas += +1;
                }


                oCitaPrenatal.FechaCitaPrenatal = fecha_cita ;
                oCitaPrenatal.FechaProximaCitaPrenatal = fecha_prox_cita;

                cSiguienteCodigo miSiguienteCodigo = new cSiguienteCodigo();
                foreach (DataRow row in miSiguienteCodigo.SiguientesCodigo("tcitaprenatal", Establecimiento).Rows)
                {
                    oCitaPrenatal.CodigoCitaPrenatal = row[0].ToString();
                }
                oCitaPrenatal.AgregarCita(oCitaPrenatal);

                 
            }
        }

        private void citar_semanal()
        {
            CapaDeNegocios.CitaPreNatal.cCitaPrenatal oCitaPrenatal = new CapaDeNegocios.CitaPreNatal.cCitaPrenatal();
            DataTable odtCitaPrenatal = new DataTable();
            int numero_quincenal_pronostico = 0;
            
            DateTime fecha_cita, fecha_prox_cita;
            int calculado_semana_gestacional = 0;
            /*calculando numero de cita*/

            

            numero_quincenal_pronostico = (int)Math.Ceiling(Convert.ToDecimal(28 - Semana_Gestacional) / 4);
            

            calculado_semana_gestacional = edad_gestacional_citas ;
            int inicio = calculado_semana_gestacional;
            int fin = 42-Semana_Gestacional;

            for (int i = inicio ; i <= fin; i++)
            {

                oCitaPrenatal.HistoriaClinica.Idthistoriaclinica = HistoriaClinica;
                odtCitaPrenatal = oCitaPrenatal.ListaCitasPreNatal();
                if (odtCitaPrenatal.Rows.Count > 0)
                    oCitaPrenatal.NumeroCita = Convert.ToInt16(odtCitaPrenatal.Rows[odtCitaPrenatal.Rows.Count - 1][2]) + 1;
                else
                    oCitaPrenatal.NumeroCita = 1;

                oCitaPrenatal.HistoriaClinica.Idthistoriaclinica = HistoriaClinica;

                oCitaPrenatal.EdadGestacional = edad_gestacional_citas;
                /*sumar a la edad gestacional una quincena*/
                edad_gestacional_citas += +1 ;
                oCitaPrenatal.Fua = "";
                oCitaPrenatal.PresionArterialD = 60;
                oCitaPrenatal.PresionArterialS = 60;
                oCitaPrenatal.SulfatoFerroso = 30;

                /*calculando fecha cita y proxima cita*/
                Fecha_Registro = Fecha_Registro.AddDays(7);
                fecha_cita = Fecha_Registro;
                fecha_prox_cita = Fecha_Registro.AddDays(7);

                oCitaPrenatal.FechaProximaCitaPrenatal = fecha_prox_cita;
                oCitaPrenatal.FechaCitaPrenatal = fecha_cita;

                cSiguienteCodigo miSiguienteCodigo = new cSiguienteCodigo();
                foreach (DataRow row in miSiguienteCodigo.SiguientesCodigo("tcitaprenatal", Establecimiento).Rows)
                {
                    oCitaPrenatal.CodigoCitaPrenatal = row[0].ToString();
                }
                oCitaPrenatal.AgregarCita(oCitaPrenatal);

                
            }
            oCitaPrenatal.HistoriaClinica.Idthistoriaclinica = HistoriaClinica;
            odtCitaPrenatal = oCitaPrenatal.ListaCitasPreNatal();
            dtgCitasMedicas.DataSource = odtCitaPrenatal;
        }

        private void realizar_atencion_citas_gestante() {

            DataTable odtCitaPrenatal = new DataTable();
            CapaDeNegocios.CitaPreNatal.cCitaPrenatal oCitaPrenatal = new CapaDeNegocios.CitaPreNatal.cCitaPrenatal();
            DateTime fecha_cita;
            //oCitaPrenatal.HistoriaClinica.Idthistoriaclinica = HistoriaClinica;
            if (dtgCitasMedicas.Rows.Count > 0)
            {
                /*Si primera cita es diferente a fecha de registro se procede a borrar todas las citas del control de gestante y se añaden nuevamente*/
                //fecha_cita = (DateTime) dtgCitasMedicas.Rows[0].Cells["FECHA CITA"].Value;
                fecha_cita = (DateTime)dtgCitasMedicas.Rows[0].Cells[3].Value;
                if (fecha_cita.ToString("dd/MM/yyyy") != Fecha_Registro.ToString("dd/MM/yyyy")) {
                    oCitaPrenatal.HistoriaClinica.Idthistoriaclinica = HistoriaClinica;
                    oCitaPrenatal.EliminarCitaXHistoriaClinica(oCitaPrenatal);

                    edad_gestacional_citas = Semana_Gestacional;
                    citar_mensual();
                    citar_quincenal();
                    citar_semanal();
                }

            }
            else {
                edad_gestacional_citas = Semana_Gestacional;
                citar_mensual();
                citar_quincenal();
                citar_semanal();
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
        private void CargarDatos()
        {
            try
            {
                
                oCitaPrenatal.HistoriaClinica.Idthistoriaclinica = HistoriaClinica;
                dtpProximaCita.MinDate = dtpFechaCita.Value; 
                dtgCitasMedicas.DataSource = oCitaPrenatal.ListaCitasPreNatal();

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
                txtAlerta.Visible = true;
                txtAlerta.Text = "Presion Arterial Alta";
                //this.BackColor = Color.DarkRed;
            }
            else
            {
                pbAlerta.Visible = false;
                txtAlerta.Visible = false;
                this.BackColor = Color.White;
            }
        }

        private void numPresionArterialD_ValueChanged(object sender, EventArgs e)
        {
            if ((numPresionArterialS.Value > limitePresionArterialS) || (numPresionArterialD.Value > limitePresionArterialD))
            {
                pbAlerta.Visible = true;
                txtAlerta.Visible = true;
                txtAlerta.Text = "Presion Arterial Alta";
                //this.BackColor = Color.DarkRed;
            }
            else
            {
                pbAlerta.Visible = false;
                txtAlerta.Visible = false;
                
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
    }
}
