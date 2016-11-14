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
using System.Media;
using System.Collections;

namespace CapaUsuario.Bateria
{
    public partial class frmBateria : Form
    {
        cBateria miBateria = new cBateria();
        cSiguienteCodigo micodigo = new cSiguienteCodigo();
        cUtilitarios miUtilitario = new cUtilitarios();
        DataTable Tabla = new DataTable();
        string respuesta = "";
        string mensaje = "";
        public string IdHistoria = "";
        public string IdEstablecimiento = "";
        public frmBateria(string IdtHistoriaClinica, string IdtEstablecimiento)
        {
            InitializeComponent();
            ConfiguracionInicial();
            IdHistoria = IdtHistoriaClinica;
            txtCodigoHistoria.Text = IdHistoria;
            IdEstablecimiento = IdtEstablecimiento;
            ActualizarLista();
            

        }
        public void ActualizarLista()
        {
            dgvListaBateria.DataSource = miBateria.ListarBateria(txtCodigoHistoria.Text);
            Alertar();

        }
        private void Alertar()
        {
            if (txtMensajeHemo.Text != "" || txtMensajeOrina.Text != "" || txtMensajeSifilis.Text != "" || txtMensajeVIH.Text != "")
            {
                lblAlerta.Visible = true;
                pbAlerta.Visible = true;
                timer.Start();
            }
            else if ( txtMensajeHemo.Text == "" || txtMensajeOrina.Text == "" || txtMensajeSifilis.Text == "" || txtMensajeVIH.Text == "")
            {
                pbAlerta.Visible = false;
                lblAlerta.Visible = false;
                timer.Stop();
            }
        }
        private void Nuevo()
        {
            //dgvListaBateria.Enabled = true;
            dgvListaBateria.ClearSelection();
            txtCodigoBateria.Text = "";
            txtFechaExamenOrina.Enabled = true;
            dtpFecha.Value = DateTime.Today;
            dtpFecha.Enabled = true;
            pbAlerta.Visible = false;
            nudHemoglobina.Text = "";
            nudHemoglobina.Enabled = true;
            cbSifilis.Text = "NO REACTIVO";
            cbSifilis.Enabled = true;
            cbVIH.Text = "NO REACTIVO";
            cbVIH.Enabled = true;
            nudGlucosa.Enabled = true;
            nudGlucosa.Text = "";
            nudOrina.Text = "";
            nudOrina.Enabled = true;
            dtpFechaOrina.Enabled = true;
            btnInsertar.Enabled = true;
            txtFechaExamenOrina.Text = "";
            txtFechaTratamiento.Text = "";
            txtMensajeHemo.Text = "";
            txtMensajeOrina.Text = "";
            txtMensajeSifilis.Text = "";
            txtMensajeVIH.Text = "";
            dtpFecha.Focus();
            txtFechaExamenOrina.Enabled = false;
            timer.Stop();
        }
        private void ConfiguracionInicial()
        {
            //dgvListaBateria.ClearSelection();
            ////dgvListaBateria.Enabled = false;
            //txtCodigoBateria.Text = "";
            //txtFechaExamenOrina.Enabled = false;
            //txtFechaExamenOrina.Text = "";
            //dtpFecha.Value = DateTime.Today;
            //dtpFecha.Enabled = false;
            //pbAlerta.Visible = false;
            //nudHemoglobina.Text = "";
            //nudHemoglobina.Enabled = false;
            //cbSifilis.Text = "gege";
            //cbSifilis.Enabled = false;
            //cbVIH.Text = "gege";
            //cbVIH.Enabled = false;
            //nudGlucosa.Enabled = false;
            //nudGlucosa.Text = "";
            //nudOrina.Text = "";
            //nudOrina.Enabled = false;
            //dtpFechaOrina.Text = "";
            //dtpFechaOrina.Enabled = false;
            //btnInsertar.Enabled = false;


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
            if (txtCodigoBateria.Text == "")
            {
                Tabla = micodigo.SiguientesCodigo("tbateria", IdEstablecimiento);
                txtCodigoBateria.Text = Tabla.Rows[0][0].ToString();
                miBateria.IdBateria = txtCodigoBateria.Text;
                miBateria.IdHistoriaClinica = txtCodigoHistoria.Text;
                miBateria.Fecha = Convert.ToDateTime(dtpFecha.Value.ToShortDateString());
                miBateria.Hemoglobina = nudHemoglobina.Text;
                miBateria.Vih = cbVIH.Text;
                miBateria.Sifilis = cbSifilis.Text;
                miBateria.Glucosa = nudGlucosa.Text;
                miBateria.Orina = nudOrina.Text;
                miBateria.FechaExamenOrina = txtFechaExamenOrina.Text;
                miBateria.FechaTratamiento = txtFechaTratamiento.Text;
                Tabla = miBateria.AgregarBateria();
                respuesta = Tabla.Rows[0][0].ToString();
                mensaje = Tabla.Rows[0][1].ToString();

                if (respuesta == "1")
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nuevo();
                    ActualizarLista();
                }
                else if (respuesta == "0")
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Nuevo();
                }

            }
            else { }
                
