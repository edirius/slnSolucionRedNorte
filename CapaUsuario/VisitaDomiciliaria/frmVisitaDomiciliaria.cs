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
    public partial class frmVisitaDomiciliaria : Form
    {
        int saccion;
        string sidtvisitadomiciliaria = "";
        string stipo = "";
        string sidthistoriaclinica = "";
        string sidtestablecimientosalud = "";

        public frmVisitaDomiciliaria()
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
                CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaGestante miVisitaDomiciliariaGestante = new CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaGestante();
                miVisitaDomiciliariaGestante.idtvisitadomiciliariagestante = sidtvisitadomiciliaria;
                miVisitaDomiciliariaGestante.fecha = dtpFecha.Value;
                miVisitaDomiciliariaGestante.motivo = cboMotivo.Text;
                miVisitaDomiciliariaGestante.fua = stipo;
                miVisitaDomiciliariaGestante.detalle = txtDetalle.Text;
                miVisitaDomiciliariaGestante.idthistoriaclinica = sidthistoriaclinica;

                if (saccion == 1)
                {
                    CapaDeNegocios.cSiguienteCodigo miSiguienteCodigo = new CapaDeNegocios.cSiguienteCodigo();
                    foreach (DataRow row in miSiguienteCodigo.SiguientesCodigo("tvisitadomiciliaria", sidtestablecimientosalud).Rows)
                    {
                        miVisitaDomiciliariaGestante.idtvisitadomiciliariagestante = row[0].ToString();
                    }
                    miVisitaDomiciliariaGestante.CrearVisitaDomiciliariaGestante(miVisitaDomiciliariaGestante);
                    bOk = true;
                }
                if (saccion == 2)
                {
                    miVisitaDomiciliariaGestante.ModificarVisitaDomiciliariaGestante(miVisitaDomiciliariaGestante);
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
