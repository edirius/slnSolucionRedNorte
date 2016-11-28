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
    public partial class frmReporteEstablecimientoSalud : Form
    {
        string sidtmicrored = "";
        string sidtestablecimientosalud = "";

        public frmReporteEstablecimientoSalud()
        {
            InitializeComponent();
        }

        private void frmReporteEstablecimientoSalud_Load(object sender, EventArgs e)
        {
            cboMes.Text = Convert.ToString(DateTime.Now.ToString("MMMM"));
            CargarAños();
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

        private void dgvEstablecimientoSalud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                sidtestablecimientosalud = Convert.ToString(dgvEstablecimientoSalud.Rows[e.RowIndex].Cells["idtestablecimientosalud"].Value);
            }
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
                //oDataEstablecimientoSalud.DefaultView.RowFilter = ("Microred = '" + cboMicroRED.Text + "'");
                //dgvEstablecimientoSalud.DataSource = oDataEstablecimientoSalud.DefaultView;

                dgvEstablecimientoSalud.Rows.Clear();
                foreach (DataRow row in oDataEstablecimientoSalud.Select("microred = '" + cboMicroRED.Text + "'"))
                {
                    dgvEstablecimientoSalud.Rows.Add(row["codigo"].ToString(), row["descripcion"].ToString(), row["direccion"].ToString());
                }
                if (dgvEstablecimientoSalud.Rows.Count > 0)
                {
                    dgvEstablecimientoSalud.ClearSelection();
                    dgvEstablecimientoSalud.Rows[0].Selected = true;
                    DataGridViewCellEventArgs ceo = new DataGridViewCellEventArgs(0, 0);
                    dgvEstablecimientoSalud_CellClick(dgvEstablecimientoSalud, ceo);
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void CargarAños()
        {
            for (int i = DateTime.Now.Year; i >= 2000; i--)
            {
                cboAño.Items.Add(i);
            }
            cboAño.Text = Convert.ToString(DateTime.Now.Year);
        }
    }
}
