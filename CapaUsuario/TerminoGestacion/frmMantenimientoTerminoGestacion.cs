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
        string sidtvisitadomiciliaria = "";
        DateTime sfecha;
        string smotivo = "";
        string sdetalle = "";
        string stipo = "";
        string sidthistoriaclinica = "";
        string sidtestablecimientosalud = "";
        string snombreobstetra = "";

        CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaGestante miVisitaDomiciliaria = new CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaGestante();

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
    }
}
