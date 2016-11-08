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
    public partial class frmMorbilidad : Form
    {
        public frmMorbilidad()
        {
            InitializeComponent();
        }

        public string Codigo_Historia_Clinica { get; set; }
        public string Fecha { get; set; }
        public string DNI { get; set; }
        public string Nomnbre_Completo { get; set; }
        public string Edad { get; set; }
        public string IdEstablecimiento { get; set; }
        int i = 0;
    
        private void frmMorbilidad_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void frmMorbilidad_Load_1(object sender, EventArgs e)
        {
            DataGridViewButtonColumn dgvbMorbilidad = new DataGridViewButtonColumn();
            CapaDeNegocios.cMorbilidad oMorbilidad = new CapaDeNegocios.cMorbilidad();


            txtHistoriaClinica.Text = Codigo_Historia_Clinica;
            dtpFecha.Value = Convert.ToDateTime(Fecha);
            txt_DNI.Text = DNI;
            txt_NombreCompleto.Text = Nomnbre_Completo;
            txt_Edad.Text = Edad;


            dgvbMorbilidad.Name = "Acción";
            dgvbMorbilidad.Text = "Agregar";
            dgvbMorbilidad.HeaderText = "Acción";
            dgvbMorbilidad.UseColumnTextForButtonValue = true;

            int columnIndex =4;

            oMorbilidad.Idtestablecimientosalud = IdEstablecimiento;
            dgvMorbilidad_.DataSource = oMorbilidad.ListarMorbilidad();
            dgvMorbilidad_.Columns.Insert(columnIndex, dgvbMorbilidad);
            //dgvMorbilidad_.Columns[2].Visible = false;
            dgvMorbilidad_.Columns[0].Width= 40;
            dgvMorbilidad_.Columns[4].Width = 60;
            dgvMorbilidad_.Columns[3].Width = 100;

            cbFiltrar.SelectedItem = cbFiltrar.Items[0];
            txtBuscar_.Focus();
        }

        private void cbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapaDeNegocios.cMorbilidad oMorbilidad = new CapaDeNegocios.cMorbilidad();
            string seleccionado = this.cbFiltrar.GetItemText(this.cbFiltrar.SelectedItem);

            if (seleccionado == "Todo") {
                oMorbilidad.Idtestablecimientosalud = IdEstablecimiento;
                dgvMorbilidad_.DataSource = oMorbilidad.ListarMorbilidad();
                dgvMorbilidad_.Columns[2].Visible = false;
            }

            if (seleccionado == "Extrema")
            {
                oMorbilidad.Idtestablecimientosalud = IdEstablecimiento;
                oMorbilidad.Tipo = seleccionado;
                dgvMorbilidad_.DataSource = oMorbilidad.ListarMorbilidadXTipo();
                dgvMorbilidad_.Columns[2].Visible = false;
            }

            if (seleccionado == "Potencial")
            {
                oMorbilidad.Idtestablecimientosalud = IdEstablecimiento;
                oMorbilidad.Tipo = seleccionado;
                dgvMorbilidad_.DataSource = oMorbilidad.ListarMorbilidadXTipo();
                dgvMorbilidad_.Columns[2].Visible = false;
            }

        }

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            CapaDeNegocios.cMorbilidad oMorbilidad = new CapaDeNegocios.cMorbilidad();
            string buscar = txtBuscar_.Text;

            if (buscar.Length > 1) {
                oMorbilidad.Idtestablecimientosalud = IdEstablecimiento;
                oMorbilidad.Descripcion = buscar;
                dgvMorbilidad_.DataSource = oMorbilidad.BuscarMorbilidad();
            }

            if (buscar.Length == 0)
            {
                oMorbilidad.Idtestablecimientosalud = IdEstablecimiento;
                oMorbilidad.Descripcion = buscar;
                dgvMorbilidad_.DataSource = oMorbilidad.ListarMorbilidad();
            }


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            dgvPacienteMorbilidad.Rows.Clear();
            txtBuscar.Text = "";
            txtBuscar.Focus();


        }

        private void agregar_gestante_morbilidad(DataGridView dgvGM, DataGridView dgvM, int posicion ) {
            DataTable odtGM = new DataTable();
            DataRow drGM = odtGM.NewRow();

            odtGM.Columns.Add("N°", typeof(string));
            odtGM.Columns.Add("Id Morbilidad", typeof(string));
            odtGM.Columns.Add("Descripción", typeof(string));

            drGM = odtGM.NewRow();

            //i = odtGM.Rows.Count;
            i++;
            drGM[0] = i;
            drGM[1] = dgvM[0, posicion].Value.ToString(); ;
            drGM[2] = dgvM[1, posicion].Value.ToString(); ;

            odtGM.Rows.InsertAt(drGM, i);
            dgvGM.DataSource = odtGM;
            //dtpEcografia.Focus();
        }

        private void dgvMorbilidad__CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMorbilidad_.CurrentCell.ColumnIndex == 0)
            {
                agregar_gestante_morbilidad(dgvGestanteMorbildad, dgvMorbilidad_, e.RowIndex);
                
            }
        }
    }
}
