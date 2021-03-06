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
        CapaDeNegocios.cUtilitarios oUtilitarios = new CapaDeNegocios.cUtilitarios();

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

            if (oUtilitarios.verificarventanaabierta("frmGestantesControlPreNatal"))
            {
                //fGestantes.MdiParent = this;
                fGestantes.Show();
            }
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

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Alertas.CRGestanteOdonto RpGestanteOdonto= new Alertas.CRGestanteOdonto();
            //RpGestanteOdonto.SetDataSource(Alertas.AlertaOdontologia());
            //Alertas.GestantesSinExamenOdontologico frmReporteOdonto = new Alertas.GestantesSinExamenOdontologico();
            //frmReporteOdonto.CRVGestanteOdonto.ReportSource = RpGestanteOdonto;
            //frmReporteOdonto.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Alertas.CRGestanteEco RpGestanteEco = new Alertas.CRGestanteEco();
            //RpGestanteEco.SetDataSource(Alertas.AlertaEcografia());
            //Alertas.GestantesSinExamenEcografico frmReporteEco = new Alertas.GestantesSinExamenEcografico();
            //frmReporteEco.CRVGestanteEco.ReportSource = RpGestanteEco;
            //frmReporteEco.Show();
        }
    }
}
