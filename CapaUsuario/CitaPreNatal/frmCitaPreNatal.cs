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


        public cCitaPrenatal oCitaPrenatal = new cCitaPrenatal();
        private int limitePresionArterialS = 140;
        private int limitePresionArterialD = 85;


        private void frmCitaPreNatal_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Establecimiento);
            CargarDatos();
            
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
                    dtpFechaCita.Value = Convert.ToDateTime(dtgCitasMedicas.Rows[dtgCitasMedicas.Rows.Count - 1].Cells["colFechaProximaCita"].Value);
                    dtpFechaCita.Enabled = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al cargar Datos: " + e.Message);
            }
            
        }

        private void btnAgregarControl_Click(object sender, EventArgs e)
        {
            try
            {
                cSiguienteCodigo miSiguienteCodigo = new cSiguienteCodigo();
                foreach (DataRow row in miSiguienteCodigo.SiguientesCodigo("tcitaprenatal", Establecimiento).Rows)
                {
                    oCitaPrenatal.CodigoCitaPrenatal = row[0].ToString();
                }
                oCitaPrenatal.HistoriaClinica.Idthistoriaclinica = HistoriaClinica;
                oCitaPrenatal.NumeroCita = Convert.ToInt16(txtNumeroCita.Text);
                oCitaPrenatal.EdadGestacional = Convert.ToInt16(numEdadGestacional.Value);
                oCitaPrenatal.FechaCitaPrenatal = dtpFechaCita.Value;
                oCitaPrenatal.Fua = txtFUA.Text;
                oCitaPrenatal.PresionArterialD = Convert.ToInt16(numPresionArterialD.Value);
                oCitaPrenatal.PresionArterialS = Convert.ToInt16(numPresionArterialS.Value);
                oCitaPrenatal.FechaProximaCitaPrenatal = dtpProximaCita.Value;
                oCitaPrenatal.AgregarCita(oCitaPrenatal);
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            dtpProximaCita.MinDate  = dtpFechaCita.Value;
        }

        private void numPresionArterialS_ValueChanged(object sender, EventArgs e)
        {
            if ((numPresionArterialS.Value > limitePresionArterialS) || (numPresionArterialD.Value > limitePresionArterialD))
            {
                this.BackColor = Color.DarkRed;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void numPresionArterialD_ValueChanged(object sender, EventArgs e)
        {
            if ((numPresionArterialS.Value > limitePresionArterialS) || (numPresionArterialD.Value > limitePresionArterialD))
            {
                this.BackColor = Color.DarkRed;
            }
            else
            {
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
    }
}
