﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario.Alertas
{
    public partial class frmAlerta : Form
    {
        public frmAlerta()
        {
            InitializeComponent();
        }

        public string CodigoEstablecimiento { get; set; }
        public string CodigoObstetra { get; set; }

        private void frmAlerta_Load(object sender, EventArgs e)
        {
            AlertaControlPuerperio();
        }

        private void CargarDatos()
        {

        }

        private void lnkGestantesControlPreNatal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmGestantesControlPreNatal fGestantes = new frmGestantesControlPreNatal();
            fGestantes.codigoEstablecimiento = CodigoEstablecimiento;
            fGestantes.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmGestantesConRiesgoPresionArterial fArterial = new frmGestantesConRiesgoPresionArterial();
            fArterial.CodigoEstablecimiento = CodigoEstablecimiento;
            fArterial.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
                Bateria.frmAlertaGestanteBateria frmAlertaGestanteSinBateria = new Bateria.frmAlertaGestanteBateria();
                frmAlertaGestanteSinBateria.CodigoEstablecimiento = CodigoEstablecimiento;
                frmAlertaGestanteSinBateria.CodigoObstetra = CodigoObstetra;
                frmAlertaGestanteSinBateria.Show();
        }

        private void lbleliminar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAlertaControlPuerperio frmAlertaControlPuerperio = new frmAlertaControlPuerperio();
            frmAlertaControlPuerperio.Show();
        }

        private void AlertaControlPuerperio()
        {
            CapaDeNegocios.Alertas.cAlertaControlPuerperio miAlertaControlPuerperio = new CapaDeNegocios.Alertas.cAlertaControlPuerperio();
            if (miAlertaControlPuerperio.ListarAlertaControlPuerperio(cVariables.v_idobstetra, cVariables.v_idestablecimientosalud).Rows.Count == 0)
            { pictureBox5.Visible = false; }
            else
            { pictureBox5.Visible = true; }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecienNacido.frmAlertaRNBajoPeso frmRNBajoPeso = new RecienNacido.frmAlertaRNBajoPeso();
            frmRNBajoPeso.CodigoEstablecimiento = CodigoEstablecimiento;
            frmRNBajoPeso.CodigoObstetra = CodigoObstetra;
            frmRNBajoPeso.Show();
        }
    }
}
