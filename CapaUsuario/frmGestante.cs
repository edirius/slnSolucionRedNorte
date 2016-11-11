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
    public partial class frmGestante : Form
    {
        
        public string idtpaciente = "";
        public string DNI = "";
        public string nombres = "";
        public string app = "";
        public string apm = "";
        public DateTime fn ;
        string IdtEstablecimientoSalud="";
        int pagina = 0;
        int cantidad_registros = 30;
        int cantidad_total_registros = 0;

        public frmGestante(string idtestablecimientosalud)
        {
            InitializeComponent();
            IdtEstablecimientoSalud = idtestablecimientosalud;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmGestante_Load(object sender, EventArgs e)
        {
            DataTable odtGestante = new DataTable();
            CapaDeNegocios.Paciente.cPaciente oGestante = new CapaDeNegocios.Paciente.cPaciente();

            frmMenu fMenu = new frmMenu();

            oGestante.idtestablecimientosalud = IdtEstablecimientoSalud;

            dgvGestante.DataSource = oGestante.ListarPacienteXIdEstablecimientoSalud(pagina, cantidad_registros);

            if (dgvGestante.Rows.Count > 0)
            {

                idtpaciente = dgvGestante.Rows[0].Cells[1].Value.ToString();
                nombres = dgvGestante.Rows[0].Cells[2].Value.ToString();
                app = dgvGestante.Rows[0].Cells[3].Value.ToString();
                apm = dgvGestante.Rows[0].Cells[4].Value.ToString();
                DNI = Convert.ToString(dgvGestante.Rows[0].Cells[5].Value);
                fn = Convert.ToDateTime(dgvGestante.Rows[0].Cells[6].Value);
            }
            else {
                MessageBox.Show("No hay registros de gestantes.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            oGestante.idtestablecimientosalud = IdtEstablecimientoSalud;
            odtGestante = oGestante.ListarCantidadPacientes();
            cantidad_total_registros = Convert.ToUInt16(odtGestante.Rows[0][0]);

            /*hallando datos de barra de navegacion */
            decimal dcantidad_registros = Convert.ToDecimal(cantidad_registros);
            decimal dcantidad_total_registros = Convert.ToDecimal(cantidad_total_registros);

            int total_registros = Convert.ToInt16( odtGestante.Rows[0][0].ToString());
            decimal total_registros_paciente = dcantidad_total_registros / dcantidad_registros;
            total_registros_paciente = Math.Ceiling(total_registros_paciente);
            cantidad_total_registros = Convert.ToInt16( total_registros_paciente);

            bnpiGestante.Text = "1";
            bnctGestante.Text = "de " + total_registros_paciente;
            bnGestante.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorMoveFirstItem.Enabled = true;
            dgvGestante.Columns[1].Visible = false;

            cbBuscar.SelectedItem = cbBuscar.Items[0];

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CapaDeNegocios.Paciente.cPaciente oGestante = new CapaDeNegocios.Paciente.cPaciente();
            string buscar = txtBuscar.Text;
            string seleccionado = this.cbBuscar.GetItemText(this.cbBuscar.SelectedItem);
            oGestante.apellidopaterno = buscar;
            oGestante.idtestablecimientosalud = IdtEstablecimientoSalud;

            switch (seleccionado) {
                case "Apellido Paterno" :
                    oGestante.apellidopaterno = buscar;
                    dgvGestante.DataSource = oGestante.ListarPacienteXApellidoPaterno();
                    dgvGestante.Columns[1].Visible = false;
                    break; 

                case "Apellido Materno":
                    oGestante.apellidomaterno = buscar;
                    dgvGestante.DataSource = oGestante.ListarPacienteXApellidoMaterno();
                    dgvGestante.Columns[1].Visible = false;
                    break;

                case "Nombres":
                    oGestante.nombres = buscar;
                    dgvGestante.DataSource = oGestante.ListarPacienteXNombres();
                    dgvGestante.Columns[1].Visible = false;
                    break;

                case "DNI":
                    oGestante.dni = buscar;
                    dgvGestante.DataSource = oGestante.ListarPacienteXDNI();
                    dgvGestante.Columns[1].Visible = false;
                    break;
            }


            if (buscar.Length == 0)
                dgvGestante.DataSource = oGestante.ListarPacienteXIdEstablecimientoSalud(pagina ,cantidad_registros );
        }

        private void button1_Click(object sender, EventArgs e)
        {
             DialogResult = DialogResult.OK;
        }

        private void llenar_datos_gestante (DataGridViewCellEventArgs e)
        {
            CapaDeNegocios.Paciente.cPaciente oGestante = new CapaDeNegocios.Paciente.cPaciente();

            if (e.RowIndex != -1)
            {
                idtpaciente = dgvGestante.Rows[e.RowIndex].Cells[1].Value.ToString();
                nombres = dgvGestante.Rows[e.RowIndex].Cells[2].Value.ToString();
                app = dgvGestante.Rows[e.RowIndex].Cells[3].Value.ToString();
                apm = dgvGestante.Rows[e.RowIndex].Cells[4].Value.ToString();
                DNI = Convert.ToString(dgvGestante.Rows[e.RowIndex].Cells[5].Value);
                fn = Convert.ToDateTime(dgvGestante.Rows[e.RowIndex].Cells[6].Value);

            }

        }

        private void dgvGestante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvGestante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            CapaDeNegocios.Paciente.cPaciente oGestante = new CapaDeNegocios.Paciente.cPaciente();
            int panel_pagina = Convert.ToInt16(bnpiGestante.Text);

            if ( panel_pagina  < cantidad_total_registros){
                panel_pagina++;
                bnpiGestante.Text = panel_pagina.ToString();
                int pagina = (Convert.ToInt16(bnpiGestante.Text) - 1) * cantidad_registros;
                oGestante.idtestablecimientosalud = IdtEstablecimientoSalud;
                dgvGestante.DataSource = oGestante.ListarPacienteXIdEstablecimientoSalud(pagina, cantidad_registros);
            }
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            CapaDeNegocios.Paciente.cPaciente oGestante = new CapaDeNegocios.Paciente.cPaciente();
            bnpiGestante.Text = cantidad_total_registros.ToString();
            int pagina = (Convert.ToInt16(bnpiGestante.Text) - 1) * cantidad_registros;
            oGestante.idtestablecimientosalud = IdtEstablecimientoSalud;
            dgvGestante.DataSource = oGestante.ListarPacienteXIdEstablecimientoSalud( pagina , cantidad_registros);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            CapaDeNegocios.Paciente.cPaciente oGestante = new CapaDeNegocios.Paciente.cPaciente();
            if ( Convert.ToInt16(bnpiGestante.Text) > 1  && Convert.ToInt16(bnpiGestante.Text) <= cantidad_total_registros ) { 
                int i = Convert.ToInt16(bnpiGestante.Text) ;
                i--;
                bnpiGestante.Text = i.ToString();
                int pagina = (Convert.ToInt16(bnpiGestante.Text)-1) * cantidad_registros;
                oGestante.idtestablecimientosalud = IdtEstablecimientoSalud;
                dgvGestante.DataSource = oGestante.ListarPacienteXIdEstablecimientoSalud(pagina, cantidad_registros);
            }
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            bnpiGestante.Text = "1";
            CapaDeNegocios.Paciente.cPaciente oGestante = new CapaDeNegocios.Paciente.cPaciente();

            int pagina = (Convert.ToInt16(bnpiGestante.Text)-1) * cantidad_registros;
            oGestante.idtestablecimientosalud = IdtEstablecimientoSalud;
            dgvGestante.DataSource = oGestante.ListarPacienteXIdEstablecimientoSalud( pagina, cantidad_registros);
        }

        private void bnGestante_RefreshItems(object sender, EventArgs e)
        {

        }

        private void dgvGestante_DoubleClick(object sender, EventArgs e)
        {
            
            
        }

        private void dgvGestante_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvGestante_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvGestante_DoubleClick_1(object sender, EventArgs e)
        {
            
        }

        private void dgvGestante_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            llenar_datos_gestante(e);
        }

        private void dgvGestante_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            llenar_datos_gestante(e);
        }

        private void dgvGestante_DoubleClick_2(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CapaDeNegocios.Paciente.cPaciente oGestante = new CapaDeNegocios.Paciente.cPaciente();
            Paciente.frmMantenimientoPaciente fMantenimientoPaciente = new Paciente.frmMantenimientoPaciente(IdtEstablecimientoSalud);
            fMantenimientoPaciente.ShowDialog();
            oGestante.idtestablecimientosalud = IdtEstablecimientoSalud;
            dgvGestante.DataSource = oGestante.ListarPacienteXIdEstablecimientoSalud(pagina, 50);
        }
    }
}
