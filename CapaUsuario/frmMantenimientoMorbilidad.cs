using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario
{
    public partial class frmMantenimientoMorbilidad : Form
    {
        public frmMantenimientoMorbilidad()
        {
            InitializeComponent();
        }

        private void nuevo() {
            txtDescripcion.Text = "";
            CodigoMantenimientoMorbilidad = "";
            txtDescripcion.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        public string CodigoEstablecimiento { get; set; }
        public string CodigoMantenimientoMorbilidad { get; set; }

        private void frmMantenimientoMorbilidad_Load(object sender, EventArgs e)
        {
            DataTable odtMorbilidad = new DataTable();
            CapaDeNegocios.cMorbilidad oMorbilidad = new CapaDeNegocios.cMorbilidad();

            rbExtrema.Checked = true;
            DataGridViewButtonColumn dgvbEcografia = new DataGridViewButtonColumn();
            dgvbEcografia.Name = "Acción";
            dgvbEcografia.Text = "Eliminar";
            dgvbEcografia.HeaderText = "Acción";
            dgvbEcografia.UseColumnTextForButtonValue = true;

            int columnIndex = 0;

            oMorbilidad.Idtestablecimientosalud = CodigoEstablecimiento;
            odtMorbilidad = oMorbilidad.ListarMorbilidad();

            //odtMorbilidad.Columns.Add("N°", typeof(string));
            //odtMorbilidad.Columns.Add("Id Morbilidad", typeof(string));
            //odtMorbilidad.Columns.Add("Descripción", typeof(string));
            //odtMorbilidad.Columns.Add("Tipo", typeof(string));

            dgvMorbilidad.DataSource = odtMorbilidad;
            dgvMorbilidad.Columns[0].Width = 22;
            dgvMorbilidad.Columns[1].Width = 30;
            dgvMorbilidad.Columns[2].Width = 200;

            dgvMorbilidad.Columns[1].Visible = false;
            dgvMorbilidad.Columns.Insert(columnIndex, dgvbEcografia);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CapaDeNegocios.cMorbilidad oMorbilidad = new CapaDeNegocios.cMorbilidad();
            DataTable odtMorbilidad = new DataTable();
            string tipo = "";

            if (txtDescripcion.Text != "")
            {
                oMorbilidad.Descripcion = txtDescripcion.Text;
                if (rbExtrema.Checked == true) tipo = "Extrema";
                if (rbPotencial.Checked == true) tipo = "Potencial";

                oMorbilidad.Tipo = tipo;
                oMorbilidad.Idtmorbilidad = CodigoMantenimientoMorbilidad;
                oMorbilidad.Idtestablecimientosalud = CodigoEstablecimiento;

                if ( CodigoMantenimientoMorbilidad != "" )
                    odtMorbilidad = oMorbilidad.CrearMorbilidad();
                else
                    odtMorbilidad = oMorbilidad.ModificarMorbilidad();

                foreach (DataRow row in odtMorbilidad.Rows)
                {
                    string respuesta_historia_clinica = row[0].ToString().Trim();
                    string[] words = respuesta_historia_clinica.Split('*');
                    string exito = words[0].ToString();
                    string respuesta = words[1].ToString();

                    if (exito == "1")
                    {
                        MessageBox.Show(respuesta, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        oMorbilidad.Idtestablecimientosalud = CodigoEstablecimiento;
                        odtMorbilidad = oMorbilidad.ListarMorbilidad();
                        dgvMorbilidad.DataSource = odtMorbilidad;
                        nuevo();
                    }
                }
                
            }else
                MessageBox.Show("Porfavor llenar ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void dgvMorbilidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtDescripcion.Text = dgvMorbilidad[1, e.RowIndex].Value.ToString();
                string tipo = dgvMorbilidad[2, e.RowIndex].Value.ToString();

                if (tipo == "Extrema") {
                    rbExtrema.Checked = true;
                    rbPotencial.Checked = false;
                }

                if (tipo == "Potencial")
                {
                    rbExtrema.Checked = false;
                    rbPotencial.Checked = true;
                }

                CodigoMantenimientoMorbilidad = dgvMorbilidad[1, e.RowIndex].Value.ToString();

            }
        }
    }
}
