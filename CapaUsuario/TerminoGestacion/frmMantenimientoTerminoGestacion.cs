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
        int saccion = 1;
        string sidtterminogestacion = "";
        string sidthistoriaclinica = "";
        string sidtestablecimientosalud = "";
        string snombreobstetra = "";

        CapaDeNegocios.TerminoGestacion.cTerminoGestacion miTerminoGestacion = new CapaDeNegocios.TerminoGestacion.cTerminoGestacion();

        public frmMantenimientoTerminoGestacion(string pidthistoriaclinica)
        {
            sidthistoriaclinica = pidthistoriaclinica;
            InitializeComponent();
        }

        private void frmVisitaDomiciliaria_Load(object sender, EventArgs e)
        {
            snombreobstetra = cVariables.v_nombreobstetra;
            sidtestablecimientosalud = cVariables.v_idestablecimientosalud;
            CargarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool bOk = false;
                miTerminoGestacion.idtterminogestacion = sidtterminogestacion;
                if (rbtNormal.Checked == true) { miTerminoGestacion.gestacion = rbtNormal.Text; }
                else if (rbtAborto.Checked == true) { miTerminoGestacion.gestacion = rbtAborto.Text; }
                if (rbtInstitucion.Checked == true) { miTerminoGestacion.lugar = rbtInstitucion.Text; }
                else if (rbtDomicilio.Checked == true) { miTerminoGestacion.lugar = rbtDomicilio.Text; }
                if (rbtUnico.Checked == true) { miTerminoGestacion.reciennacido = rbtUnico.Text; }
                else if (rbtMultiple.Checked == true) { miTerminoGestacion.reciennacido = rbtMultiple.Text; }
                miTerminoGestacion.fecha = dtpFecha.Value;
                miTerminoGestacion.persona = txtPersona.Text;
                if (rbtEutosico.Checked == false && rbtDistocico.Checked == false)
                { miTerminoGestacion.tipoparto = ""; }
                else
                {
                    if (rbtEutosico.Checked == true) { miTerminoGestacion.tipoparto = rbtEutosico.Text; }
                    else if (rbtDistocico.Checked == true) { miTerminoGestacion.tipoparto = rbtDistocico.Text; }
                }
                miTerminoGestacion.modoparto = cboTipoParto.Text;
                if (rbtAlumbramientoSI.Checked == false && rbtAlumbramientoNO.Checked == false)
                { miTerminoGestacion.manejoalumbramiento = ""; }
                else
                {
                    if (rbtAlumbramientoSI.Checked == true) { miTerminoGestacion.manejoalumbramiento = rbtAlumbramientoSI.Text; }
                    else if (rbtAlumbramientoNO.Checked == true) { miTerminoGestacion.manejoalumbramiento = rbtAlumbramientoNO.Text; }
                }
                miTerminoGestacion.tipoinstitucion = cboHospital.Text;
                miTerminoGestacion.nombreinstitucion = txtHospital.Text;
                miTerminoGestacion.idthistoriaclinica = sidthistoriaclinica;
                if (saccion == 1)
                {
                    CapaDeNegocios.cSiguienteCodigo miSiguienteCodigo = new CapaDeNegocios.cSiguienteCodigo();
                    foreach (DataRow row in miSiguienteCodigo.SiguientesCodigo("tterminogestacion", sidtestablecimientosalud).Rows)
                    {
                        miTerminoGestacion.idtterminogestacion = row[0].ToString();
                    }
                    miTerminoGestacion.CrearTerminoGestacion(miTerminoGestacion);
                    bOk = true;
                }
                if (saccion == 2)
                {
                    miTerminoGestacion.ModificarTerminoGestacion(miTerminoGestacion);
                    bOk = true;
                }
                if (bOk == true)
                {
                    if (saccion == 1)
                    {
                        MessageBox.Show("Termino de Gestación registrado correctamente.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (saccion == 2)
                    {
                        MessageBox.Show("Termino de Gestación modificado correctamente.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatos()
        {
            try
            {
                int contador = 0;
                foreach (DataRow row in miTerminoGestacion.ListarTerminoGestacion(sidthistoriaclinica).Rows)
                {
                    contador += 1;
                    saccion = 2;
                    sidtterminogestacion = row["ID TERMINO GESTACION"].ToString();
                    if (row["GESTACION"].ToString() == "Normal") { rbtNormal.Checked = true; }
                    else if (row["GESTACION"].ToString() == "Aborto") { rbtAborto.Checked = true; }
                    if (row["LUGAR"].ToString() == "Institucion") { rbtInstitucion.Checked = true; }
                    else if (row["LUGAR"].ToString() == "Domicilio") { rbtDomicilio.Checked = true; }
                    if (row["RECIEN NACIDO"].ToString() == "Unico") { rbtUnico.Checked = true; }
                    else if (row["RECIEN NACIDO"].ToString() == "Multiple") { rbtMultiple.Checked = true; }
                    dtpFecha.Value = Convert.ToDateTime(row["FECHA"]);
                    txtPersona.Text = row["PERSONA"].ToString();
                    if (row["TIPO PARTO"].ToString() == "") { rbtEutosico.Checked = false; rbtDistocico.Checked = false; }
                    else if (row["TIPO PARTO"].ToString() == "EUTOCICO") { rbtEutosico.Checked = true; }
                    else if (row["TIPO PARTO"].ToString() == "DISTOCICO") { rbtDistocico.Checked = true; }
                    if (row["MODO PARTO"].ToString() == "") { cboTipoParto.SelectedIndex = -1; }
                    else { cboTipoParto.Text = row["MODO PARTO"].ToString(); }
                    if (row["MANEJO ALUMBRAMIENTO"].ToString() == "") { rbtAlumbramientoSI.Checked = false; rbtAlumbramientoNO.Checked = false; }
                    else if (row["MANEJO ALUMBRAMIENTO"].ToString() == "SI") { rbtAlumbramientoSI.Checked = true; }
                    else if (row["MANEJO ALUMBRAMIENTO"].ToString() == "NO") { rbtAlumbramientoNO.Checked = true; }
                    if (row["TIPO INSTITUCION"].ToString() == "") { cboHospital.SelectedIndex = -1; }
                    else { cboHospital.Text = row["TIPO INSTITUCION"].ToString(); }
                    txtHospital.Text = row["NOMBRE INSTITUCION"].ToString();
                    sidthistoriaclinica = row["ID HISTORIA CLINICA"].ToString();
                }
                if (contador == 0)
                {
                    saccion = 1;
                }
                else
                {
                    Inhabilitar();
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void Habilitar()
        {
            if (rbtNormal.Checked == true)
            {
                txtPersona.Enabled = true;
                rbtDistocico.Checked = false;
                cboTipoParto.SelectedIndex = -1;
                rbtAlumbramientoNO.Checked = false;
                if (rbtInstitucion.Checked == true)
                {
                    rbtEutosico.Checked = true;
                    rbtAlumbramientoSI.Checked = true;
                    gbParto.Enabled = true;
                    gbEESS.Enabled = true;
                }
                if (rbtDomicilio.Checked == true)
                {
                    rbtEutosico.Checked = false;
                    rbtAlumbramientoSI.Checked = false;
                    cboHospital.SelectedIndex = -1;
                    txtHospital.Text = "";
                    gbParto.Enabled = false;
                    gbEESS.Enabled = false;
                }
            }
            else if (rbtAborto.Checked == true)
            {
                txtPersona.Text = "";
                txtPersona.Enabled = false;
                rbtEutosico.Checked = false;
                rbtDistocico.Checked = false;
                cboTipoParto.SelectedIndex = -1;
                rbtAlumbramientoSI.Checked = false;
                rbtAlumbramientoNO.Checked = false;
                if (rbtInstitucion.Checked == true)
                {
                    gbParto.Enabled = false;
                    gbEESS.Enabled = true;
                }
                if (rbtDomicilio.Checked == true)
                {
                    cboHospital.SelectedIndex = -1;
                    txtHospital.Text = "";
                    gbParto.Enabled = false;
                    gbEESS.Enabled = false;
                }
            }
        }

        private void Inhabilitar()
        {
            rbtNormal.Enabled = false;
            rbtAborto.Enabled = false;
            rbtInstitucion.Enabled = false;
            rbtDomicilio.Enabled = false;
            rbtUnico.Enabled = false;
            rbtMultiple.Enabled = false;
            dtpFecha.Enabled = false;
            txtPersona.Enabled = false;
            rbtEutosico.Enabled = false;
            rbtDistocico.Enabled = false;
            cboTipoParto.Enabled = false;
            rbtAlumbramientoSI.Enabled = false;
            rbtAlumbramientoNO.Enabled = false;
            cboHospital.Enabled = false;
            txtHospital.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void rbtNormal_CheckedChanged(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void rbtAborto_CheckedChanged(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void rbtInstitucional_CheckedChanged(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void rbtDomiciliario_CheckedChanged(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void rbtEutosico_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtEutosico.Checked == true)
            {
                cboTipoParto.Items.Clear();
                cboTipoParto.Items.Add("VERTICAL");
                cboTipoParto.Items.Add("HORIZONTAL");
                cboTipoParto.Enabled = true;
            }
        }

        private void rbtDistocico_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtDistocico.Checked == true)
            {
                cboTipoParto.Items.Clear();
                cboTipoParto.Items.Add("CESARIA");
                cboTipoParto.Text = "CESARIA";
                cboTipoParto.Enabled = false;
            }
        }

        private void cboHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHospital.Text == "HOSPITAL")
            {
                label2.Text = "Nombre del Hospital :";
            }
            else
            {
                label2.Text = "Nombre del EE. de Salud :";
            }
        }

        private void rbtNormal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rbtInstitucion.Focus();
            }
        }

        private void rbtAborto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rbtInstitucion.Focus();
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
