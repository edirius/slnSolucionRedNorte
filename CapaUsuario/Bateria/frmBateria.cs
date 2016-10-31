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

namespace CapaUsuario.Bateria
{
    public partial class frmBateria : Form
    {
        cBateria miBateria = new cBateria();
        cSiguienteCodigo micodigo = new cSiguienteCodigo();
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
            ActualizarLista(IdEstablecimiento);

        }
        public void ActualizarLista(string id)
        {
            dgvListaBateria.DataSource = miBateria.ListarBateria();
            Tabla = micodigo.SiguientesCodigo("tbateria", IdEstablecimiento);
            txtCodigoBateria.Text = Tabla.Rows[0][0].ToString();
            cbSifilis.Text = "REACTIVO";
            cbVIH.Text = "REACTIVO";


        }

        private void ConfiguracionInicial()
        {
            pbAlerta.Visible = false;
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
                if (txtCodigoBateria.Text != "")
                {
                    miBateria.IdBateria = txtCodigoBateria.Text;
                    miBateria.IdHistoriaClinica = txtCodigoHistoria.Text;
                    miBateria.Fecha = Convert.ToDateTime(dtpFecha.Value.ToShortDateString());
                    miBateria.Hemoglobina = nudHemoglobina.Text;
                    miBateria.Vih = cbVIH.Text;
                    miBateria.Sifilis = cbSifilis.Text;
                    miBateria.Orina = nudOrina.Text;
                    miBateria.Glucosa = nudGlucosa.Text;
                    Tabla = miBateria.AgregarBateria();
                    respuesta = Tabla.Rows[0][0].ToString();
                    mensaje = Tabla.Rows[0][1].ToString();

                    if (respuesta == "1")
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ConfiguracionInicial();
                        dgvListaBateria.DataSource = miBateria.ListarBateria();
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
            catch
            {
                MessageBox.Show("Ya existe una bateria con la misma fecha", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    miBateria.Orina = nudOrina.Text;
                    miBateria.Glucosa = nudGlucosa.Text;
                    Tabla = miBateria.ModificarBateria();
                    respuesta = Tabla.Rows[0][0].ToString();
                    mensaje = Tabla.Rows[0][1].ToString();

                    if (respuesta == "1")
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ConfiguracionInicial();
                        dgvListaBateria.DataSource = miBateria.ListarBateria();
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
            catch
            {
                MessageBox.Show("Ya existe una bateria con la misma fecha", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Eliminar()
        {
                if (txtCodigoBateria.Text != "")
                {
                    miBateria.IdBateria = txtCodigoBateria.Text;
                    Tabla = miBateria.EliminarBateria();
                    respuesta = Tabla.Rows[0][0].ToString();
                    mensaje = Tabla.Rows[0][1].ToString();

                    if (respuesta == "1")
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ConfiguracionInicial();
                        dgvListaBateria.DataSource = miBateria.ListarBateria();
                    }
                    else if (respuesta == "0")
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ConfiguracionInicial();
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

        private void frmBateria_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvListaBateria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int valor = dgvListaBateria.CurrentCell.RowIndex;
            txtCodigoBateria.Text = dgvListaBateria[0, valor].Value.ToString();
            txtCodigoHistoria.Text = dgvListaBateria[1, valor].Value.ToString();
            dtpFecha.Text = dgvListaBateria[2, valor].Value.ToString();
            nudHemoglobina.Text = dgvListaBateria[3, valor].Value.ToString();
            cbVIH.Text = dgvListaBateria[4, valor].Value.ToString();
            cbSifilis.Text = dgvListaBateria[5, valor].Value.ToString();
            nudOrina.Text = dgvListaBateria[6, valor].Value.ToString();
            nudGlucosa.Text = dgvListaBateria[7, valor].Value.ToString();
            
            if (cbVIH.Text == "REACTIVO")
            {
                pbAlerta.Visible = true;
                //playSonidoDeAlerta();
                MessageBox.Show("La gestante tiene VIH positivo.", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cbSifilis.Text == "REACTIVO")
            {
                pbAlerta.Visible = true;
                //playSonidoDeAlerta();
                MessageBox.Show("La gestante tiene SIFILIS positivo.", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Convert.ToInt16(nudOrina.Text) > 3)
            {
                pbAlerta.Visible = true;
                //playSonidoDeAlerta();
                MessageBox.Show("La gestante tiene infección urinaria", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Convert.ToInt16(nudOrina.Text) > 8)
            {
                pbAlerta.Visible = true;
                //playSonidoDeAlerta();
                MessageBox.Show("La gestante tiene infección urinaria a tratar", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Convert.ToDecimal(nudGlucosa.Value) < Convert.ToDecimal(70))
            {
                
                pbAlerta.Visible = true;
                //playSonidoDeAlerta();
                MessageBox.Show("La gestante tiene hipoglucemia", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Convert.ToDecimal(nudGlucosa.Value) < Convert.ToDecimal(130))
            {
                pbAlerta.Visible = true;
                //playSonidoDeAlerta();
                MessageBox.Show("La gestante tiene hiperglucemia", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pbAlerta.Visible = false;
            }

        }
        private void playSonidoDeAlerta()
        {
            SoundPlayer Alerta = new SoundPlayer(@"C:\Users\Usuario\Desktop\Imagenes para el sistema de control de embarazo\SonidoDeAlerta.mp3");
            Alerta.Play();
        }

        private void nudHemoglobina_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(nudHemoglobina.Value) < Convert.ToDecimal(11.5))
            {
                pbAlerta.Visible = true;
                //playSonidoDeAlerta();
                MessageBox.Show("Precaución: La Gestante tiene anemia.", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { pbAlerta.Visible = false; }
        }
    }
}
