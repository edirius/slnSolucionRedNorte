using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoreo.Reportes
{
    public partial class frmReporteObstetras : Form
    {
        string sidtmicrored = "";
        string sidtestablecimientosalud = "";

        public frmReporteObstetras()
        {
            InitializeComponent();
        }

        private void frmReporteObstetras_Load(object sender, EventArgs e)
        {
            CargarMicroRED();
        }

        private void cboMicroRED_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMicroRED.Text != "System.Data.DataRowView" && cboMicroRED.ValueMember != "")
            {
                sidtmicrored = cboMicroRED.SelectedValue.ToString();
                CargarEstablecimientoSalud();
            }
        }

        private void cboEstablecimientoSalud_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEstablecimientoSalud.Text != "System.Data.DataRowView" && cboEstablecimientoSalud.ValueMember != "")
            {
                sidtestablecimientosalud = cboEstablecimientoSalud.SelectedValue.ToString();
                CargarObstetras();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void CargarMicroRED()
        {
            try
            {
                CapaDeNegocios.EstablecimientoSalud.cMicrored miMicrored = new CapaDeNegocios.EstablecimientoSalud.cMicrored();
                cboMicroRED.DataSource = miMicrored.ListarMicrored();
                cboMicroRED.ValueMember = "idtmicrored";
                cboMicroRED.DisplayMember = "microred";
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void CargarEstablecimientoSalud()
        {
            try
            {
                CapaDeNegocios.EstablecimientoSalud.cEstablecimientoSalud miEstablecimiento = new CapaDeNegocios.EstablecimientoSalud.cEstablecimientoSalud();
                DataTable oDataEstablecimientoSalud = new DataTable();
                oDataEstablecimientoSalud = miEstablecimiento.ListarEstablecimiento();
                oDataEstablecimientoSalud.DefaultView.RowFilter = ("Microred = '" + cboMicroRED.Text + "'");
                cboEstablecimientoSalud.DataSource = oDataEstablecimientoSalud.DefaultView;
                cboEstablecimientoSalud.ValueMember = "Codigo";
                cboEstablecimientoSalud.DisplayMember = "Descripcion";
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void CargarObstetras()
        {
            try
            {
                CapaDeNegocios.Reportes.cReporteObstetra miObstetra = new CapaDeNegocios.Reportes.cReporteObstetra();
                DataTable oDataObstetra= new DataTable();
                oDataObstetra = miObstetra.ReporteObstetra();
                oDataObstetra.DefaultView.RowFilter = ("idtestablecimientosalud = '" + sidtestablecimientosalud + "'");
                dgvObstetra.DataSource = oDataObstetra.DefaultView;
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
    }
}
