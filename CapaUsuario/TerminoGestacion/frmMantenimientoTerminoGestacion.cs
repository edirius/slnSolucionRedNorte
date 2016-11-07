using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario.TerminoGestacion
{
    public partial class frmMantenimientoTerminoGestacion : Form
    {
        string sidtterminogestacion = "";
        string sidthistoriaclinica = "";
        string sidtestablecimientosalud = "";
        string snombreobstetra = "";

        CapaDeNegocios.TerminoGestacion.cTerminoGestacion miTerminoGestacion = new CapaDeNegocios.TerminoGestacion.cTerminoGestacion();

        public frmMantenimientoTerminoGestacion(string pidestablecimientosalud, string pnombreobstetra)
        {
            sidtestablecimientosalud = pidestablecimientosalud;
            snombreobstetra = pnombreobstetra;
            InitializeComponent();
        }

        private void frmVisitaDomiciliaria_Load(object sender, EventArgs e)
        {
            sidthistoriaclinica = "E006H00002";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatos()
        {
            //try
            //{
            //    dgvVisitaDomiciliaria.Rows.Clear();
            //    DataTable oDataVisitaDomiciliaria = new DataTable();
            //    oDataVisitaDomiciliaria = miVisitaDomiciliaria.ListarVisitaDomiciliariaGestante(sidthistoriaclinica);
            //    foreach (DataRow row in oDataVisitaDomiciliaria.Select("tipo = '" + stipo + "' "))
            //    {
            //        dgvVisitaDomiciliaria.Rows.Add(row["idtvisitadomiciliaria"].ToString(), row["fecha"].ToString(), row["motivo"].ToString(), snombreobstetra, row["detalle"].ToString());
            //    }
            //    if (dgvVisitaDomiciliaria.Rows.Count > 0)
            //    {
            //        dgvVisitaDomiciliaria.Rows[0].Selected = true;
            //        DataGridViewCellEventArgs ceo = new DataGridViewCellEventArgs(0, 0);
            //        dgvVisitaDomiciliaria_CellClick(dgvVisitaDomiciliaria, ceo);
            //    }
            //}
            //catch (Exception m)
            //{
            //    MessageBox.Show(m.Message);
            //}
        }

        private void rbtInstitucional_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtInstitucional.Checked == true)
            {
                gbParto.Enabled = true;
                gbEESS.Enabled = true;
            }
        }

        private void rbtDomiciliario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtDomiciliario.Checked == true)
            {
                gbParto.Enabled = true;
                gbEESS.Enabled = false;
            }
        }

        private void rbtAborto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtAborto.Checked == true)
            {
                gbParto.Enabled = false;
                gbEESS.Enabled = true;
            }
        }

        private void rbtInstitucional_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rbtUnico.Focus();
            }
        }

        private void rbtDomiciliario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rbtUnico.Focus();
            }
        }

        private void rbtAborto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rbtUnico.Focus();
            }
        }

        private void rbtUnico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtpFecha.Focus();
            }
        }

        private void rbtMultiple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtpFecha.Focus();
            }
        }
    }
}
