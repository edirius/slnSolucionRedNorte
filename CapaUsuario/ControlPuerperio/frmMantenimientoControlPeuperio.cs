using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario.ControlPeuperio
{
    public partial class frmMantenimientoControlPeuperio : Form
    {
        string sidtcontrolpeuperio = "";
        int snumero;
        DateTime sfecha;
        int spresionarterials;
        int spresionarteriald;
        int salturauterino;
        string sfua;
        string sdetalle;
        string sidthistoriaclinica;
        string sidtestablecimientosalud = "";
        string snombreobstetra = "";

        CapaDeNegocios.ControlPeuperio.cControlPeuperio miControlPeuperio = new CapaDeNegocios.ControlPeuperio.cControlPeuperio();

        public frmMantenimientoControlPeuperio(string pidestablecimientosalud, string pnombreobstetra)
        {
            sidtestablecimientosalud = pidestablecimientosalud;
            snombreobstetra = pnombreobstetra;
            InitializeComponent();
        }

        private void frmVisitaDomiciliaria_Load(object sender, EventArgs e)
        {
            sidthistoriaclinica = "E006H00002";
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmControlPeuperio fControlPeuperio = new frmControlPeuperio();
            fControlPeuperio.RecibirDatos("", 0, DateTime.Today, 120, 80, 1, "", "", sidthistoriaclinica, sidtestablecimientosalud, 1);
            if (fControlPeuperio.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmControlPeuperio fControlPeuperio = new frmControlPeuperio();
            fControlPeuperio.RecibirDatos(sidtcontrolpeuperio, snumero, sfecha, spresionarterials, spresionarteriald, salturauterino, sfua, sdetalle, sidthistoriaclinica, sidtestablecimientosalud, 2);
            if (fControlPeuperio.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (sidtcontrolpeuperio == "")
            {
                MessageBox.Show("No existena datos que se puedan Eliminar", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Está seguro que desea eliminar la Visita Domiciliaria.", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            miControlPeuperio.EliminarControlPeuperio(sidtcontrolpeuperio);
            CargarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvControlPeuperio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvControlPeuperio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                sidtcontrolpeuperio = Convert.ToString(dgvControlPeuperio.Rows[e.RowIndex].Cells["idtcontrolpeuperio"].Value);
                snumero = Convert.ToInt32(dgvControlPeuperio.Rows[e.RowIndex].Cells["numero"].Value);
                sfecha = Convert.ToDateTime(dgvControlPeuperio.Rows[e.RowIndex].Cells["fecha"].Value);
                spresionarterials = Convert.ToInt32(dgvControlPeuperio.Rows[e.RowIndex].Cells["presionarterials"].Value);
                spresionarteriald = Convert.ToInt32(dgvControlPeuperio.Rows[e.RowIndex].Cells["presionarteriald"].Value);
                salturauterino = Convert.ToInt32(dgvControlPeuperio.Rows[e.RowIndex].Cells["alturauterino"].Value);
                sfua = Convert.ToString(dgvControlPeuperio.Rows[e.RowIndex].Cells["fua"].Value);
                sdetalle = Convert.ToString(dgvControlPeuperio.Rows[e.RowIndex].Cells["detalle"].Value);
            }
        }

        private void dgvControlPeuperio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmControlPeuperio fControlPeuperio = new frmControlPeuperio();
            fControlPeuperio.RecibirDatos(sidtcontrolpeuperio, snumero, sfecha, spresionarterials, spresionarteriald, salturauterino, sfua, sdetalle, sidthistoriaclinica, sidtestablecimientosalud, 2);
            if (fControlPeuperio.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            try
            {
                dgvControlPeuperio.DataSource = miControlPeuperio.ListarControlPeuperio(sidthistoriaclinica);
                //DataTable oDataVisitaDomiciliaria = new DataTable();
                //oDataVisitaDomiciliaria = miVisitaDomiciliaria.ListarVisitaDomiciliaria(sidthistoriaclinica);
                //foreach (DataRow row in oDataVisitaDomiciliaria.Select("tipo = '" + stipo + "' "))
                //{
                //    dgvControlPeuperio.Rows.Add(row["idtvisitadomiciliaria"].ToString(), row["fecha"].ToString(), row["motivo"].ToString(), snombreobstetra, row["detalle"].ToString());
                //}
                if (dgvControlPeuperio.Rows.Count > 0)
                {
                    dgvControlPeuperio.Rows[0].Selected = true;
                    DataGridViewCellEventArgs ceo = new DataGridViewCellEventArgs(0, 0);
                    dgvControlPeuperio_CellClick(dgvControlPeuperio, ceo);
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
    }
}
