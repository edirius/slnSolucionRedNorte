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

namespace CapaUsuario.RecienNacido
{
    public partial class frmRecienNacido : Form
    {
        CapaDeNegocios.RecienNacido.cRecienNacido miRecienNacido = new CapaDeNegocios.RecienNacido.cRecienNacido();
        cSiguienteCodigo micodigo = new cSiguienteCodigo();
        DataTable Tabla = new DataTable();
        string respuesta = "";
        string mensaje = "";
        public string aIdHistoria = "";
        public string aIdEstablecimiento = "";

        public frmRecienNacido(string IdHistoria, string IdEstablecimiento)
        {
            InitializeComponent();
            //ConfiguracionInicial();
            aIdHistoria = IdHistoria;
            aIdEstablecimiento = IdEstablecimiento;
            txtCodigoHistoria.Text = IdHistoria;
            ActualizarLista(IdEstablecimiento);
        }
        public void ActualizarLista(string id)
        {
            dgvRecienNacido.DataSource = miRecienNacido.ListarRecienNacido();
            Tabla = micodigo.SiguientesCodigo("treciennacido", aIdEstablecimiento);
            txtCodigoRN.Text = Tabla.Rows[0][0].ToString();
            Alertar();

        }
        private void Alertar()
        {
            if (txtMensaje.Text != "")
            {
                lblAlerta.Visible = true;
                pbAlerta.Visible = true;
                timer.Start();
            }
            else if (txtMensaje.Text == "")
            {
                pbAlerta.Visible = false;
                lblAlerta.Visible = false;
                timer.Stop();
            }
        }
        private void ConfiguracionInicial()
        {

            Tabla = micodigo.SiguientesCodigo("treciennacido", aIdEstablecimiento);
            txtCodigoRN.Text = Tabla.Rows[0][0].ToString();
            dtpFecha.Value = DateTime.Today;
            pbAlerta.Visible = false;
            ////txtCodigo.Text = "";
            ////txtDescripcion.Text = "";
            ////txtDireccion.Text = "";
            ////txtRenaes.Text = "";
            ////txtDescripcion.Focus();
        }
        public void Agregar()
        {
            //try
            //{
            if (txtCodigoRN.Text != "")
            {
                miRecienNacido.IdRecienNacido = txtCodigoRN.Text;
                miRecienNacido.IdHistoriaClinica = txtCodigoHistoria.Text;
                miRecienNacido.FechaDerivado = Convert.ToDateTime(dtpFecha.Value.ToShortDateString());
                miRecienNacido.Apgar1 = nudApgar1.Text;
                miRecienNacido.Apgar5 = nudApgar5.Text;
                miRecienNacido.Peso = nudPeso.Text;
                miRecienNacido.Sexo = cbSexo.Text;
                Tabla = miRecienNacido.AgregarRecienNacido();
                respuesta = Tabla.Rows[0][0].ToString();
                mensaje = Tabla.Rows[0][1].ToString();

                if (respuesta == "1")
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConfiguracionInicial();
                    dgvRecienNacido.DataSource = miRecienNacido.ListarRecienNacido();
                }
                else if (respuesta == "0")
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConfiguracionInicial();
                }
            }
            else
                MessageBox.Show("Por favor llene los campos necesarios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            //catch
            //{
            //    MessageBox.Show("Ya existe una bateria con la misma fecha", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


        }
        public void Modificar()
        {
            //try
            //{
            if (txtCodigoRN.Text != "")
            {
                miRecienNacido.IdRecienNacido = txtCodigoRN.Text;
                miRecienNacido.IdHistoriaClinica = txtCodigoHistoria.Text;
                miRecienNacido.FechaDerivado = Convert.ToDateTime(dtpFecha.Value.ToShortDateString());
                miRecienNacido.Apgar1 = nudApgar1.Text;
                miRecienNacido.Apgar5 = nudApgar5.Text;
                miRecienNacido.Peso = nudPeso.Text;
                miRecienNacido.Sexo = cbSexo.Text;
                Tabla = miRecienNacido.ModificarRecienNacido();
                respuesta = Tabla.Rows[0][0].ToString();
                mensaje = Tabla.Rows[0][1].ToString();

                if (respuesta == "1")
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConfiguracionInicial();
                    dgvRecienNacido.DataSource = miRecienNacido.ListarRecienNacido();
                }
                else if (respuesta == "0")
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConfiguracionInicial();
                }
            }
            else
                MessageBox.Show("Por favor llene los campos necesarios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            //catch
            //{
            //    MessageBox.Show("Ya existe una bateria con la misma fecha", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }
        private void Eliminar()
        {
            if (txtCodigoRN.Text != "")
            {
                miRecienNacido.IdRecienNacido = txtCodigoRN.Text;
                Tabla = miRecienNacido.EliminarRecienNacido();
                respuesta = Tabla.Rows[0][0].ToString();
                mensaje = Tabla.Rows[0][1].ToString();
                if (MessageBox.Show("¿Desea Eliminar? Los Datos no podran ser recuperados.", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    if (respuesta == "1")
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ConfiguracionInicial();
                        dgvRecienNacido.DataSource = miRecienNacido.ListarRecienNacido();
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
            else
                MessageBox.Show("Por favor seleccione una bateria para elimarla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Agregar();
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
        int Tiempo;
        private void timer_Tick(object sender, EventArgs e)
        {
            Tiempo--;
            if ((Tiempo % 2) == 0)
            {

                lblAlerta.ForeColor = System.Drawing.Color.Red;

            }
            else

                lblAlerta.ForeColor = System.Drawing.Color.White;
        }

        private void txtMensaje_TextChanged(object sender, EventArgs e)
        {
            Alertar();
        }

        private void dgvRecienNacido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Valor = dgvRecienNacido.CurrentCell.RowIndex;
            txtCodigoRN.Text = dgvRecienNacido[0, Valor].Value.ToString();
            txtCodigoHistoria.Text = dgvRecienNacido[1, Valor].Value.ToString();
            dtpFecha.Text = dgvRecienNacido[2, Valor].Value.ToString();
            nudApgar1.Text = dgvRecienNacido[3, Valor].Value.ToString();
            nudApgar5.Text = dgvRecienNacido[4, Valor].Value.ToString();
            nudPeso.Text = dgvRecienNacido[5, Valor].Value.ToString();
            cbSexo.Text = dgvRecienNacido[6, Valor].Value.ToString();

        }
    }
}
