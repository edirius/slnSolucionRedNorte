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
        string sidtobstetra = "";

        CapaDeNegocios.ControlPeuperio.cControlPeuperio miControlPeuperio = new CapaDeNegocios.ControlPeuperio.cControlPeuperio();

        public frmMantenimientoControlPeuperio(string pidthistoriaclinica)
        {
            sidthistoriaclinica = pidthistoriaclinica;
            InitializeComponent();
        }

        private void frmVisitaDomiciliaria_Load(object sender, EventArgs e)
        {
            sidtobstetra = cVariables.v_idobstetra;
            sidtestablecimientosalud = cVariables.v_idestablecimientosalud;
            VerificarTerminoGestacion();
            CargarDatos();
            btnNuevo_Click(sender, e);
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
            dtpFecha.Select();
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
                miControlPeuperio.idtobstetra = sidtobstetra;
                if (saccion == 1)
                {
                    CapaDeNegocios.cSiguienteCodigo miSiguienteCodigo = new CapaDeNegocios.cSiguienteCodigo();
                    foreach (DataRow row in miSiguienteCodigo.SiguientesCodigo("tcontrolpeuperio", sidtestablecimientosalud).Rows)
                    {
                        miControlPeuperio.idtcontrolpeuperio = row[0].ToString();
                    }
                    miControlPeuperio.CrearControlPeuperio(miControlPeuperio);
                    MessageBox.Show("Control Puerperio registrado correctamente.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bOk = true;
                }
                if (saccion == 2)
                {
                    miControlPeuperio.ModificarControlPeuperio(miControlPeuperio);
                    MessageBox.Show("Control Puerperio modificado correctamente.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bOk = true;
                }
                if (bOk == true)
                {
                    //DialogResult = System.Windows.Forms.DialogResult.OK;
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
            if (dgvControlPeuperio.Rows.Count == 0)
            {
                btnNuevo_Click(sender, e);
            }
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
                sidtcontrolpeuperio = Convert.ToString(dgvControlPeuperio.Rows[e.RowIndex].Cells["idtcontrolpeuperio"].Value);
                snumerocontrol = Convert.ToInt32(dgvControlPeuperio.Rows[e.RowIndex].Cells["numero"].Value);
                txtNumero.Text = GenerarNumero(snumerocontrol) + " CONTROL";
                dtpFecha.Value = Convert.ToDateTime(dgvControlPeuperio.Rows[e.RowIndex].Cells["fecha"].Value);
                numPresionArterialS.Value = Convert.ToInt32(dgvControlPeuperio.Rows[e.RowIndex].Cells["presionarterials"].Value);
                numPresionArterialD.Value = Convert.ToInt32(dgvControlPeuperio.Rows[e.RowIndex].Cells["presionarteriald"].Value);
                numAlturaUterino.Value = Convert.ToInt32(dgvControlPeuperio.Rows[e.RowIndex].Cells[6].Value);
                txtFUA.Text = Convert.ToString(dgvControlPeuperio.Rows[e.RowIndex].Cells["fua"].Value);
                txtDetalle.Text = Convert.ToString(dgvControlPeuperio.Rows[e.RowIndex].Cells["detalle"].Value);
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
                    dgvControlPeuperio.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[5].ToString(), row[3].ToString(), row[4].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString());
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
                else
                {
                    foreach (DataRow row in miTerminoGestacion.ListarTerminoGestacion(sidthistoriaclinica).Rows)
                    {
                        dtpFecha.MinDate = Convert.ToDateTime(row[4]);
                    }
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
