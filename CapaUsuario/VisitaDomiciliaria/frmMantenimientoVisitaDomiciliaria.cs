using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario.VisitaDomiciliaria
{
    public partial class frmMantenimientoVisitaDomiciliaria : Form
    {
        string sidtvisitadomiciliaria = "";
        DateTime sfecha;
        string smotivo = "";
        string sdetalle = "";
        string stipo = "";
        string sidthistoriaclinica = "";
        string sidtestablecimientosalud = "";
        string snombreobstetra = "";

        CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliaria miVisitaDomiciliaria = new CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliaria();

        public frmMantenimientoVisitaDomiciliaria(string pidestablecimientosalud, string pnombreobstetra)
        {
            sidtestablecimientosalud = pidestablecimientosalud;
            snombreobstetra = pnombreobstetra;
            InitializeComponent();
        }

        private void frmVisitaDomiciliaria_Load(object sender, EventArgs e)
        {
            sidthistoriaclinica = "E006H00002";
            tabControl1_SelectedIndexChanged(sender, e);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmVisitaDomiciliaria fVisitaDomiciliaria = new frmVisitaDomiciliaria();
            fVisitaDomiciliaria.RecibirDatos("", DateTime.Today, "", "", stipo, sidthistoriaclinica, sidtestablecimientosalud, 1);
            if (fVisitaDomiciliaria.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                this.tabPage1.Controls.Add(this.dgvVisitaDomiciliaria);
                stipo = "GESTANTE";
            }
            else
            {
                this.tabPage2.Controls.Add(this.dgvVisitaDomiciliaria);
                stipo = "PUERPERIA/R.NACIDO";
            }
            CargarDatos();
        }

        private void dgvVisitaDomiciliaria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvVisitaDomiciliaria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sidtvisitadomiciliaria = Convert.ToString(dgvVisitaDomiciliaria.Rows[e.RowIndex].Cells["idtvisitadomiciliaria"].Value);
            sfecha = Convert.ToDateTime(dgvVisitaDomiciliaria.Rows[e.RowIndex].Cells["fecha"].Value);
            smotivo = Convert.ToString(dgvVisitaDomiciliaria.Rows[e.RowIndex].Cells["motivo"].Value);
            sdetalle = Convert.ToString(dgvVisitaDomiciliaria.Rows[e.RowIndex].Cells["detalle"].Value);
        }

        private void dgvVisitaDomiciliaria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmVisitaDomiciliaria fVisitaDomiciliaria = new frmVisitaDomiciliaria();
            fVisitaDomiciliaria.RecibirDatos(sidtvisitadomiciliaria, sfecha, smotivo, sdetalle, stipo, sidthistoriaclinica, sidtestablecimientosalud, 2);
            if (fVisitaDomiciliaria.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            try
            {
                dgvVisitaDomiciliaria.Rows.Clear();
                DataTable oDataVisitaDomiciliaria = new DataTable();
                oDataVisitaDomiciliaria = miVisitaDomiciliaria.ListarVisitaDomiciliaria(sidthistoriaclinica);
                foreach (DataRow row in oDataVisitaDomiciliaria.Select("tipo = '" + stipo + "' "))
                {
                    dgvVisitaDomiciliaria.Rows.Add("", row["idtvisitadomiciliaria"].ToString(), row["fecha"].ToString(), row["motivo"].ToString(), snombreobstetra, row["detalle"].ToString());
                }
                if (dgvVisitaDomiciliaria.Rows.Count > 0)
                {
                    dgvVisitaDomiciliaria.Rows[0].Selected = true;
                    DataGridViewCellEventArgs ceo = new DataGridViewCellEventArgs(0, 0);
                    dgvVisitaDomiciliaria_CellClick(dgvVisitaDomiciliaria, ceo);
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
    }
}
