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
        int saccion = 0;
        int snumerocontrol = 0;
        string sidtcontrolpeuperio = "";
        string sidthistoriaclinica = "";
        string sidtestablecimientosalud = "";
        string snombreobstetra = "";

        CapaDeNegocios.ControlPeuperio.cControlPeuperio miControlPeuperio = new CapaDeNegocios.ControlPeuperio.cControlPeuperio();

        public frmMantenimientoControlPeuperio(string pidthistoriaclinica)
        {
            sidthistoriaclinica = pidthistoriaclinica;
            InitializeComponent();
        }

        private void frmVisitaDomiciliaria_Load(object sender, EventArgs e)
        {
            snombreobstetra = cVariables.v_nombreobstetra;
            sidtestablecimientosalud = cVariables.v_idestablecimientosalud;
            VerificarTerminoGestacion();
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            saccion = 1;
            sidtcontrolpeuperio = "";
            if (dgvControlPeuperio.Rows.Count > 0)
            {
                snumerocontrol = Convert.ToInt32(dgvControlPeuperio.Rows[dgvControlPeuperio.RowCount - 1].Cells["NUMERO"].Value) + 1;
            }
            else
            {
                snumerocontrol = 1;
            }
            txtNumero.Text = GenerarNumero(snumerocontrol) + " CONTROL";
            dtpFecha.Value = DateTime.Today;
            numPresionArterialS.Value = 120;
            numPresionArterialD.Value = 80;
            numAlturaUterino.Value = 0;
            txtFUA.Text = "";
            txtDetalle.Text = "";
            dtpFecha.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool bOk = false;
                miControlPeuperio.idtcontrolpeuperio = sidtcontrolpeuperio;
                miControlPeuperio.numero = snumerocontrol;
                miControlPeuperio.fecha = dtpFecha.Value;
                miControlPeuperio.presionarterials = Convert.ToInt32(numPresionArterialS.Value);
                miControlPeuperio.presionarteriald = Convert.ToInt32(numPresionArterialD.Value);
                miControlPeuperio.alturauterino = Convert.ToInt32(numAlturaUterino.Value);
                miControlPeuperio.fua = txtFUA.Text;
                miControlPeuperio.detalle = txtDetalle.Text;
                miControlPeuperio.idthistoriaclinica = sidthistoriaclinica;
                if (saccion == 1)
                {
                    CapaDeNegocios.cSiguienteCodigo miSiguienteCodigo = new CapaDeNegocios.cSiguienteCodigo();
                    foreach (DataRow row in miSiguienteCodigo.SiguientesCodigo("tcontrolpeuperio", sidtestablecimientosalud).Rows)
                    {
                        miControlPeuperio.idtcontrolpeuperio = row[0].ToString();
                    }
                    miControlPeuperio.CrearControlPeuperio(miControlPeuperio);
                    bOk = true;
                }
                if (saccion == 2)
                {
                    miControlPeuperio.ModificarControlPeuperio(miControlPeuperio);
                    bOk = true;
                }
                if (bOk == true)
                {
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("No se puede registrar estos datos", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CargarDatos();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
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

        private void dtpFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                numPresionArterialS.Focus();
            }
        }

        private void numPresionArterialS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                numPresionArterialD.Focus();
            }
        }

        private void numPresionArterialD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                numAlturaUterino.Focus();
            }
        }

        private void numAlturaUterino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtFUA.Focus();
            }
        }

        private void txtFUA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDetalle.Focus();
            }
        }

        private void txtDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnGuardar.Focus();
            }
        }

        private void dgvControlPeuperio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                saccion = 2;
                sidtcontrolpeuperio = Convert.ToString(dgvControlPeuperio.Rows[e.RowIndex].Cells[0].Value);
                snumerocontrol = Convert.ToInt32(dgvControlPeuperio.Rows[e.RowIndex].Cells["NUMERO"].Value);
                txtNumero.Text = GenerarNumero(snumerocontrol) + " CONTROL";
                dtpFecha.Value = Convert.ToDateTime(dgvControlPeuperio.Rows[e.RowIndex].Cells["FECHA"].Value);
                numPresionArterialS.Value = Convert.ToInt32(dgvControlPeuperio.Rows[e.RowIndex].Cells[4].Value);
                numPresionArterialD.Value = Convert.ToInt32(dgvControlPeuperio.Rows[e.RowIndex].Cells[5].Value);
                numAlturaUterino.Value = Convert.ToInt32(dgvControlPeuperio.Rows[e.RowIndex].Cells[6].Value);
                txtFUA.Text = Convert.ToString(dgvControlPeuperio.Rows[e.RowIndex].Cells[7].Value);
                txtDetalle.Text = Convert.ToString(dgvControlPeuperio.Rows[e.RowIndex].Cells[8].Value);
                dtpFecha.Focus();
            }
        }

        private void CargarDatos()
        {
            try
            {
                dgvControlPeuperio.Rows.Clear();
                foreach (DataRow row in miControlPeuperio.ListarControlPeuperio(sidthistoriaclinica).Rows)
                {
                    dgvControlPeuperio.Rows.Add(row["ID CONTROL PEUPERIO"].ToString(), row["NUMERO"].ToString(), row["FECHA"].ToString(), row["PRESION ARTERIAL S"].ToString()+"/"+row["PRESION ARTERIAL D"].ToString(), row["PRESION ARTERIAL S"].ToString(), row["PRESION ARTERIAL D"].ToString(), row["ALTURA UTERINO"].ToString(), row["FUA"].ToString(), row["DETALLE"].ToString());
                }
                if (dgvControlPeuperio.Rows.Count > 0)
                {
                    dgvControlPeuperio.ClearSelection();
                    dgvControlPeuperio.Rows[dgvControlPeuperio.RowCount - 1].Selected = true;
                    DataGridViewCellEventArgs ceo = new DataGridViewCellEventArgs(0, dgvControlPeuperio.RowCount - 1);
                    dgvControlPeuperio_CellClick(dgvControlPeuperio, ceo);
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void VerificarTerminoGestacion()
        {
            try
            {
                CapaDeNegocios.TerminoGestacion.cTerminoGestacion miTerminoGestacion = new CapaDeNegocios.TerminoGestacion.cTerminoGestacion();
                if (miTerminoGestacion.ListarTerminoGestacion(sidthistoriaclinica).Rows.Count == 0)
                {
                    MessageBox.Show("La paciente no tiene registro de Termino de Gestación.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private string GenerarNumero(int N)
        {
            String[] Unidad = { "", "PRIMER", "SEGUNDO", "TERCER",
            "CUARTO", "QUINTO", "SEXTO", "SEPTIMO", "OCTAVO",
            "NOVENO" };
            String[] Decena = { "", "DECIMO", "VIGESIMO", "TRIGESIMO",
            "CUADRAGESIMO", "QUINCUAGESIMO", "SEXAGESIMO",
            "SEPTUAGESIMO", "OCTOGESIMO", "NONAGESIMO" };
            String[] Centena = {"", "centesimo", "ducentesimo",
            "tricentesimo", " cuadringentesimo", " quingentesimo",
            " sexcentesimo", " septingentesimo", " octingentesimo",
            " noningentesimo"};

            string Num = "";
            int u = N % 10;
            int d = (N / 10) % 10;
            int c = N / 100;
            if (N >= 100)
            {
                Num = Centena[c] + " " + Decena[d] + " " + Unidad[u];
            }
            else
            {
                if (N >= 10)
                {
                    Num = Decena[d] + " " + Unidad[u];
                }
                else
                {
                    Num = Unidad[N];
                }
            }
            return Num;
        }
    }
}
