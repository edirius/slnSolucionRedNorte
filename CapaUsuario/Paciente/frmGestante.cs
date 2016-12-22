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
        public string codigohistoriaclinica = "";
        public string nombres = "";
        public string app = "";
        public string apm = "";
        public string DNI = "";
        public DateTime fn ;
        string sdireccion = "";
        string stelefono = "";
        string IdtEstablecimientoSalud="";
        int pagina = 0;
        int cantidad_registros = 10;
        int cantidad_total_registros = 0;
        bool seleccionado = false;

        CapaDeNegocios.Paciente.cPaciente miPaciente = new CapaDeNegocios.Paciente.cPaciente();

        public frmGestante(string idtestablecimientosalud)
        {
            InitializeComponent();
            IdtEstablecimientoSalud = idtestablecimientosalud;
        }

        private void frmGestante_Load(object sender, EventArgs e)
        {
            CargarDatos();
            seleccionado = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idtpaciente == "")
            {
                MessageBox.Show("Debe seleccionar nuevamente los datos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Paciente.frmPaciente fPaciente = new Paciente.frmPaciente();
            fPaciente.RecibirDatos(idtpaciente, codigohistoriaclinica, nombres, app, apm, DNI, fn, sdireccion, stelefono, IdtEstablecimientoSalud, 2);
            if (fPaciente.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idtpaciente == "")
            {
                MessageBox.Show("Debe seleccionar nuevamente los datos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Está seguro que desea eliminar el Maestro Descuentos", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            miPaciente.EliminarPaciente(idtpaciente);
            CargarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

                    if (buscar.Length >= 150)
                        oGestante.apellidopaterno = buscar.Substring(0, 149);

                    if (buscar.Length <= 150)
                        oGestante.apellidopaterno = buscar;

                    dgvGestante.DataSource = oGestante.ListarPacienteXApellidoPaterno();
                    dgvGestante.Columns[1].Visible = false;
                    break; 

                case "Apellido Materno":

                    if (buscar.Length >= 150)
                        oGestante.apellidomaterno = buscar.Substring(0, 149);

                    if (buscar.Length <= 150)
                        oGestante.apellidomaterno = buscar;
                    
                    dgvGestante.DataSource = oGestante.ListarPacienteXApellidoMaterno();
                    dgvGestante.Columns[1].Visible = false;
                    break;

                case "Nombres":
                    if (buscar.Length >= 150)
                        oGestante.nombres = buscar.Substring(0, 149);

                    if (buscar.Length <= 150)
                        oGestante.nombres = buscar;

                    
                    dgvGestante.DataSource = oGestante.ListarPacienteXNombres();
                    dgvGestante.Columns[1].Visible = false;
                    break;

                case "DNI":
                    if (buscar.Length >= 8)
                        oGestante.dni = buscar.Substring(0, 7);

                    if (buscar.Length <= 8)
                        oGestante.dni = buscar;
                     
                    dgvGestante.DataSource = oGestante.ListarPacienteXDNI();
                    dgvGestante.Columns[1].Visible = false;
                    break;

                case "Codigo Historia Clinica":
                    if (buscar.Length >= 10)
                        oGestante.codigohistoriaclinica = buscar.Substring(0,9);

                    if (buscar.Length <= 10)
                        oGestante.codigohistoriaclinica = buscar;

                     
                    dgvGestante.DataSource = oGestante.ListarPacienteXCodigoHistoriaClinica();
                    dgvGestante.Columns[1].Visible = false;
                    break;
            }
            if (buscar.Length == 0)
                dgvGestante.DataSource = oGestante.ListarPacienteXIdEstablecimientoSalud(pagina ,cantidad_registros );
        }

        private void dgvGestante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenar_datos_gestante(e);
        }

        private void dgvGestante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenar_datos_gestante(e);
        }

        private void dgvGestante_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
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

        private void CargarDatos()
        {
            DataTable odtGestante = new DataTable();
            CapaDeNegocios.Paciente.cPaciente oGestante = new CapaDeNegocios.Paciente.cPaciente();
            oGestante.idtestablecimientosalud = IdtEstablecimientoSalud;
            int rowIndex = 0;
            string item = "", searchValue="";

            /*hallando datos de barra de navegacion */
            decimal dcantidad_registros = 0; 
            decimal dcantidad_total_registros = 0;  

            

            oGestante.idtestablecimientosalud = IdtEstablecimientoSalud;
            odtGestante = oGestante.ListarCantidadPacientes();
            cantidad_total_registros = Convert.ToUInt16(odtGestante.Rows[0][0]);

            int total_registros = Convert.ToInt16(odtGestante.Rows[0][0].ToString());

            dcantidad_registros = Convert.ToDecimal(cantidad_registros);
            dcantidad_total_registros = Convert.ToDecimal(cantidad_total_registros);

            int registros = 0;

            if (cantidad_total_registros > 10)
                registros = Math.Abs(cantidad_total_registros - 10);
            else
                registros = 0;


            dgvGestante.DataSource = oGestante.ListarPacienteXIdEstablecimientoSalud(  registros , cantidad_registros);

            /*Buscando indice del item agregado o modificado*/

            searchValue = cantidad_total_registros.ToString();

            for (int i = 0; i < dgvGestante.Rows.Count; i++)
            {
                item = dgvGestante.Rows[i].Cells[0].Value.ToString();
                if (item.Trim() == searchValue.Trim())
                {
                    rowIndex = i;
                    break;
                }
            }

            

            decimal total_registros_paciente = dcantidad_total_registros / dcantidad_registros;
            total_registros_paciente = Math.Ceiling(total_registros_paciente);
            cantidad_total_registros = Convert.ToInt16(total_registros_paciente);

            

            bnpiGestante.Text = cantidad_total_registros.ToString() ;
            bnctGestante.Text = "de " + total_registros_paciente;
            bnGestante.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorMoveFirstItem.Enabled = true;
            dgvGestante.Columns[1].Visible = false;

            cbBuscar.SelectedItem = cbBuscar.Items[0];

            if (dgvGestante.Rows.Count > 0)
            {
                idtpaciente = dgvGestante.Rows[0].Cells[1].Value.ToString();
                codigohistoriaclinica = dgvGestante.Rows[0].Cells[2].Value.ToString();
                nombres = dgvGestante.Rows[0].Cells[3].Value.ToString();
                app = dgvGestante.Rows[0].Cells[4].Value.ToString();
                apm = dgvGestante.Rows[0].Cells[5].Value.ToString();
                DNI = Convert.ToString(dgvGestante.Rows[0].Cells[6].Value);
                fn = Convert.ToDateTime(dgvGestante.Rows[0].Cells[7].Value);
                sdireccion = Convert.ToString(dgvGestante.Rows[0].Cells[8].Value);
                stelefono = Convert.ToString(dgvGestante.Rows[0].Cells[9].Value);
                dgvGestante.Rows[rowIndex].Selected = true;
                dgvGestante.CurrentCell = dgvGestante.Rows[rowIndex].Cells[2];


            }
            else
            {
                MessageBox.Show("No hay registros de gestantes.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void llenar_datos_gestante(DataGridViewCellEventArgs e)
        {
            CapaDeNegocios.Paciente.cPaciente oGestante = new CapaDeNegocios.Paciente.cPaciente();
            if (e.RowIndex != -1)
            {
                idtpaciente = dgvGestante.Rows[e.RowIndex].Cells[1].Value.ToString();
                codigohistoriaclinica = dgvGestante.Rows[e.RowIndex].Cells[2].Value.ToString();
                nombres = dgvGestante.Rows[e.RowIndex].Cells[3].Value.ToString();
                app = dgvGestante.Rows[e.RowIndex].Cells[4].Value.ToString();
                apm = dgvGestante.Rows[e.RowIndex].Cells[5].Value.ToString();
                DNI = Convert.ToString(dgvGestante.Rows[e.RowIndex].Cells[6].Value);
                fn = Convert.ToDateTime(dgvGestante.Rows[e.RowIndex].Cells[7].Value);
                sdireccion = Convert.ToString(dgvGestante.Rows[e.RowIndex].Cells[8].Value);
                stelefono = Convert.ToString(dgvGestante.Rows[e.RowIndex].Cells[9].Value);
                seleccionado = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmGestante_Activated(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }

        private void bnGestante_RefreshItems(object sender, EventArgs e)
        {

        }

        private void llenar_datos_gestamte(int indice)
        {
            idtpaciente = dgvGestante.Rows[indice].Cells[1].Value.ToString();
            codigohistoriaclinica = dgvGestante.Rows[indice].Cells[2].Value.ToString();
            nombres = dgvGestante.Rows[indice].Cells[3].Value.ToString();
            app = dgvGestante.Rows[indice].Cells[4].Value.ToString();
            apm = dgvGestante.Rows[indice].Cells[5].Value.ToString();
            DNI = Convert.ToString(dgvGestante.Rows[indice].Cells[6].Value);
            fn = Convert.ToDateTime(dgvGestante.Rows[indice].Cells[7].Value);
            sdireccion = Convert.ToString(dgvGestante.Rows[indice].Cells[8].Value);
            stelefono = Convert.ToString(dgvGestante.Rows[indice].Cells[9].Value);
            
        }

        private void buAgregar_Click(object sender, EventArgs e)
        {
            CapaDeNegocios.Paciente.cPaciente oGestante = new CapaDeNegocios.Paciente.cPaciente();
            int indice = 0;
            if ( dgvGestante.Rows.Count >0 && !seleccionado)
            {
                indice = dgvGestante.Rows.Count-1;
                llenar_datos_gestamte(indice);
                DialogResult = DialogResult.OK;
            }

            if (dgvGestante.Rows.Count == 0)
                MessageBox.Show("No hay gestantes disponibles.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            if (seleccionado)
                DialogResult = DialogResult.OK;
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            Paciente.frmPaciente fPaciente = new Paciente.frmPaciente();
            fPaciente.RecibirDatos("", "", "", "", "", "", DateTime.Today, "", "", IdtEstablecimientoSalud, 1);
            fPaciente.MdiParent = this.MdiParent;
            if (fPaciente.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CargarDatos();
                dgvGestante.Focus();
            }
        }

        private void dgvGestante_KeyDown(object sender, KeyEventArgs e)
        {
            int indice;


            if ((e.KeyData & Keys.KeyCode) == Keys.Enter)
            {
                if (dgvGestante.Rows.Count > 0 && !seleccionado)
                {
                    indice = dgvGestante.CurrentRow.Index;
                    llenar_datos_gestamte(indice);
                    DialogResult = DialogResult.OK;
                }

                if (dgvGestante.Rows.Count == 0)
                    MessageBox.Show("No hay gestantes disponibles.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (seleccionado)
                    DialogResult = DialogResult.OK;
                return;
            }
            else
                base.OnKeyDown(e);
        }
    }
}
