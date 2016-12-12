using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDatos;
using DatosIniciales.Properties;

namespace DatosIniciales
{
    public partial class DatosIniciales : Form
    {
        string sidtobstetra = "";
        string sidtestablecimientosalud = "";

        CapaDeNegocios.Obstetra.cUsuario miUsuario = new CapaDeNegocios.Obstetra.cUsuario();
        CapaDeNegocios.Obstetra.cObstetra miObstetra = new CapaDeNegocios.Obstetra.cObstetra();
        CapaDeNegocios.EstablecimientoSalud.cEstablecimientoSalud miEstablecimiento = new CapaDeNegocios.EstablecimientoSalud.cEstablecimientoSalud();

        public DatosIniciales()
        {
            InitializeComponent();
        }

        private void DatosIniciales_Load(object sender, EventArgs e)
        {
            HacerConeccion();
            CargarEstablecimientoSalud();
            dtpFechaNacimiento.Value = DateTime.Today;
            txtDNI.Select();
            txtDNI.Focus();
        }

        private void HacerConeccion()
        {
            try
            {
                Conexion.IniciarSesion(Settings.Default.ConexionMySql, "bdcontrolgestantes", "root", "root");
                //MessageBox.Show(String.Format("{0}", "Se conecto exitosamente"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || txtApePaterno.Text == "" || txtApeMaterno.Text == "")
                {
                    MessageBox.Show("Debe llenar los campos de nombre, apellido paterno y materno.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtUsuario.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Debe tener un Usuario y Contraseña.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtDNI.Text.Length != 8)
                {
                    MessageBox.Show("El DNI ingresado no es correcto.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cboEstablecimientoSalud.Text == "")
                {
                    MessageBox.Show("Debe seleccionar un Establecimiento de Salud.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                miObstetra.idtobstetra = sidtobstetra;
                miObstetra.nombres = txtNombre.Text;
                miObstetra.apellidopaterno = txtApePaterno.Text;
                miObstetra.apellidomaterno = txtApeMaterno.Text;
                if (rbtMasculino.Checked == true) { miObstetra.sexo = "M"; }
                else if (rbtFemenino.Checked == true) { miObstetra.sexo = "F"; }
                miObstetra.dni = txtDNI.Text;
                miObstetra.fechanacimiento = dtpFechaNacimiento.Value;
                miObstetra.direccion = "";
                miObstetra.telefono = "";
                miObstetra.tituloprofesional = "";
                miObstetra.idtestablecimientosalud = sidtestablecimientosalud;
                miObstetra.usuario = txtUsuario.Text;
                miObstetra.password = miUsuario.ObtenerSHA1(txtPassword.Text);
                miObstetra.categoria = "ADMINISTRADOR";

                CapaDeNegocios.cSiguienteCodigo miSiguienteCodigo = new CapaDeNegocios.cSiguienteCodigo();
                foreach (DataRow row in miSiguienteCodigo.SiguientesCodigo("tobstetra", sidtestablecimientosalud).Rows)
                {
                    miObstetra.idtobstetra = row[0].ToString();
                }
                miObstetra.CrearObstetra(miObstetra);

                this.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void cboEstablecimientoSalud_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in miEstablecimiento.ListarEstablecimiento().Select("descripcion = '" + cboEstablecimientoSalud.Text + "'"))
            {
                sidtestablecimientosalud = row[1].ToString();
            }
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            if (txtDNI.Text.Length == 8)
            {
                foreach (DataRow row in miObstetra.ListarObstetra().Select("dni = '" + txtDNI.Text + "'"))
                {
                    MessageBox.Show("El DNI ingresado ya pertenece a otro Obstetra.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDNI.Text = "";
                    return;
                }
            }
        }

        private void CargarEstablecimientoSalud()
        {
            cboEstablecimientoSalud.Items.Clear();
            foreach (DataRow row in miEstablecimiento.ListarEstablecimiento().Select("microred <> ''", "descripcion"))
            {
                cboEstablecimientoSalud.Items.Add(row[3].ToString());
            }
            cboEstablecimientoSalud.SelectedIndex = -1;
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtDNI.Text.Length != 8)
                {
                    MessageBox.Show("El DNI ingresado no es correcto.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtNombre.Focus();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtApePaterno.Focus();
            }
        }

        private void txtApePaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtApeMaterno.Focus();
            }
        }

        private void txtApeMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rbtFemenino.Focus();
            }
        }

        private void rbtFemenino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtpFechaNacimiento.Focus();
            }
        }

        private void rbtMasculino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtpFechaNacimiento.Focus();
            }
        }

        private void dtpFechaNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtUsuario.Focus();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboEstablecimientoSalud.Focus();
            }
        }

        private void cboEstablecimientoSalud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAceptar.Focus();
            }
        }
    }
}
