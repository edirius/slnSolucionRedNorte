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
        string indice = "";

        private void frmMantenimientoMorbilidad_Load(object sender, EventArgs e)
        {
            DataTable odtMorbilidad = new DataTable();
            CapaDeNegocios.cMorbilidad oMorbilidad = new CapaDeNegocios.cMorbilidad();

            rbExtrema.Checked = true;
            //DataGridViewButtonColumn dgvbEcografia = new DataGridViewButtonColumn();
            //dgvbEcografia.Name = "Acción";
            //dgvbEcografia.Text = "Eliminar";
            //dgvbEcografia.HeaderText = "Acción";
            //dgvbEcografia.UseColumnTextForButtonValue = true;

            //int columnIndex = 0;

            oMorbilidad.Idtestablecimientosalud = CodigoEstablecimiento;
            odtMorbilidad = oMorbilidad.ListarMorbilidad();

            //odtMorbilidad.Columns.Add("N°", typeof(string));
            //odtMorbilidad.Columns.Add("Id Morbilidad", typeof(string));
            //odtMorbilidad.Columns.Add("Descripción", typeof(string));
            //odtMorbilidad.Columns.Add("Tipo", typeof(string));

            dgvMorbilidad.DataSource = odtMorbilidad;
            /*
            dgvMorbilidad.Columns[0].Width = 22;
            dgvMorbilidad.Columns[1].Width = 30;
            dgvMorbilidad.Columns[2].Width = 200;
            */
            dgvMorbilidad.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;

            foreach (DataGridViewColumn col in dgvMorbilidad.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            if (dgvMorbilidad.Rows.Count > 0)
                CodigoMantenimientoMorbilidad = dgvMorbilidad.Rows[0].Cells[0].ToString();

            dgvMorbilidad.Columns[1].Visible = false;
            //dgvMorbilidad.Columns.Insert(columnIndex, dgvbEcografia);
            txtDescripcion.Focus();
            CodigoMantenimientoMorbilidad = "";
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

                if (CodigoMantenimientoMorbilidad == "")
                    odtMorbilidad = oMorbilidad.CrearMorbilidad();
                else
                    odtMorbilidad = oMorbilidad.ModificarMorbilidad();

                foreach (DataRow row in odtMorbilidad.Rows)
                {
                    string respuesta_historia_clinica = row[0].ToString().Trim();
                    string[] words = respuesta_historia_clinica.Split('*');
                    string exito = words[0].ToString();
                    string respuesta = words[1].ToString();
                    string idtmorbilidad = words[2].ToString();

                    if (exito == "1")
                    {
                        MessageBox.Show(respuesta, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        oMorbilidad.Idtestablecimientosalud = CodigoEstablecimiento;
                        odtMorbilidad = oMorbilidad.ListarMorbilidad();
                        dgvMorbilidad.DataSource = odtMorbilidad;
                        nuevo();
                        /*Buscando indice del item agregado o modificado*/
                        string item = "";
                        int rowIndex = 0;
                        string searchValue = idtmorbilidad;

                        for (int i = 0; i < dgvMorbilidad.Rows.Count; i++)
                        {
                            item = dgvMorbilidad.Rows[i].Cells[1].Value.ToString();
                            if (item.Trim() == searchValue.Trim())
                            {
                                rowIndex = i;
                                break;
                            }
                        }

                        dgvMorbilidad.Rows[rowIndex].Selected = true;
                    }
                }

            }
            else { 
                MessageBox.Show("Porfavor llenar Descripción Morbilidad. ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescripcion.Focus();
            }


        }

        private void cargar_datos_morbilidad(DataGridViewCellEventArgs e) {

            if (e.RowIndex != -1)
            {
                txtDescripcion.Text = dgvMorbilidad[2, e.RowIndex].Value.ToString();
                string tipo = dgvMorbilidad[2, e.RowIndex].Value.ToString();

                if (tipo == "Extrema")
                {
                    rbExtrema.Checked = true;
                    rbPotencial.Checked = false;
                }

                if (tipo == "Potencial")
                {
                    rbExtrema.Checked = false;
                    rbPotencial.Checked = true;
                }

                CodigoMantenimientoMorbilidad = dgvMorbilidad[1, e.RowIndex].Value.ToString();
                indice = dgvMorbilidad.Rows[e.RowIndex].Cells[0].Value.ToString();

            }

        }

        private void dgvMorbilidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cargar_datos_morbilidad(e);    
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buEliminar_Click(object sender, EventArgs e)
        {
            
            DataTable odtMorbilidad = new DataTable();
            CapaDeNegocios.cMorbilidad oMorbilidad = new CapaDeNegocios.cMorbilidad();

            if (MessageBox.Show("Está seguro que desea eliminar la Morbilidad Nº " + indice, "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                oMorbilidad.Idtmorbilidad = CodigoMantenimientoMorbilidad;
                odtMorbilidad = oMorbilidad.EliminarMorbilidad();
 

                string respuesta_historia_clinica = odtMorbilidad.Rows[0][0].ToString().Trim();

                string[] words = respuesta_historia_clinica.Split('*');

                string exito = words[0].ToString();
                string respuesta = words[1].ToString();

                if (exito == "1") {
                    MessageBox.Show(respuesta, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    oMorbilidad.Idtestablecimientosalud = CodigoEstablecimiento;
                    odtMorbilidad = oMorbilidad.ListarMorbilidad();
                    dgvMorbilidad.DataSource = odtMorbilidad;
                }
                       


                

            }
        }

        private void dgvMorbilidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargar_datos_morbilidad(e);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable odtMorbilidad = new DataTable();
            CapaDeNegocios.cMorbilidad oMorbilidad = new CapaDeNegocios.cMorbilidad();
            string buscar = txtBuscar.Text;
            if (buscar.Length > 0) { 
                oMorbilidad.Descripcion = buscar;
                odtMorbilidad = oMorbilidad.BuscarMorbilidad();
            }
            else{
                oMorbilidad.Idtestablecimientosalud = CodigoEstablecimiento;
                odtMorbilidad = oMorbilidad.ListarMorbilidad();
                
            }

            dgvMorbilidad.DataSource = odtMorbilidad;

        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                rbPotencial.Focus();
        }

        private void rbPotencial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                button1.Focus();
        }
    }
}
