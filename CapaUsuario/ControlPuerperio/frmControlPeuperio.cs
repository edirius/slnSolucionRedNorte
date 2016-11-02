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
    public partial class frmControlPeuperio : Form
    {
        int saccion;
        string sidtcontrolpeuperio = "";
        string sidthistoriaclinica = "";
        string sidtestablecimientosalud = "";

        public frmControlPeuperio()
        {
            InitializeComponent();
        }

        private void frmControlPeuperio_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                bool bOk = false;
                CapaDeNegocios.ControlPeuperio.cControlPeuperio miControlPeuperio= new CapaDeNegocios.ControlPeuperio.cControlPeuperio();
                miControlPeuperio.idtcontrolpeuperio = sidtcontrolpeuperio;
                miControlPeuperio.numero = Convert.ToInt32(txtNumero.Text);
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
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public void RecibirDatos(string pidtcontrolpeuperio, int pnumero, DateTime pfecha, int ppresionarterials, int ppresionarteriald, int palturauterino, string pfua, string pdetalle, string pidthistoriaclinica, string pidtestablecimientosalud, int paccion)
        {
            sidtcontrolpeuperio = pidtcontrolpeuperio;
            txtNumero.Text = Convert.ToString(pnumero);
            dtpFecha.Value = pfecha;
            numPresionArterialS.Value = ppresionarterials;
            numPresionArterialD.Value = ppresionarteriald;
            numAlturaUterino.Value = palturauterino;
            txtFUA.Text = pfua;
            txtDetalle.Text = pdetalle;
            sidthistoriaclinica = pidthistoriaclinica;
            sidtestablecimientosalud = pidtestablecimientosalud;
            saccion = paccion;
        }
    }
}
