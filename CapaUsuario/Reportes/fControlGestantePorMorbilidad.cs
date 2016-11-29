using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario.Reportes
{
    public partial class fControlGestantePorMorbilidad : Form
    {

        int cantidad_años = 0;
        int año = 0;
        int año_numero = 0;
        string morbilidad = "";
        int Ene, Feb, Mar, Abr, May, Jun, Jul, Ago, Sep, Oct, Nov, Dic, Año;
        public fControlGestantePorMorbilidad()
        {
            InitializeComponent();
        }

        private void fControlGestantePorMorbilidad_Load(object sender, EventArgs e)
        {
            CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();
            
            cbYear.DataSource = oHistoriaClinica.ListarYear();
            cbYear.ValueMember = "yyyy";
            cbYear.DisplayMember = "yyyy";

            cantidad_años = oHistoriaClinica.ListarYear().Rows.Count;

            establecer_combos_fecha_actual();
            rbExtrema.Checked = true;

            

            


        }

        private void establecer_combos_fecha_actual()
        {
            
            año_numero = Convert.ToInt16(DateTime.Now.Year.ToString("0000"));

            if (cantidad_años > 0)
            {
                //cbYear.SelectedItem = cbYear.Text[año_numero];
                cbYear.Text = año_numero.ToString();
                año = Convert.ToInt16(this.cbYear.GetItemText(this.cbYear.SelectedItem));
            }
        }

        private void buImprimir_Click(object sender, EventArgs e)
        {
            CapaDeNegocios.cGestanteMorbilidad oGM = new CapaDeNegocios.cGestanteMorbilidad();
            DataTable odtGM = new DataTable();
            fReporteMorbilidadExtrema fRME = new fReporteMorbilidadExtrema();

            if (!cbEnero.Checked && !cbFeb.Checked && !cbMarzo.Checked && !cbAbr.Checked && !cbMay.Checked && !cbAbr.Checked && !cbMay.Checked && !cbJun.Checked && !cbJul.Checked && !cbAgo.Checked && !cbSep.Checked && !cbOct.Checked && !cbNov.Checked && !cbDiciembre.Checked && cantidad_años==0 )
            {
                MessageBox.Show("Por favor hacer check a almenos un mes ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cargar_fechas();

                if (morbilidad == "Extrema")
                    odtGM = oGM.ReporteMorbilidadExtrema(Ene,Feb,Mar,Abr,May,Jun,Jul,Ago,Sep,Oct,Nov,Dic,Año);
                else
                    odtGM = oGM.ReporteMorbilidadPotencial(Ene, Feb, Mar, Abr, May, Jun, Jul, Ago, Sep, Oct, Nov, Dic, Año);

                if (odtGM.Rows.Count > 0)
                {
                    /*
                    rptListaGestantesControlPreNatal rListaGestantesControlPrenatal = new rptListaGestantesControlPreNatal();
                    dsListaGestantesControlPreNatal ds = new dsListaGestantesControlPreNatal();
                    ds.Tables.Add(oAlertas.ListarGestantesQueNoAcudenCita(codigoEstablecimiento));
                    rListaGestantesControlPrenatal.SetDataSource(oAlertas.ListarGestantesQueNoAcudenCita(codigoEstablecimiento));

                    frmReporteListaGestantesQueNoAcudenCitaPreNatal reporteListaGestantes = new frmReporteListaGestantesQueNoAcudenCitaPreNatal();
                    reporteListaGestantes.crystalReportViewer1.ReportSource = rListaGestantesControlPrenatal;
                    reporteListaGestantes.Show();
                    */

                    rptReporteMorbilidadExtrema rRME = new rptReporteMorbilidadExtrema();
                    rRME.SetDataSource(odtGM);

                    CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeader;
                    txtReportHeader = rRME.ReportDefinition.ReportObjects["txtTitulo"] as CrystalDecisions.CrystalReports.Engine.TextObject;
                    txtReportHeader.Text = "GESTANTES CON MORBILIDAD " + morbilidad.ToUpper() ;

                    fRME.crystalReportViewer1.ReportSource = rRME;

                    fRME.Show();

                }
                else {
                    MessageBox.Show("Morbilidad " + morbilidad + " sin gestantes o vacia.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void cargar_fechas() {
            if (cbEnero.Checked)
                Ene = 1;
            else
                Ene = -1;

            if (cbFeb.Checked)
                Feb = 2;
            else
                Feb = -1;

            if (cbMarzo.Checked)
                Mar = 3;
            else
                Mar = -1;

            if (cbAbr.Checked)
                Abr = 4;
            else
                Abr = -1;

            if (cbMay.Checked)
                May = 5;
            else
                May = -1;

            if (cbJun.Checked)
                Jun = 6;
            else
                Jun = -1;

            if (cbJul.Checked)
                Jul = 7;
            else
                Jul = -1;

            if (cbAgo.Checked)
                Ago = 8;
            else
                Ago = -1;

            if (cbSep.Checked)
                Sep = 9;
            else
                Sep = -1;

            if (cbOct.Checked)
                Oct = 10;
            else
                Oct = -1;

            if (cbNov.Checked)
                Nov = 11;
            else
                Nov = -1;

            if (cbDiciembre.Checked)
                Dic = 12;
            else
                Dic = -1;

            Año = Convert.ToInt16(cbYear.GetItemText(cbYear.SelectedItem));

            if (rbExtrema.Checked)
                morbilidad = "Extrema";
            else
                morbilidad = "Potencial";
        }

    }
}
