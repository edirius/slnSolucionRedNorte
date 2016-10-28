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

        private void frmAlerta_Load(object sender, EventArgs e)
        {
            CargarDatos();
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
    }
}
