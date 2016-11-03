using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocios;

namespace CapaUsuario.EstablecimientoSalud
{
    public partial class frmEstablecimientoSalud : Form
    {
        CapaDeNegocios.EstablecimientoSalud.cEstablecimientoSalud  miEstablecimiento = new CapaDeNegocios.EstablecimientoSalud.cEstablecimientoSalud();
        CapaDeNegocios.EstablecimientoSalud.cMicrored miMicrored = new CapaDeNegocios.EstablecimientoSalud.cMicrored();
        DataTable Tabla = new DataTable();
        string mensaje = "";
        string respuesta = "";

        public frmEstablecimientoSalud()
        {
            InitializeComponent();
            ConfiguracionInicial();
        }

        private void frmEstablecimientoSalud_Load(object sender, EventArgs e)
        {

        }
        public void CargarCombo()
        {
            cbMicrored.ValueMember = "idtmicrored";
            cbMicrored.DisplayMember = "microred";
            cbMicrored.DataSource = miMicrored.ListarMicrored();
        }
        public void Nuevo()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtDireccion.Text = "";
            txtRenaes.Text = "";
            txtDescripcion.Enabled = true;
            txtDescripcion.Focus();
            txtDireccion.Enabled = true;
            txtRenaes.Enabled = true;
            cbMicrored.Enabled = true;
            btnInsertar.Enabled = true;
            cbCampo.Enabled = true;
            CargarCombo();
            //Tabla = miEstablecimiento.SiguienteCodigo();
            //txtCodigo.Text = Tabla.Rows[0][0].ToString();
        }
        private void ConfiguracionInicial()
        {
            //Tabla = miEstablecimiento.SiguienteCodigo();
            //txtCodigo.Text = Tabla.Rows[0][0].ToString();
            dgvListarEstablecimiento.DataSource = miEstablecimiento.ListarEstablecimiento();
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtDireccion.Text = "";
            txtRenaes.Text = "";
            txtDescripcion.Enabled = false;
            txtDireccion.Enabled = false;
            txtRenaes.Enabled = false;
            cbMicrored.Enabled = false;
            btnInsertar.Enabled = false;
            txtContenido.Enabled = false;
            cbCampo.Enabled = false;
        }
        public void Agregar()
        {
            try
            {
                Tabla = miEstablecimiento.SiguienteCodigo();
                txtCodigo.Text = Tabla.Rows[0][0].ToString();
                miEstablecimiento.IdEstablecimientoSalud = txtCodigo.Text;
                miEstablecimiento.IdMicrored = cbMicrored.SelectedValue.ToString();
                miEstablecimiento.Descripcion = txtDescripcion.Text;
                miEstablecimiento.Direccion = txtDireccion.Text;
                miEstablecimiento.Renaes = txtRenaes.Text;
                Tabla = miEstablecimiento.AgregarEstablecimiento();
                respuesta = Tabla.Rows[0][0].ToString();
                mensaje = Tabla.Rows[0][1].ToString();

                if (respuesta == "1")
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConfiguracionInicial();
                }
                else if (respuesta == "0")
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConfiguracionInicial();
                }
            }
            catch
            {
                MessageBox.Show("Ya existe un establecimiento con la misma descripción", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        public void Modificar()
        {
            if (txtDescripcion.Text != "")
            {
                miEstablecimiento.IdEstablecimientoSalud = txtCodigo.Text;
                miEstablecimiento.IdMicrored = cbMicrored.SelectedValue.ToString();
                miEstablecimiento.Descripcion = txtDescripcion.Text;
                miEstablecimiento.Direccion = txtDireccion.Text;
                miEstablecimiento.Renaes = txtRenaes.Text;
                Tabla = miEstablecimiento.ModificarEstablecimiento();
                respuesta = Tabla.Rows[0][0].ToString();
                mensaje = Tabla.Rows[0][1].ToString();
                if (respuesta == "1")
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConfiguracionInicial();
                }
                else if (respuesta == "0")
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConfiguracionInicial();
                }
            }
            else
                MessageBox.Show("Por favor llene los campos necesarios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void Eliminar()
        {
            try
            {
                miEstablecimiento.IdEstablecimientoSalud = txtCodigo.Text;
                miEstablecimiento.Descripcion = txtDescripcion.Text;
                Tabla = miEstablecimiento.EliminarEstablecimiento();
                respuesta = Tabla.Rows[0][0].ToString();
                mensaje = Tabla.Rows[0][1].ToString();
                if (MessageBox.Show("¿Desea Eliminar? Los Datos no podran ser recuperados", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    if (respuesta == "1")
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ConfiguracionInicial();
                    }

                    else if (respuesta == "0")
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ConfiguracionInicial();
                    }
                    else
                    {
                        /*NO HACER NADA*/
                    }
            }
            catch
            {
                MessageBox.Show("No puede eliminar el establecimiento porque esta siendo usado en otro formulario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
                
        }

        private void dgvListarEstablecimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Valor = dgvListarEstablecimiento.CurrentCell.RowIndex;
            txtCodigo.Text = dgvListarEstablecimiento[1, Valor].Value.ToString();
            cbMicrored.Text = dgvListarEstablecimiento[2, Valor].Value.ToString();
            txtDescripcion.Text = dgvListarEstablecimiento[3, Valor].Value.ToString();
            txtDireccion.Text = dgvListarEstablecimiento[4, Valor].Value.ToString();
            txtRenaes.Text = dgvListarEstablecimiento[5, Valor].Value.ToString();

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                Agregar();
            }
            else
                Modificar();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Tabla = miEstablecimiento.ListarEstablecimiento();
                string Campo = cbCampo.Text;
                Tabla.DefaultView.RowFilter = (" " + Campo + " like '" + txtContenido.Text + "%'");
                dgvListarEstablecimiento.DataSource = Tabla.DefaultView;
            }
            catch{ } 
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtRenaes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCampo.Text == "")
            {
                txtContenido.Enabled = false;
            }
            else
            {
                txtContenido.Enabled = true;
            }
        }
    }
}
