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
        public string IdObstetra { get; set; }
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
            if (lblMensajeHemo.Text != "" || lblMensajeOrina.Text != "" || lblMensajeSifilis.Text != "" || lblMensajeVIH.Text != "" || lblMensajeTratamiento.Text !="")
            {
                lblAlerta.Visible = true;
                pbAlerta.Visible = true;
                timer.Start();
            }
            else if (lblMensajeHemo.Text == "" || lblMensajeOrina.Text == "" || lblMensajeSifilis.Text == "" || lblMensajeVIH.Text == "" || lblMensajeTratamiento.Text == "")
            {
                pbAlerta.Visible = false;
                lblAlerta.Visible = false;
                timer.Stop();
            }
            if (txtFechaTratamiento.Text != "")
            {
                lblMensajeOrina.Text = "";
            }
        }
        private void Nuevo()
        {
            //dgvListaBateria.Enabled = true;
            dgvListaBateria.ClearSelection();
            txtCodigoBateria.Text = "";
            dtpFecha.Value = DateTime.Today;
            pbAlerta.Visible = false;
            nudHemoglobina.Text = "60";
            cbSifilis.Text = "NO REACTIVO";
            cbVIH.Text = "NO REACTIVO";
            nudGlucosa.Text = "10";
            nudOrina.Text = "";
            txtFechaExamenOrina.Text = "";
            txtFechaTratamiento.Text = "";
            lblMensajeHemo.Text = "";
            lblMensajeOrina.Text = "";
            lblMensajeSifilis.Text = "";
            lblMensajeVIH.Text = "";
            lblMensajeTratamiento.Text = "";
            dtpFecha.Focus();
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
            try
            {
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
                    miBateria.IdObstetra = IdObstetra;
                    Tabla = miBateria.AgregarBateria();
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
            }
            catch
            {
                MessageBox.Show("Los campos: Hemoglobina y Glucosa deben de tener siempre un valor", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Modificar()
        {
            try
            {
                if (txtCodigoBateria.Text != "")
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
                    miBateria.IdObstetra = IdObstetra;
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
                if (txtFechaTratamiento.Text == "")
                {
                    if (Convert.ToInt16(nudOrina.Value) >= 8)
                    {

                        lblMensajeOrina.Text = "LA GESTANTE TIENE INFECCIÓN URINARIA A TRATAR";
                        //playSonidoDeAlerta();
                        //MessageBox.Show("La gestante tiene infección urinaria a tratar", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        lblMensajeOrina.Text = "";
                    }
                }
                else { }
                
                
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
                txtFechaExamenOrina.Text = dgvListaBateria[8, valor].Value.ToString();
                txtFechaTratamiento.Text = dgvListaBateria[9, valor].Value.ToString();
                nudOrina.Text = dgvListaBateria[7, valor].Value.ToString();
                Alertar();
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
            if (txtFechaTratamiento.Text == "")
            {
                if (cbSifilis.Text == "REACTIVO")
                {

                    lblMensajeSifilis.Text = "LA GESTANTE TIENE SIFILIS POSITIVO";
                    //playSonidoDeAlerta();
                    //MessageBox.Show("La gestante tiene SIFILIS positivo.", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    lblMensajeSifilis.Text = "";
                }
            }
            else { }
            
        }

        private void cbVIH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtFechaTratamiento.Text == "")
            {
                if (cbVIH.Text == "REACTIVO")
                {

                    lblMensajeVIH.Text = "LA GESTANTE TIENE VIH POSITIVO";
                    //playSonidoDeAlerta();
                    //MessagelblMensajeVIHBox.Show("La gestante tiene VIH positivo.", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (cbVIH.Text == "NO REACTIVO")
                {
                    lblMensajeVIH.Text = "";
                    //pbAlerta.Visible = false;
                    //listPrecauciones.Items.Remove(mensaje1);
                    //timer.Stop();
                }
            }
            else { }
            
        }

        private void nudHemoglobina_ValueChanged(object sender, EventArgs e)
        {
            if (txtFechaTratamiento.Text == "")
            {
                if (Convert.ToDecimal(nudHemoglobina.Value) < Convert.ToDecimal(11.5))
                {
                    lblMensajeHemo.Text = "LA GESTANTE TIENE ANEMIA";

                }
                if (Convert.ToDecimal(nudHemoglobina.Value) >= Convert.ToDecimal(11.5))
                {
                    lblMensajeHemo.Text = "";
                    //this.BackColor = System.Drawing.Color.White;
                    //this.ForeColor = System.Drawing.Color.Black;
                    //dgvListaBateria.ForeColor = System.Drawing.Color.Black;
                }
            }
            else { }
            
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
            try
            {
                int valor = dgvListaBateria.CurrentCell.RowIndex;
                txtCodigoBateria.Text = dgvListaBateria[0, valor].Value.ToString();
                txtCodigoHistoria.Text = dgvListaBateria[1, valor].Value.ToString();
                dtpFecha.Text = dgvListaBateria[2, valor].Value.ToString();
                nudHemoglobina.Text = dgvListaBateria[3, valor].Value.ToString();
                cbVIH.Text = dgvListaBateria[4, valor].Value.ToString();
                cbSifilis.Text = dgvListaBateria[5, valor].Value.ToString();
                nudGlucosa.Text = dgvListaBateria[6, valor].Value.ToString();
                
                txtFechaExamenOrina.Text = dgvListaBateria[8, valor].Value.ToString();
                txtFechaTratamiento.Text = dgvListaBateria[9, valor].Value.ToString();
                if (dgvListaBateria[9, valor].Value.ToString() != "" & Convert.ToInt16(dgvListaBateria[7, valor].Value.ToString()) >= 8)
                {
                    lblMensajeOrina.Text = "";
                    lblMensajeTratamiento.Text = "";
                }
                if (dgvListaBateria[9, valor].Value.ToString() == "" & Convert.ToInt16(dgvListaBateria[7, valor].Value.ToString()) >= 8)
                {
                    lblMensajeOrina.Text = "LA GESTANTE TIENE INFECCIÓN URINARIA";
                    lblMensajeTratamiento.Text = "LA GESTANTE NO TIENE FECHA DE TRATAMIENTO";
                }
                nudOrina.Text = dgvListaBateria[7, valor].Value.ToString();
            }
            catch { }
            
        }

        private void dgvListaBateria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvListaBateria.Rows[e.RowIndex].Cells["fechatratamiento"].Value == "")
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
                    else { }
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

        private void nudGlucosa_KeyPress(object sender, KeyPressEventArgs e)
        {
            miUtilitario.SoloNumeros(e);
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void nudOrina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            miUtilitario.SoloNumeros(e);
        }

        private void txtFechaExamenOrina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            miUtilitario.SoloNumeros(e);
        }

        private void txtFechaTratamiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            miUtilitario.SoloNumeros(e);
        }
        
        //nudHemoglobina.Value.ToString() != "" || nudGlucosa.Value.ToString() != ""
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
                if (txtCodigoBateria.Text == "")
                {
                    if (lblMensajeHemo.Text != "" || lblMensajeVIH.Text != "" || lblMensajeSifilis.Text != "" || lblMensajeOrina.Text != "" && txtFechaTratamiento.Text == "")
                    {
                        MessageBox.Show("La gestante presenta complicaciones y no le ha dado una fecha para su tratamiento.", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Agregar();
                    }
                    else
                    {
                        Agregar();
                    }
                }
                if (txtCodigoBateria.Text != "")
                {
                    if (lblMensajeHemo.Text != "" || lblMensajeVIH.Text != "" || lblMensajeSifilis.Text != "" || lblMensajeOrina.Text != "" && txtFechaTratamiento.Text == "")
                    {
                        MessageBox.Show("La gestante presenta complicaciones y no le ha dado una fecha para su tratamiento.", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Modificar();
                    }
                    else
                    {
                        Modificar();
                    }
                }   
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnEliminar_Click_2(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbSifilis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void dtpFechaOrina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void dtpFechaTratamiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cbVIH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnGuardar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void lblMensajeHemo_TextChanged(object sender, EventArgs e)
        {
            Alertar();
        }

        private void lblMensajeVIH_TextChanged(object sender, EventArgs e)
        {
            Alertar();
        }

        private void lblMensajeSifilis_TextChanged(object sender, EventArgs e)
        {
            Alertar();
        }

        private void lblMensajeOrina_TextChanged(object sender, EventArgs e)
        {
            Alertar();
        }

        private void lblMensajeTratamiento_TextChanged(object sender, EventArgs e)
        {
            Alertar();
        }
        private void txtFechaTratamiento_TextChanged(object sender, EventArgs e)
        {
            if (txtFechaTratamiento.Text != "")
            {
                lblMensajeHemo.Text = "";
                lblMensajeOrina.Text = "";
                lblMensajeSifilis.Text = "";
                lblMensajeVIH.Text = "";
            }
        }

        private void txtCodigoBateria_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoBateria.Text == "")
            {
                dtpFecha.Enabled = true;
            }
            else
                dtpFecha.Enabled = false;
        }
    }
}
