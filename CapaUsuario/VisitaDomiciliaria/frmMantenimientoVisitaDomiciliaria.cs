﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario.VisitaDomiciliaria
{
    public partial class frmMantenimientoVisitaDomiciliaria : Form
    {
        int saccion = 0;
        string stipo = "";
        string sidtvisitadomiciliariagestante = "";
        string sidtvisitadomiciliariapuerperarn = "";
        string sidthistoriaclinica = "";
        string sidtestablecimientosalud = "";
        string sidtobstetra = "";
        public bool Archivado { get; set; }

        CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaGestante miVisitaDomiciliariaGestante = new CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaGestante();
        CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaPuerperaRN miVisitaDomiciliariaPuerperaRN = new CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaPuerperaRN();

        public frmMantenimientoVisitaDomiciliaria(string pidthistoriaclinica)
        {
            sidthistoriaclinica = pidthistoriaclinica;
            InitializeComponent();
        }

        private void frmVisitaDomiciliaria_Load(object sender, EventArgs e)
        {
            sidtobstetra = cVariables.v_idobstetra;
            sidtestablecimientosalud = cVariables.v_idestablecimientosalud;
            VerificarTerminoGestacion();
            tabControl1_SelectedIndexChanged(sender, e);
            btnNuevo_Click(sender, e);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            saccion = 1;
            sidtvisitadomiciliariagestante = "";
            sidtvisitadomiciliariapuerperarn = "";
            if (stipo == "GESTANTE")
            {
                dtpFechaGestante.Value = DateTime.Today;
                cboMotivoGestante.SelectedIndex = -1;
                txtFuaGestante.Text = "";
                txtDetalleGestante.Text = "";
                dtpFechaGestante.Select();
                dtpFechaGestante.Focus();
            }
            else if (stipo == "PUERPERIA/R.NACIDO")
            {
                dtpFechaPuerpera.Value = DateTime.Today;
                cboMotivoPuerpera.SelectedIndex = -1;
                txtFuaPuerpera.Text = "";
                txtDetallePuerpera.Text = "";
                cboMotivoRN.SelectedIndex = -1;
                txtFuaRN.Text = "";
                txtDetalleRN.Text = "";
                dtpFechaPuerpera.Select();
                dtpFechaPuerpera.Focus();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!Archivado) { 
                    bool bOk = false;
                    if (stipo == "GESTANTE")
                    {
                        if (cboMotivoGestante.Text == "")
                        {
                            MessageBox.Show("Visita Domiciliaria no tiene un Motivo.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        miVisitaDomiciliariaGestante.idtvisitadomiciliariagestante = sidtvisitadomiciliariagestante;
                        miVisitaDomiciliariaGestante.fecha = dtpFechaGestante.Value;
                        miVisitaDomiciliariaGestante.motivo = cboMotivoGestante.Text;
                        miVisitaDomiciliariaGestante.fua = txtFuaGestante.Text;
                        miVisitaDomiciliariaGestante.detalle = txtDetalleGestante.Text;
                        miVisitaDomiciliariaGestante.idthistoriaclinica = sidthistoriaclinica;
                        miVisitaDomiciliariaGestante.idtobstetra = sidtobstetra;
                        if (saccion == 1)
                        {
                            CapaDeNegocios.cSiguienteCodigo miSiguienteCodigo = new CapaDeNegocios.cSiguienteCodigo();
                            foreach (DataRow row in miSiguienteCodigo.SiguientesCodigo("tvisitadomiciliariagestante", sidtestablecimientosalud).Rows)
                            {
                                miVisitaDomiciliariaGestante.idtvisitadomiciliariagestante = row[0].ToString();
                            }
                            miVisitaDomiciliariaGestante.CrearVisitaDomiciliariaGestante(miVisitaDomiciliariaGestante);
                            MessageBox.Show("Visita Domiciliaria Durante el Embarazo registrada correctamente.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bOk = true;
                        }
                        if (saccion == 2)
                        {
                            miVisitaDomiciliariaGestante.ModificarVisitaDomiciliariaGestante(miVisitaDomiciliariaGestante);
                            MessageBox.Show("Visita Domiciliaria Durante el Embarazo modificada correctamente.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bOk = true;
                        }
                    }
                    else if (stipo == "PUERPERIA/R.NACIDO")
                    {
                        if (cboMotivoPuerpera.Text == "")
                        {
                            MessageBox.Show("Visita Domiciliaria no tiene un Motivo.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        miVisitaDomiciliariaPuerperaRN.idtvisitadomiciliariapuerperarn = sidtvisitadomiciliariapuerperarn;
                        miVisitaDomiciliariaPuerperaRN.fecha = dtpFechaPuerpera.Value;
                        miVisitaDomiciliariaPuerperaRN.motivopuerpera = cboMotivoPuerpera.Text;
                        miVisitaDomiciliariaPuerperaRN.fuapuerpera = txtFuaPuerpera.Text;
                        miVisitaDomiciliariaPuerperaRN.detallepuerpera = txtDetallePuerpera.Text;
                        miVisitaDomiciliariaPuerperaRN.motivoreciennacido = cboMotivoRN.Text;
                        miVisitaDomiciliariaPuerperaRN.fuareciennacido = txtFuaRN.Text;
                        miVisitaDomiciliariaPuerperaRN.detallereciennacido = txtDetalleRN.Text;
                        miVisitaDomiciliariaPuerperaRN.idthistoriaclinica = sidthistoriaclinica;
                        miVisitaDomiciliariaPuerperaRN.idtobstetra = sidtobstetra;
                        if (saccion == 1)
                        {
                            CapaDeNegocios.cSiguienteCodigo miSiguienteCodigo = new CapaDeNegocios.cSiguienteCodigo();
                            foreach (DataRow row in miSiguienteCodigo.SiguientesCodigo("tvisitadomiciliariapuerperarn", sidtestablecimientosalud).Rows)
                            {
                                miVisitaDomiciliariaPuerperaRN.idtvisitadomiciliariapuerperarn = row[0].ToString();
                            }
                            miVisitaDomiciliariaPuerperaRN.CrearVisitaDomiciliariaPuerperaRN(miVisitaDomiciliariaPuerperaRN);
                            MessageBox.Show("Visita a la Madre y Recien Nacido registrada correctamente.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            bOk = true;
                        }
                        if (saccion == 2)
                        {
                            miVisitaDomiciliariaPuerperaRN.ModificarVisitaDomiciliariaPuerperaRN(miVisitaDomiciliariaPuerperaRN);
                            MessageBox.Show("Visita a la Madre y Recien Nacido modificada correctamente.", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bOk = true;
                        }
                    }
                    if (bOk == true)
                    {
                        //DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("No se puede registrar estos datos", "Gestión del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    CargarDatosGestante();
                    CargarDatosPuerperaRN();
                }
                else
                    MessageBox.Show("Control de gestante archivado; No se puede hacer modificaciones.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Archivado){ 
                if (MessageBox.Show("Está seguro que desea eliminar la Visita Domiciliaria.", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
                    {
                        return;
                    }
                    if (stipo == "GESTANTE")
                    {
                        if (sidtvisitadomiciliariagestante == "")
                        {
                            MessageBox.Show("No existena datos que se puedan Eliminar", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        miVisitaDomiciliariaGestante.EliminarVisitaDomiciliariaGestante(sidtvisitadomiciliariagestante);
                        CargarDatosGestante();
                        if (dgvVisitaDomiciliariaGestante.Rows.Count == 0)
                        {
                            btnNuevo_Click(sender, e);
                        }
                    }
                    else if (stipo == "PUERPERIA/R.NACIDO")
                    {
                        if (sidtvisitadomiciliariapuerperarn == "")
                        {
                            MessageBox.Show("No existena datos que se puedan Eliminar", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        miVisitaDomiciliariaPuerperaRN.EliminarVisitaDomiciliariaPuerperaRN(sidtvisitadomiciliariapuerperarn);
                        CargarDatosPuerperaRN();
                        if (dgvVisitaDomiciliariaPuerperaRN.Rows.Count == 0)
                        {
                            btnNuevo_Click(sender, e);
                        }
                    }
                }
                else
                    MessageBox.Show("Control de gestante archivado; No se puede hacer modificaciones.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                if (tabPage1.Enabled == false)
                {
                    MessageBox.Show("No puede registrar Visitas Domiciliarias para Gestantes.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabControl1.SelectedIndex = 1;
                    return;
                }
                stipo = "GESTANTE";
                CargarDatosGestante();
            }
            else
            {
                if (tabPage2.Enabled == false)
                {
                    MessageBox.Show("No puede registrar Visitas Domiciliarias para Puerpera/Recien Nacido.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabControl1.SelectedIndex = 0;
                    return;
                }
                stipo = "PUERPERIA/R.NACIDO";
                CargarDatosPuerperaRN();
            }
        }

        private void VerificarTerminoGestacion()
        {
            try
            {
                CapaDeNegocios.TerminoGestacion.cTerminoGestacion miTerminoGestacion = new CapaDeNegocios.TerminoGestacion.cTerminoGestacion();
                if (miTerminoGestacion.ListarTerminoGestacion(sidthistoriaclinica).Rows.Count == 0)
                {
                    tabPage1.Enabled = true;
                    tabPage2.Enabled = false;
                    tabControl1.SelectedIndex = 0;
                }
                else
                {
                    tabPage1.Enabled = false;
                    tabPage2.Enabled = true;
                    tabControl1.SelectedIndex = 1;
                    foreach (DataRow row in miTerminoGestacion.ListarTerminoGestacion(sidthistoriaclinica).Rows)
                    {
                        dtpFechaPuerpera.MinDate = Convert.ToDateTime(row[4]);
                    }
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        #region VisitaDomiciliariaGestante

        private void dtpFechaGestante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtFuaGestante.Focus();
            }
        }

        private void txtFuaGestante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboMotivoGestante.Focus();
            }
        }

        private void cboMotivoGestante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDetalleGestante.Focus();
            }
        }

        private void txtDetalleGestante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnGuardar.Focus();
            }
        }

        private void dgvVisitaDomiciliaria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                saccion = 2;
                sidtvisitadomiciliariagestante = Convert.ToString(dgvVisitaDomiciliariaGestante.Rows[e.RowIndex].Cells["idtvisitadomiciliariagestante"].Value);
                dtpFechaGestante.Value = Convert.ToDateTime(dgvVisitaDomiciliariaGestante.Rows[e.RowIndex].Cells["fecha"].Value);
                cboMotivoGestante.Text = Convert.ToString(dgvVisitaDomiciliariaGestante.Rows[e.RowIndex].Cells["motivo"].Value);
                txtFuaGestante.Text = Convert.ToString(dgvVisitaDomiciliariaGestante.Rows[e.RowIndex].Cells["fua"].Value);
                txtDetalleGestante.Text = Convert.ToString(dgvVisitaDomiciliariaGestante.Rows[e.RowIndex].Cells["detalle"].Value);
                dtpFechaGestante.Focus();
            }
        }

        private void CargarDatosGestante()
        {
            try
            {
                dgvVisitaDomiciliariaGestante.Rows.Clear();
                foreach (DataRow row in miVisitaDomiciliariaGestante.ListarVisitaDomiciliariaGestante(sidthistoriaclinica).Rows)
                {
                    dgvVisitaDomiciliariaGestante.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
                }
                if (dgvVisitaDomiciliariaGestante.Rows.Count > 0)
                {
                    dgvVisitaDomiciliariaGestante.ClearSelection();
                    dgvVisitaDomiciliariaGestante.Rows[dgvVisitaDomiciliariaGestante.RowCount - 1].Selected = true;
                    DataGridViewCellEventArgs ceo = new DataGridViewCellEventArgs(0, dgvVisitaDomiciliariaGestante.RowCount - 1);
                    dgvVisitaDomiciliaria_CellClick(dgvVisitaDomiciliariaGestante, ceo);
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
        #endregion
        #region VisitaDomiciliariaPuerperiaRN

        private void dtpFechaPuerpera_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaRN.Value = dtpFechaPuerpera.Value;
        }

        private void cboMotivoPuerpera_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMotivoRN.Text = cboMotivoPuerpera.Text;
        }

        private void dtpFechaPuerpera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtFuaPuerpera.Focus();
            }
        }

        private void txtFuaPuerpera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboMotivoPuerpera.Focus();
            }
        }

        private void cboMotivoPuerpera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDetallePuerpera.Focus();
            }
        }

        private void txtDetallePuerpera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtFuaRN.Focus();
            }
        }

        private void txtFuaRN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboMotivoRN.Focus();
            }
        }

        private void cboMotivoRN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDetalleRN.Focus();
            }
        }

        private void txtDetalleRN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnGuardar.Focus();
            }
        }

        private void dgvVisitaDomiciliariaPuerperaRN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                saccion = 2;
                sidtvisitadomiciliariapuerperarn = Convert.ToString(dgvVisitaDomiciliariaPuerperaRN.Rows[e.RowIndex].Cells["idtvisitadomiciliariapuerperarn"].Value);
                dtpFechaPuerpera.Value = Convert.ToDateTime(dgvVisitaDomiciliariaPuerperaRN.Rows[e.RowIndex].Cells["fechapuerperarn"].Value);
                cboMotivoPuerpera.Text = Convert.ToString(dgvVisitaDomiciliariaPuerperaRN.Rows[e.RowIndex].Cells["motivopuerpera"].Value);
                txtFuaPuerpera.Text = Convert.ToString(dgvVisitaDomiciliariaPuerperaRN.Rows[e.RowIndex].Cells["fuapuerpera"].Value);
                txtDetallePuerpera.Text = Convert.ToString(dgvVisitaDomiciliariaPuerperaRN.Rows[e.RowIndex].Cells["detallepuerpera"].Value);
                cboMotivoRN.Text = Convert.ToString(dgvVisitaDomiciliariaPuerperaRN.Rows[e.RowIndex].Cells["motivoreciennacido"].Value);
                txtFuaRN.Text = Convert.ToString(dgvVisitaDomiciliariaPuerperaRN.Rows[e.RowIndex].Cells["fuareciennacido"].Value);
                txtDetalleRN.Text = Convert.ToString(dgvVisitaDomiciliariaPuerperaRN.Rows[e.RowIndex].Cells["detallereciennacido"].Value);
                dtpFechaPuerpera.Focus();
            }
        }

        private void CargarDatosPuerperaRN()
        {
            try
            {
                dgvVisitaDomiciliariaPuerperaRN.Rows.Clear();
                foreach (DataRow row in miVisitaDomiciliariaPuerperaRN.ListarVisitaDomiciliariaPuerperaRN(sidthistoriaclinica).Rows)
                {
                    dgvVisitaDomiciliariaPuerperaRN.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString());
                }
                if (dgvVisitaDomiciliariaPuerperaRN.Rows.Count > 0)
                {
                    dgvVisitaDomiciliariaPuerperaRN.ClearSelection();
                    dgvVisitaDomiciliariaPuerperaRN.Rows[dgvVisitaDomiciliariaPuerperaRN.RowCount - 1].Selected = true;
                    DataGridViewCellEventArgs ceo = new DataGridViewCellEventArgs(0, dgvVisitaDomiciliariaPuerperaRN.RowCount - 1);
                    dgvVisitaDomiciliariaPuerperaRN_CellClick(dgvVisitaDomiciliariaPuerperaRN, ceo);
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
