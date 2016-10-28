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
    public partial class frmMicrored : Form
    {
        CapaDeNegocios.EstablecimientoSalud.cMicrored miMicrored = new CapaDeNegocios.EstablecimientoSalud.cMicrored();
        DataTable Tabla = new DataTable();
        string mensaje = "";
        string respuesta = "";

        public frmMicrored()
        {
            InitializeComponent();
            ActualizarLista();
        }
        public void ActualizarLista()
        {
            dgvListarMicrored.DataSource = miMicrored.ListarMicrored();
            Tabla = miMicrored.SiguienteCodigo();
            txtCodigo.Text = Tabla.Rows[0][0].ToString();
        }
        private void ConfiguracionInicial()
        {
            Tabla = miMicrored.SiguienteCodigo();
            txtCodigo.Text = Tabla.Rows[0][0].ToString();
            txtMicrored.Text = "";
            txtDireccion.Text = "";
            txtMicrored.Focus();
        }
        public void SiguienteCodigo()
        {

        }
        public void Agregar()
        {
            if (txtMicrored.Text != "")
            {
                miMicrored.IdMicrored = txtCodigo.Text;
                miMicrored.Microred = txtMicrored.Text;
                miMicrored.Direccion = txtDireccion.Text;
                Tabla = miMicrored.AgregarMicrored();
                respuesta = Tabla.Rows[0][0].ToString();
                mensaje = Tabla.Rows[0][1].ToString();

                if (respuesta == "1")
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConfiguracionInicial();
                    ActualizarLista();
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
        public void Modificar()
        {
            if (txtMicrored.Text != "")
            {
                miMicrored.IdMicrored = txtCodigo.Text;
                miMicrored.Microred = txtMicrored.Text;
                miMicrored.Direccion = txtDireccion.Text;
                Tabla = miMicrored.ModificarMicrored();
                respuesta = Tabla.Rows[0][0].ToString();
                mensaje = Tabla.Rows[0][1].ToString();
                if (respuesta == "1")
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConfiguracionInicial();
                    ActualizarLista();
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
                miMicrored.IdMicrored = txtCodigo.Text;
                miMicrored.Microred = txtMicrored.Text;
                miMicrored.Direccion = txtDireccion.Text;
                Tabla = miMicrored.EliminarMicrored();
                respuesta = Tabla.Rows[0][0].ToString();
                mensaje = Tabla.Rows[0][1].ToString();
                if (MessageBox.Show("¿Desea Eliminar? Los Datos no podran ser recuperados", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    if (respuesta == "1")
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ConfiguracionInicial();
                        ActualizarLista();
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
                MessageBox.Show("No puede eliminar la Microred porque esta siendo usado en otro formulario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void dgvListarMicrored_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Valor = dgvListarMicrored.CurrentCell.RowIndex;
            txtCodigo.Text = dgvListarMicrored[0, Valor].Value.ToString();
            txtMicrored.Text = dgvListarMicrored[1, Valor].Value.ToString();
            txtDireccion.Text = dgvListarMicrored[2, Valor].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ConfiguracionInicial();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Agregar();
        }
    }
}
