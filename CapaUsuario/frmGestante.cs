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

        public frmGestante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmGestante_Load(object sender, EventArgs e)
        {
            DataTable odtGestante = new DataTable();
            CapaDeNegocios.Paciente.cPaciente oGestante = new CapaDeNegocios.Paciente.cPaciente();
            string codigoestablecimiento = "E0003";

            dgvGestante.DataSource = oGestante.ListarPacienteTodos();

            idtpaciente = dgvGestante.Rows[0].Cells[0].Value.ToString();
            nombres = dgvGestante.Rows[0].Cells[1].Value.ToString();
            app = dgvGestante.Rows[0].Cells[2].Value.ToString();
            apm = dgvGestante.Rows[0].Cells[3].Value.ToString();
            fn = Convert.ToDateTime(dgvGestante.Rows[0].Cells[5].Value);
            DNI = Convert.ToString(dgvGestante.Rows[0].Cells[4].Value);

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CapaDeNegocios.Paciente.cPaciente oGestante = new CapaDeNegocios.Paciente.cPaciente();
            string buscar = txtBuscar.Text;
            oGestante.apellidopaterno = buscar;

            if (buscar.Length > 4)
                dgvGestante.DataSource = oGestante.ListarPacienteXApellidoPaterno();

            if (buscar.Length == 0)
                dgvGestante.DataSource = oGestante.ListarPacienteTodos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             DialogResult = DialogResult.OK;
        }

        private void dgvGestante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CapaDeNegocios.Paciente.cPaciente oGestante = new CapaDeNegocios.Paciente.cPaciente();

            if (e.RowIndex != -1)
            {
                idtpaciente = dgvGestante.Rows[e.RowIndex].Cells[0].Value.ToString();
                nombres = dgvGestante.Rows[e.RowIndex].Cells[1].Value.ToString();
                app = dgvGestante.Rows[e.RowIndex].Cells[2].Value.ToString();
                apm = dgvGestante.Rows[e.RowIndex].Cells[3].Value.ToString();
                fn = Convert.ToDateTime( dgvGestante.Rows[e.RowIndex].Cells[5].Value);
                DNI = Convert.ToString(dgvGestante.Rows[e.RowIndex].Cells[4].Value);
                 
            }
        }

        private void dgvGestante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CapaDeNegocios.Paciente.cPaciente oGestante = new CapaDeNegocios.Paciente.cPaciente();

            if (e.RowIndex != -1)
            {
                idtpaciente = dgvGestante.Rows[e.RowIndex].Cells[0].Value.ToString();
                nombres = dgvGestante.Rows[e.RowIndex].Cells[1].Value.ToString();
                app = dgvGestante.Rows[e.RowIndex].Cells[2].Value.ToString();
                apm = dgvGestante.Rows[e.RowIndex].Cells[3].Value.ToString();
                fn = Convert.ToDateTime(dgvGestante.Rows[e.RowIndex].Cells[5].Value);
                DNI = Convert.ToString(dgvGestante.Rows[e.RowIndex].Cells[4].Value);

            }
        }
    }
}
