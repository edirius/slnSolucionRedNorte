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

namespace CapaUsuario.Bateria
{
    public partial class frmBateria : Form
    {
        cBateria miBateria = new cBateria();
        cSiguienteCodigo micodigo = new cSiguienteCodigo();
        DataTable Tabla = new DataTable();
        public string IdHistoria;
        public frmBateria(string IdtHistoriaClinica)
        {
            InitializeComponent();
            ActualizarLista();
            IdHistoria = IdtHistoriaClinica;

        }
        public void ActualizarLista()
        {
            dgvListaBateria.DataSource = miBateria.ListarBateria();
            //Tabla = micodigo.SiguientesCodigo("tbateria", idtestablecimientosalud);
            //txtCodigo.Text = Tabla.Rows[0][0].ToString();
        }
        private void ConfiguracionInicial()
        {
            //Tabla = miEstablecimiento.SiguienteCodigo();
            //txtCodigo.Text = Tabla.Rows[0][0].ToString();
            ////txtCodigo.Text = "";
            //txtDescripcion.Text = "";
            //txtDireccion.Text = "";
            //txtRenaes.Text = "";
            //txtDescripcion.Focus();
        }
        public void Agregar()
        {
            //try
            //{
            //    if (txtDescripcion.Text != "")
            //    {
            //        miEstablecimiento.IdEstablecimientoSalud = txtCodigo.Text;
            //        miEstablecimiento.IdMicrored = cbMicrored.SelectedValue.ToString();
            //        miEstablecimiento.Descripcion = txtDescripcion.Text;
            //        miEstablecimiento.Direccion = txtDireccion.Text;
            //        miEstablecimiento.Renaes = txtRenaes.Text;
            //        Tabla = miEstablecimiento.AgregarEstablecimiento();
            //        respuesta = Tabla.Rows[0][0].ToString();
            //        mensaje = Tabla.Rows[0][1].ToString();

            //        if (respuesta == "1")
            //        {
            //            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            ConfiguracionInicial();
            //            ActualizarLista();
            //        }
            //        else if (respuesta == "0")
            //        {
            //            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            ConfiguracionInicial();
            //        }
            //    }
            //    else
            //        MessageBox.Show("Por favor llene los campos necesarios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            //catch
            //{
            //    MessageBox.Show("Ya existe un establecimiento con la misma descripción", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


        }
        public void Modificar()
        {
            //if (txtDescripcion.Text != "")
            //{
            //    miEstablecimiento.IdEstablecimientoSalud = txtCodigo.Text;
            //    miEstablecimiento.IdMicrored = cbMicrored.SelectedValue.ToString();
            //    miEstablecimiento.Descripcion = txtDescripcion.Text;
            //    miEstablecimiento.Direccion = txtDireccion.Text;
            //    miEstablecimiento.Renaes = txtRenaes.Text;
            //    Tabla = miEstablecimiento.ModificarEstablecimiento();
            //    respuesta = Tabla.Rows[0][0].ToString();
            //    mensaje = Tabla.Rows[0][1].ToString();
            //    if (respuesta == "1")
            //    {
            //        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        ConfiguracionInicial();
            //        ActualizarLista();
            //    }
            //    else if (respuesta == "0")
            //    {
            //        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        ConfiguracionInicial();
            //    }
            //}
            //else
            //    MessageBox.Show("Por favor llene los campos necesarios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void Eliminar()
        {
            //miEstablecimiento.IdEstablecimientoSalud = txtCodigo.Text;
            //miEstablecimiento.Descripcion = txtDescripcion.Text;
            //Tabla = miEstablecimiento.EliminarEstablecimiento();
            //respuesta = Tabla.Rows[0][0].ToString();
            //mensaje = Tabla.Rows[0][1].ToString();
            //if (MessageBox.Show("¿Desea Eliminar? Los Datos no podran ser recuperados", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            //    if (respuesta == "1")
            //    {
            //        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        ConfiguracionInicial();
            //        ActualizarLista();
            //    }

            //    else if (respuesta == "0")
            //    {
            //        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        ConfiguracionInicial();
            //    }
            //    else
            //    {
            //        /*NO HACER NADA*/
            //    }

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void frmBateria_Load(object sender, EventArgs e)
        {

        }
    }
}
