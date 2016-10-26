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
        }
        public void ActualizarLista()
        {
            dgvListarMicrored.DataSource = miMicrored.ListarMicrored();
        }
        private void ConfiguracionInicial()
        {
            txtMicrored.Text = "";
            txtDireccion.Text = "";
            txtMicrored.Focus();
        }
        public void AgregarTipoDocumento()
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
        public void ModificarTipoDocumento()
        {
            //if (txtDescripcion.Text != "")
            //{
            //    int valor = dgvListarTipoDoc.CurrentCell.RowIndex;
            //    miTipoDocumento.CodigoTipoDocumento = int.Parse(dgvListarTipoDoc[1, valor].Value.ToString());
            //    miTipoDocumento.Descripcion = txtDescripcion.Text;
            //    Tabla = miTipoDocumento.ModificarTipoDocumento();
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
        private void EliminarTipoDocumento()
        {
        //    int valor = dgvListarTipoDoc.CurrentCell.RowIndex;
        //    miTipoDocumento.CodigoTipoDocumento = int.Parse(dgvListarTipoDoc[1, valor].Value.ToString());
        //    miTipoDocumento.Descripcion = txtDescripcion.Text;
        //    Tabla = miTipoDocumento.EliminarTipoDocumento();
        //    respuesta = Tabla.Rows[0][0].ToString();
        //    mensaje = Tabla.Rows[0][1].ToString();
        //    if (respuesta == "1")
        //    {
        //        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        MessageBox.Show(mensaje);
        //        ConfiguracionInicial();
        //        ActualizarLista();
        //    }
        //    else if (respuesta == "0")
        //    {
        //        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        ConfiguracionInicial();
        //    }
        //}

    }
}