            //}
            //catch
            //{
            //    MessageBox.Show("Ya existe una bateria con la misma fecha", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


        }
        public void Modificar()
        {
            try
            {
                if (txtCodigoBateria.Text != "")
                {
                    if (Convert.ToDateTime(dtpFecha.Value.ToShortDateString()) >= Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                    {
                        miBateria.IdBateria = txtCodigoBateria.Text;
                        miBateria.IdHistoriaClinica = txtCodigoHistoria.Text;
                        miBateria.Fecha = Convert.ToDateTime(dtpFecha.Value.ToShortDateString());
                        miBateria.Hemoglobina = nudHemoglobina.Text;
                        miBateria.Vih = cbVIH.Text;
                        miBateria.Sifilis = cbSifilis.Text;
                        miBateria.Glucosa = nudGlucosa.Text;
                        miBateria.Orina = nudOrina.Text;
                        miBateria.FechaExamenOrina = txtFechaExamenOrina.Text;
                        miBateria.FechaTratamiento = txtFechaTratamiento.Text;
                        Tabla = miBateria.ModificarBateria();
                        respuesta = Tabla.Rows[0][0].ToString();
                        mensaje = Tabla.Rows[0][1].ToString();

                        if (respuesta == "1")
                        {
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActualizarLista();
                            Nuevo();
                        }
                        else if (respuesta == "0")
                        {
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Nuevo();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No puede modificar una bateria con fecha menor a la fecha actual. Contáctese con el administrador del Sistema.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                    MessageBox.Show("Por favor llene los campos necesarios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch
            {
                MessageBox.Show("Ya existe una bateria con la misma fecha", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Eliminar()
        {
            if (txtCodigoBateria.Text != "")
            {
                if (Convert.ToDateTime(dtpFecha.Value.ToShortDateString()) >= Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                {
                    miBateria.IdBateria = txtCodigoBateria.Text;
                    Tabla = miBateria.EliminarBateria();
                    respuesta = Tabla.Rows[0][0].ToString();
                    mensaje = Tabla.Rows[0][1].ToString();

                    if (MessageBox.Show("¿Desea Eliminar? Los Datos no podran ser recuperados", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        if (respuesta == "1")
                        {
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActualizarLista();
                            Nuevo();
                        }

                        else if (respuesta == "0")
                        {
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Nuevo();
                        }
                        else
                        {
                            /*NO HACER NADA*/
                        }
                }
                else
                {
                    MessageBox.Show("No puede eliminar una bateria antigua", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
                MessageBox.Show("Por favor seleccione una bateria para elimarla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void playSonidoDeAlerta()
        {
            SoundPlayer Alerta = new SoundPlayer(@"C:\Users\Usuario\Desktop\Imagenes para el sistema de control de embarazo\SonidoDeAlerta.mp3");
            Alerta.Play();
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

        private void nudOrina_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(nudOrina.Value) >= 8)
                {

                    txtMensajeOrina.Text = "Alerta: La gestante tiene infección urinaria a tratar";
                    //playSonidoDeAlerta();
                    //MessageBox.Show("La gestante tiene infección urinaria a tratar", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtMensajeOrina.Text = "";
                }
                
            }
            catch { }
            

        }

        private void dgvListaBateria_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try {
                int valor = dgvListaBateria.CurrentCell.RowIndex;
                txtCodigoBateria.Text = dgvListaBateria[0, valor].Value.ToString();
                txtCodigoHistoria.Text = dgvListaBateria[1, valor].Value.ToString();
                dtpFecha.Text = dgvListaBateria[2, valor].Value.ToString();
                nudHemoglobina.Text = dgvListaBateria[3, valor].Value.ToString();
                cbVIH.Text = dgvListaBateria[4, valor].Value.ToString();
                cbSifilis.Text = dgvListaBateria[5, valor].Value.ToString();
                nudGlucosa.Text = dgvListaBateria[6, valor].Value.ToString();
                nudOrina.Text = dgvListaBateria[7, valor].Value.ToString();
                txtFechaExamenOrina.Text = dgvListaBateria[8, valor].Value.ToString();
                txtFechaTratamiento.Text = dgvListaBateria[9, valor].Value.ToString();
            }
            catch { }
            
            
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Modificar();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtCodigoBateria.Text == "")
            { Agregar(); }
            else
                Modificar();
            
        }

        private void nudGlucosa_ValueChanged(object sender, EventArgs e)
        {
            
            //try
            //{
            //    if (Convert.ToDecimal(nudGlucosa.Value) < Convert.ToDecimal(60))
            //    {

            //        txtMensajeGlucosa.Text = "Alerta: La gestante tiene hipoglicemia";
            //        //playSonidoDeAlerta();
            //        //MessageBox.Show("La gestante tiene hipoglucemia", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else if (Convert.ToDecimal(nudGlucosa.Value) >= Convert.ToDecimal(60) && Convert.ToDecimal(nudGlucosa.Value) <= Convert.ToDecimal(130))
            //    {
            //        txtMensajeGlucosa.Text = "";
            //    }
            //    else if (Convert.ToDecimal(nudGlucosa.Value) > Convert.ToDecimal(130))
            //    {

            //        //playSonidoDeAlerta();
            //        txtMensajeGlucosa.Text = "Alerta: La gestante tiene hiperglucemia";
            //        //MessageBox.Show("La gestante tiene hiperglucemia", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //catch { }

        }

        private void cbSifilis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSifilis.Text == "REACTIVO")
            {
                
                txtMensajeSifilis.Text = "Alerta: La gestante tiene Sifilis positivo";
                //playSonidoDeAlerta();
                //MessageBox.Show("La gestante tiene SIFILIS positivo.", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                txtMensajeSifilis.Text = "";
            }
        }

        private void cbVIH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVIH.Text == "REACTIVO")
            {
                
                txtMensajeVIH.Text = "Alerta: La gestante tiene VIH positivo";
                //playSonidoDeAlerta();
                //MessageBox.Show("La gestante tiene VIH positivo.", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cbVIH.Text == "NO REACTIVO")
            {
                txtMensajeVIH.Text = "";
                //pbAlerta.Visible = false;
                //listPrecauciones.Items.Remove(mensaje1);
                //timer.Stop();
            }
        }

        private void nudHemoglobina_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(nudHemoglobina.Value) < Convert.ToDecimal(11.5))
            {
                txtMensajeHemo.Text = "Alerta: La gestante tiene anemia";
                //playSonidoDeAlerta();
                //MessageBox.Show("Precaución: La Gestante tiene anemia", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtMensajeHemo.Text = "";
                //this.BackColor = System.Drawing.Color.White;
                //this.ForeColor = System.Drawing.Color.Black;
                //dgvListaBateria.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtMensajeHemo_TextChanged(object sender, EventArgs e)
        {
            Alertar();
        }

        private void txtMensajeVIH_TextChanged(object sender, EventArgs e)
        {
            Alertar();
        }

        private void txtMensajeSifilis_TextChanged(object sender, EventArgs e)
        {
            Alertar();
        }

        private void txtMensajeGlucosa_TextChanged(object sender, EventArgs e)
        {
            Alertar();
        }

        private void txtMensajeOrina_TextChanged(object sender, EventArgs e)
        {
            Alertar();
        }

        private void dtpFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void nudHemoglobina_KeyPress(object sender, KeyPressEventArgs e)
        {
            //al precionar enter
            miUtilitario.SoloNumeros(e);
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void dtpFechaOrina_ValueChanged(object sender, EventArgs e)
        {
            txtFechaExamenOrina.Text = dtpFechaOrina.Text;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void dgvListaBateria_SelectionChanged(object sender, EventArgs e)
        {
            try {
                int valor = dgvListaBateria.CurrentCell.RowIndex;
                txtCodigoBateria.Text = dgvListaBateria[0, valor].Value.ToString();
                txtCodigoHistoria.Text = dgvListaBateria[1, valor].Value.ToString();
                dtpFecha.Text = dgvListaBateria[2, valor].Value.ToString();
                nudHemoglobina.Text = dgvListaBateria[3, valor].Value.ToString();
                cbVIH.Text = dgvListaBateria[4, valor].Value.ToString();
                cbSifilis.Text = dgvListaBateria[5, valor].Value.ToString();
                nudGlucosa.Text = dgvListaBateria[6, valor].Value.ToString();
                nudOrina.Text = dgvListaBateria[7, valor].Value.ToString();
                txtFechaExamenOrina.Text = dgvListaBateria[8, valor].Value.ToString();
                txtFechaTratamiento.Text = dgvListaBateria[9, valor].Value.ToString();
            }
            catch { }
            
        }

        private void dgvListaBateria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvListaBateria.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    if ((Convert.ToDecimal(dgvListaBateria.Rows[e.RowIndex].Cells["hemoglobina"].Value) <= Convert.ToDecimal(11.5)))
                    {
                        dgvListaBateria.Rows[e.RowIndex].Cells["hemoglobina"].Style.BackColor = Color.Red;
                    }
                    if ((Convert.ToString(dgvListaBateria.Rows[e.RowIndex].Cells["vih"].Value) == "REACTIVO"))
                    {
                        dgvListaBateria.Rows[e.RowIndex].Cells["vih"].Style.BackColor = Color.Red;
                    }
                    if ((Convert.ToString(dgvListaBateria.Rows[e.RowIndex].Cells["sifilis"].Value) == "REACTIVO"))
                    {
                        dgvListaBateria.Rows[e.RowIndex].Cells["sifilis"].Style.BackColor = Color.Red;
                    }
                    if ((Convert.ToInt16(dgvListaBateria.Rows[e.RowIndex].Cells["orina"].Value) >= 8))
                    {
                        dgvListaBateria.Rows[e.RowIndex].Cells["orina"].Style.BackColor = Color.Red;
                    }

                }
            }
            catch { }

        }

        private void pbNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void pbGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodigoBateria.Text == "")
            { Agregar(); }
            else
                Modificar();
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpFechaTratamiento_ValueChanged_1(object sender, EventArgs e)
        {
            txtFechaTratamiento.Text = dtpFechaTratamiento.Text;
        }

        private void frmBateria_Load(object sender, EventArgs e)
        {
            //dgvListaBateria.ClearSelection();
            Nuevo();
        }
    }
}
