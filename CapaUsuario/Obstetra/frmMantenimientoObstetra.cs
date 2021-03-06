﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario.Obstetra
{
    public partial class frmMantenimientoObstetra : Form
    {
        string sidtobstetra = "";
        string snombres = "";
        string sapellidopaterno = "";
        string sapellidomaterno = "";
        string ssexo = "";
        string sdni = "";
        DateTime sfechanacimiento;
        string sdireccion = "";
        string stelefono = "";
        string stituloprofesional = "";
        string sidtestablecimientosalud = "";
        string susuario = "";
        string spassword = "";
        CapaDeNegocios.Obstetra.cObstetra miObstetra = new CapaDeNegocios.Obstetra.cObstetra();

        public frmMantenimientoObstetra()
        {
            InitializeComponent();
        }

        private void frmMantenimientoPaciente_Load(object sender, EventArgs e)
        {
            sidtestablecimientosalud = cVariables.v_idestablecimientosalud; ;
            CargarDatos();
        }

        private void dgvObstetras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvObstetras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sidtobstetra = Convert.ToString(dgvObstetras.Rows[e.RowIndex].Cells["idtobstetra"].Value);
            snombres = Convert.ToString(dgvObstetras.Rows[e.RowIndex].Cells["nombres"].Value);
            sapellidopaterno = Convert.ToString(dgvObstetras.Rows[e.RowIndex].Cells["apellidopaterno"].Value);
            sapellidomaterno = Convert.ToString(dgvObstetras.Rows[e.RowIndex].Cells["apellidomaterno"].Value);
            ssexo = Convert.ToString(dgvObstetras.Rows[e.RowIndex].Cells["sexo"].Value);
            sdni = Convert.ToString(dgvObstetras.Rows[e.RowIndex].Cells["dni"].Value);
            sfechanacimiento = Convert.ToDateTime(dgvObstetras.Rows[e.RowIndex].Cells["fechanacimiento"].Value);
            sdireccion = Convert.ToString(dgvObstetras.Rows[e.RowIndex].Cells["direccion"].Value);
            stelefono = Convert.ToString(dgvObstetras.Rows[e.RowIndex].Cells["telefono"].Value);
            stituloprofesional = Convert.ToString(dgvObstetras.Rows[e.RowIndex].Cells["tituloprofesional"].Value);
            sidtestablecimientosalud = Convert.ToString(dgvObstetras.Rows[e.RowIndex].Cells["idtestablecimientosalud"].Value);
            susuario = Convert.ToString(dgvObstetras.Rows[e.RowIndex].Cells["usuario"].Value);
            spassword = Convert.ToString(dgvObstetras.Rows[e.RowIndex].Cells["password"].Value);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmObstetra fObstetra = new frmObstetra();
            fObstetra.RecibirDatos("", "", "", "", "", "", DateTime.Today, "", "", "", sidtestablecimientosalud, "", "", 1);
            if (fObstetra.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (sidtobstetra == "")
            {
                MessageBox.Show("Debe seleccionar nuevamente los datos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmObstetra fObstetra = new frmObstetra();
            fObstetra.RecibirDatos(sidtobstetra, snombres, sapellidopaterno, sapellidomaterno, ssexo, sdni, sfechanacimiento, sdireccion, stelefono, stituloprofesional, sidtestablecimientosalud, susuario, spassword, 2);
            if (fObstetra.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (sidtobstetra == "")
                {
                    MessageBox.Show("Debe seleccionar nuevamente los datos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Está seguro que desea eliminar la Obstetra", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                miObstetra.EliminarObstetra(sidtobstetra);
                CargarDatos();
            }
            catch
            {
                MessageBox.Show("La obstetra no se puede eliminar.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatos()
        {
            try
            {
                dgvObstetras.Rows.Clear();
                foreach (DataRow row in miObstetra.ListarObstetra().Select("idtestablecimientosalud = '" + sidtestablecimientosalud + "'"))
                {
                    dgvObstetras.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString(), row[10].ToString(), row[11].ToString(), row[12].ToString());
                }
                if (dgvObstetras.Rows.Count > 0)
                {
                    dgvObstetras.Rows[0].Selected = true;
                    DataGridViewCellEventArgs ceo = new DataGridViewCellEventArgs(0, 0);
                    dgvObstetras_CellClick(dgvObstetras, ceo);
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
    }
}
