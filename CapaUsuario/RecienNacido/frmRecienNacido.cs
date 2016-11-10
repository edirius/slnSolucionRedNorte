﻿using System;
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
            ConfiguracionInicial();
            Nuevo();
            aIdHistoria = IdHistoria;
            aIdEstablecimiento = IdEstablecimiento;
            txtCodigoHistoria.Text = IdHistoria;
            ActualizarLista(IdEstablecimiento);
        }
        public void ActualizarLista(string id)
        {
            dgvRecienNacido.DataSource = miRecienNacido.ListarRecienNacido(txtCodigoHistoria.Text);
            Alertar();

        }
        private void Alertar()
        {
            if (txtMensajeApgar1.Text != "" || txtMensajeApgar5.Text != "" || txtMensajePeso.Text !="")
            {
                lblAlerta.Visible = true;
                pbAlerta.Visible = true;
                timer.Start();
            }
            else if (txtMensajeApgar1.Text == "" || txtMensajeApgar5.Text == "" || txtMensajePeso.Text == "")
            {
                pbAlerta.Visible = false;
                lblAlerta.Visible = false;
                timer.Stop();
            }
        }
        private void ConfiguracionInicial()
        {

            txtCodigoRN.Text = "";
            dtpFecha.Value = DateTime.Today;
            dtpFecha.Enabled = false;
            pbAlerta.Visible = false;
            nudApgar1.Value = 0;
            nudApgar1.Enabled = false;
            nudApgar5.Value = 0;
            nudApgar5.Enabled = false;
            nudPeso.Value = 2000;
            nudPeso.Enabled = false;
            cbSexo.Text = "Seleccione el sexo.";
            cbSexo.Enabled = false;
            btnInsertar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private void Nuevo()
        {
            dgvRecienNacido.ClearSelection();
            txtCodigoRN.Text = "";
            dtpFecha.Value = DateTime.Today;
            dtpFecha.Enabled = true;
            pbAlerta.Visible = false;
            nudApgar1.Value = 0;
            nudApgar1.Enabled = true;
            nudApgar5.Value = 0;
            nudApgar5.Enabled = true;
            nudPeso.Value = 2000;
            nudPeso.Enabled = true;
            cbSexo.Text = "Seleccione el sexo.";
            cbSexo.Enabled = true;
            btnInsertar.Enabled = true;
            btnEliminar.Enabled = true;
            txtMensajeApgar1.Text = "";
            txtMensajeApgar5.Text = "";
            txtMensajePeso.Text = "";
            
        }
        public void Agregar()
        {
            //try
            //{
            if (txtCodigoRN.Text == "")
            {
                Tabla = micodigo.SiguientesCodigo("treciennacido", aIdEstablecimiento);
                txtCodigoRN.Text = Tabla.Rows[0][0].ToString();
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
                    dgvRecienNacido.DataSource = miRecienNacido.ListarRecienNacido(txtCodigoHistoria.Text);
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
                    dgvRecienNacido.DataSource = miRecienNacido.ListarRecienNacido(txtCodigoHistoria.Text);
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
                        dgvRecienNacido.DataSource = miRecienNacido.ListarRecienNacido(txtCodigoHistoria.Text);
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
            if (txtCodigoRN.Text == "")
            {
                Agregar();
            }
            else
                Modificar();
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
            Nuevo();
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
            try
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
            catch { }
            

        }

        private void nudApgar1_ValueChanged(object sender, EventArgs e)
        {
            if (nudApgar1.Value <= 7)
            {
                txtMensajeApgar1.Text = "¡¡¡¡Alerta!!!!";
            }
            else
            {
                txtMensajeApgar1.Text = "";
            }
        }

        private void nudApgar5_ValueChanged(object sender, EventArgs e)
        {
            if (nudApgar5.Value <= 7)
            {
                txtMensajeApgar5.Text = "Niño Hipoactivo - No reactivo";
            }
            else
            {
                txtMensajeApgar5.Text = "";
            }
        }

        private void nudPeso_ValueChanged(object sender, EventArgs e)
        {
            if (nudPeso.Value <= 2500)
            {
                txtMensajePeso.Text = "Recien nacido con bajo de peso";
            }
            else
            {
                txtMensajePeso.Text = "";
            }
        }
        
        private void dgvRecienNacido_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRecienNacido.Rows[e.RowIndex].Cells[0].Value != null)
            {
                if ((Convert.ToInt16(dgvRecienNacido.Rows[e.RowIndex].Cells["APGAR1"].Value) >= 7))
                {
                    dgvRecienNacido.Rows[e.RowIndex].Cells["APGAR1"].Style.BackColor = Color.Red;
                }
                if ((Convert.ToInt16(dgvRecienNacido.Rows[e.RowIndex].Cells["APGAR5"].Value) >= 7))
                {
                    dgvRecienNacido.Rows[e.RowIndex].Cells["APGAR5"].Style.BackColor = Color.Red;
                }
                if ((Convert.ToInt16(dgvRecienNacido.Rows[e.RowIndex].Cells["PESO"].Value) <= 2500))
                {
                    dgvRecienNacido.Rows[e.RowIndex].Cells["PESO"].Style.BackColor = Color.Red;
                }
            }
        }

        private void txtMensajePeso_TextChanged(object sender, EventArgs e)
        {
            Alertar();
        }

        private void dgvRecienNacido_SelectionChanged(object sender, EventArgs e)
        {
            try
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
            catch { }
        }

        private void txtMensajeApgar5_TextChanged(object sender, EventArgs e)
        {
            Alertar();
        }
    }
}
