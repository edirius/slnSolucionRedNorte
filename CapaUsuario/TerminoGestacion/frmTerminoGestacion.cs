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
    public partial class frmTerminoGestacion : Form
    {
        int saccion;
        string sidtvisitadomiciliaria = "";
        string stipo = "";
        string sidthistoriaclinica = "";
        string sidtestablecimientosalud = "";

        public frmTerminoGestacion()
        {
            InitializeComponent();
        }

        private void frmVisitaDomiciliaria_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                bool bOk = false;
                CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaGestante miVisitaDomiciliaria = new CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaGestante();
                miVisitaDomiciliaria.idtvisitadomiciliariagestante = sidtvisitadomiciliaria;
                miVisitaDomiciliaria.fecha = dtpFecha.Value;
                miVisitaDomiciliaria.motivo = cboMotivo.Text;
                miVisitaDomiciliaria.detalle = txtDetalle.Text;
                miVisitaDomiciliaria.fua = stipo;
                miVisitaDomiciliaria.idthistoriaclinica = sidthistoriaclinica;

                if (saccion == 1)
                {
                    CapaDeNegocios.cSiguienteCodigo miSiguienteCodigo = new CapaDeNegocios.cSiguienteCodigo();
                    foreach (DataRow row in miSiguienteCodigo.SiguientesCodigo("tvisitadomiciliaria", sidtestablecimientosalud).Rows)
                    {
                        miVisitaDomiciliaria.idtvisitadomiciliariagestante = row[0].ToString();
                    }
                    miVisitaDomiciliaria.CrearVisitaDomiciliariaGestante(miVisitaDomiciliaria);
                    bOk = true;
                }
                if (saccion == 2)
                {
                    miVisitaDomiciliaria.ModificarVisitaDomiciliariaGestante(miVisitaDomiciliaria);
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

        public void RecibirDatos(string pidtvisitadomiciliaria, DateTime pfecha, string pmotivo, string pdetalle, string ptipo, string pidthistoriaclinica, string pidtestablecimientosalud, int paccion)
        {
            sidtvisitadomiciliaria = pidtvisitadomiciliaria;
            dtpFecha.Value = pfecha;
            cboMotivo.Text = pmotivo;
            txtDetalle.Text = pdetalle;
            stipo = ptipo;
            sidthistoriaclinica = pidthistoriaclinica;
            sidtestablecimientosalud = pidtestablecimientosalud;
            saccion = paccion;
        }
    }
}
