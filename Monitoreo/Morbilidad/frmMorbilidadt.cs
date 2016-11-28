using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoreo
{
    public partial class frmMorbilidad : Form
    {
        public frmMorbilidad()
        {
            InitializeComponent();
        }

        public string Codigo_Historia_Clinica { get; set; }
        public string Id_Historia_Clinica { get; set; }
        public string Fecha { get; set; }
        public string DNI { get; set; }
        public string Nomnbre_Completo { get; set; }
        public string Edad { get; set; }
        public bool Archivado { get; set; }

        public string IdEstablecimiento { get; set; }
        CapaUsuario.frmHistoriaClinica fHC = new CapaUsuario.frmHistoriaClinica("","");
        int i = 0;
        DataTable odtGM = new DataTable();
        int indice = 0;
        CapaDeNegocios.cUtilitarios oUtilitarios = new CapaDeNegocios.cUtilitarios();

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
            DataGridViewButtonColumn dgvbGestanteMorbilidad = new DataGridViewButtonColumn();
            CapaDeNegocios.cMorbilidad oMorbilidad = new CapaDeNegocios.cMorbilidad();
            CapaDeNegocios.cGestanteMorbilidad oGestanteMorbilidad = new CapaDeNegocios.cGestanteMorbilidad();
            DataTable odtMorbilidad = new DataTable();

            txtHistoriaClinica.Text = Codigo_Historia_Clinica;
            dtpFechaHistoriaClinica.Value = Convert.ToDateTime(Fecha);
            txt_DNI.Text = DNI;
            txt_NombreCompleto.Text = Nomnbre_Completo;
            txt_Edad.Text = Edad;


            dgvbMorbilidad.Name = "Acción";
            dgvbMorbilidad.Text = "Agregar";
            dgvbMorbilidad.HeaderText = "Acción";
            dgvbMorbilidad.UseColumnTextForButtonValue = true;

            int columnIndex =4;

            oMorbilidad.Idtestablecimientosalud = IdEstablecimiento;

            odtMorbilidad = oUtilitarios.enumerar_datatable(oMorbilidad.ListarMantenimientoMorbilidad(), 0);

            
            dgvMorbilidad_.DataSource = odtMorbilidad ;
            dgvMorbilidad_.Columns.Insert(columnIndex, dgvbMorbilidad);
            //dgvMorbilidad_.Columns[2].Visible = false;
            dgvMorbilidad_.Columns[0].Width= 40;
            dgvMorbilidad_.Columns[4].Width = 60;
            dgvMorbilidad_.Columns[3].Width = 100;

            cbFiltrar.SelectedItem = cbFiltrar.Items[0];
            txtBuscar_.Focus();
            

            odtGM.Columns.Add("N°", typeof(string));
            odtGM.Columns.Add("Id Morbilidad", typeof(string));
            odtGM.Columns.Add("Fecha", typeof(string));
            odtGM.Columns.Add("Descripción", typeof(string));

            /* Boton eliminar en dgvGestanteMorbilidad */

            dgvbGestanteMorbilidad.Name = "Acción";
            dgvbGestanteMorbilidad.Text = "Eliminar";
            dgvbGestanteMorbilidad.HeaderText = "Acción";
            dgvbGestanteMorbilidad.UseColumnTextForButtonValue = true;

            
            int columnIndex2 = 4;

            oGestanteMorbilidad.idthistoriaclinica = Id_Historia_Clinica;

 

            odtGM = oUtilitarios.enumerar_datatable( oGestanteMorbilidad.ListarGestanteMorbilidad(),0);

            dgvGM.DataSource = odtGM;
            //dgvGM.Columns.Insert(columnIndex2, dgvbGestanteMorbilidad);

            i = dgvGM.Rows.Count;
            dgvGM.Columns[1].Visible = false;
            dgvGM.Columns[0].Width = 60;
            dgvGM.Columns[2].Width = 120;


        }

        private void cbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapaDeNegocios.cMorbilidad oMorbilidad = new CapaDeNegocios.cMorbilidad();
            string seleccionado = this.cbFiltrar.GetItemText(this.cbFiltrar.SelectedItem);

            if (seleccionado == "Todo") {
                oMorbilidad.Idtestablecimientosalud = IdEstablecimiento;
                dgvMorbilidad_.DataSource = oUtilitarios.enumerar_datatable(oMorbilidad.ListarMantenimientoMorbilidad(),0);
                dgvMorbilidad_.Columns[2].Visible = false;

 
            }

            if (seleccionado == "Extrema")
            {
                oMorbilidad.Idtestablecimientosalud = IdEstablecimiento;
                oMorbilidad.Tipo = seleccionado;
                dgvMorbilidad_.DataSource = oUtilitarios.enumerar_datatable( oMorbilidad.ListarMorbilidadXTipo(),0);
                dgvMorbilidad_.Columns[2].Visible = false;
 
            }

            if (seleccionado == "Potencial")
            {
                oMorbilidad.Idtestablecimientosalud = IdEstablecimiento;
                oMorbilidad.Tipo = seleccionado;
                dgvMorbilidad_.DataSource = oUtilitarios.enumerar_datatable( oMorbilidad.ListarMorbilidadXTipo(),0);
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
                dgvMorbilidad_.DataSource = oUtilitarios.enumerar_datatable( oMorbilidad.BuscarMorbilidad(),0);
            }

            if (buscar.Length == 0)
            {
                oMorbilidad.Idtestablecimientosalud = IdEstablecimiento;
                oMorbilidad.Descripcion = buscar;
                dgvMorbilidad_.DataSource = oUtilitarios.enumerar_datatable( oMorbilidad.ListarMantenimientoMorbilidad(),0);
            }


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            if (!Archivado){ 
                odtGM.Rows.Clear();
                dgvGM.DataSource = odtGM;

                dgvGM.Columns[1].Visible = false;
                dgvGM.Columns[0].Width = 60;
                dgvGM.Columns[2].Width = 120;
                txtBuscar_.Text = "";
                i = 0;

                /*
                DataGridViewButtonColumn dgvbGestanteMorbilidad = new DataGridViewButtonColumn();

                dgvbGestanteMorbilidad.Name = "Acción";
                dgvbGestanteMorbilidad.Text = "Eliminar";
                dgvbGestanteMorbilidad.HeaderText = "Acción";
                dgvbGestanteMorbilidad.UseColumnTextForButtonValue = true;


                int columnIndex2 = 4;

                dgvGestanteMorbildad.Columns.Insert(columnIndex2, dgvbGestanteMorbilidad);
                */

                dtpFechaMorbilidad.Focus();
            }
            else
                MessageBox.Show("Control de gestante archivado; No se puede hacer modificaciones.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void agregar_gestante_morbilidad(DataGridView dgvGM, DataGridView dgvM, int posicion ) {


            if (!Archivado)
            {
                /* "N°" , "Id Morbilidad" , "Fecha","Descripción" */
                DataRow drGM = odtGM.NewRow();
                //drGM = odtGM.NewRow();
                string a = "";
                string b = "";
                bool bandera_agregar = false;

                for (int i = 0; i < dgvGM.Rows.Count; i++)
                {
                    a = dgvM[2, posicion].Value.ToString();
                    b = dgvGM[1, i].Value.ToString();
                    if (a.Trim() == b.Trim())
                    {
                        MessageBox.Show("Morbilidad de gestante ya agregada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bandera_agregar = true;
                    }
                }

                if (!bandera_agregar)
                {
                    i++;
                    drGM[0] = i;
                    drGM[1] = dgvM[2, posicion].Value.ToString();
                    drGM[2] = dtpFechaMorbilidad.Value.Date;
                    drGM[3] = dgvM[3, posicion].Value.ToString();


                    odtGM.Rows.InsertAt(drGM, i);
                    dgvGM.DataSource = odtGM;

                    dgvGM.Columns[1].Visible = false;
                    dgvGM.Columns[0].Width = 60;
                    dgvGM.Columns[2].Width = 120;
                }

                //dtpEcografia.Focus();
            }
            else
                MessageBox.Show("Control de gestante archivado; No se puede hacer modificaciones.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvMorbilidad__CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMorbilidad_.CurrentCell.ColumnIndex == 0)
            {
                agregar_gestante_morbilidad(dgvGM, dgvMorbilidad_, e.RowIndex);
                
            }
        }

        private void dgvGM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CapaDeNegocios.cGestanteMorbilidad oGestanteMorbilidad = new CapaDeNegocios.cGestanteMorbilidad();
            DataTable odtGestanteMorbilidad = new DataTable();

            oGestanteMorbilidad.idthistoriaclinica = Id_Historia_Clinica;
            oGestanteMorbilidad.EliminarGestanteMorbilidad();

            if (!Archivado) { 
                for (int i = 0; i < dgvGM.Rows.Count; i++)
                {
                    oGestanteMorbilidad.idtestablecimientosalud = IdEstablecimiento;
                    oGestanteMorbilidad.idtmorbilidad = dgvGM.Rows[i].Cells[1].Value.ToString();
                    oGestanteMorbilidad.idthistoriaclinica = Id_Historia_Clinica;
                    string sfecha = dgvGM.Rows[i].Cells[2].Value.ToString();
                    DateTime fecha = Convert.ToDateTime(sfecha);
                    oGestanteMorbilidad.fecha = fecha ;
                    odtGestanteMorbilidad = oGestanteMorbilidad.CrearGestanteMorbilidad();

                    if (i == dgvGM.Rows.Count - 1) { 
                        foreach (DataRow row in odtGestanteMorbilidad.Rows)
                        {
                            string respuesta_historia_clinica = row[0].ToString().Trim();
                            string[] words = respuesta_historia_clinica.Split('*');
                            string exito = words[0].ToString();
                            string respuesta = words[1].ToString();
                            //string idthistoriaclinica = words[2].ToString();

                            if (exito == "1") { 
                                MessageBox.Show(respuesta, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                oGestanteMorbilidad.idthistoriaclinica = Id_Historia_Clinica;

 

                                odtGestanteMorbilidad = oUtilitarios.enumerar_datatable(oGestanteMorbilidad.ListarGestanteMorbilidad(), 0);
                                dgvGM.DataSource = odtGestanteMorbilidad;
                                dgvGM.Columns[1].Visible = false;
                                dgvGM.Columns[0].Width = 60;
                                dgvGM.Columns[2].Width = 120;
                            }
                        }
                    }
                }
            }else
                MessageBox.Show("Control de gestante archivado; No se puede hacer modificaciones.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtpFechaMorbilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnGuardar.Focus();
        }

        private void txtBuscar__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                dtpFechaMorbilidad.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar_gestantes_morbilidad(indice);
        }

        private void eliminar_gestantes_morbilidad(int e) {

            if (dgvGM.Rows.Count > 0)
            {
                if (!Archivado)
                {
                    int indice2 = e + 1;

                    if (MessageBox.Show("Está seguro que desea eliminar la morbilidad Nº " + indice2, "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {
                        //dgvOdontologia.Rows.RemoveAt(e.RowIndex);
                        odtGM.Rows.RemoveAt(e);
                        i = odtGM.Rows.Count;
                        for (int j = 0; j < odtGM.Rows.Count; j++)
                        {
                            odtGM.Rows[j][0] = j + 1;
                        }

                        dgvGM.DataSource = odtGM;
                        dgvGM.Columns[0].Width = 60;
                        dgvGM.Columns[2].Width = 120;

                        if (dgvGM.Rows.Count > 0) { 
                            dgvGM.Rows[0].Selected = true;
                            dgvGM.CurrentCell = dgvGM.Rows[0].Cells[2];
                            indice = 0;
                        }
                        return;
                    }
                }
                else
                    MessageBox.Show("Control de gestante archivado; No se puede hacer modificaciones.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No hay datos que borrar.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvGM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }
    }
}
