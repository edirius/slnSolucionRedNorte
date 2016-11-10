﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Monitoreo.Properties;
using CapaDeDatos;

namespace Monitoreo
{
    public partial class frmLogin : Form
    {
        CapaDeNegocios.Administrador.cAdministrador miAdministrador = new CapaDeNegocios.Administrador.cAdministrador();
        CapaDeNegocios.Obstetra.cUsuario miUsuario = new CapaDeNegocios.Obstetra.cUsuario();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion.IniciarSesion(Settings.Default.ConexionMySql, "bdcontrolgestantes", "root", "root");
                txtUsuario.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                DataView objDataView = new DataView();
                objDataView.Table = miAdministrador.ListarAdministrador();
                objDataView.RowFilter = "usuario='" + txtUsuario.Text + "' and password='" + miUsuario.ObtenerSHA1(txtContraseña.Text) + "'";
                if (objDataView.Count > 0)
                {
                    frmMDI Menu = new frmMDI();
                    MessageBox.Show("Bienvenido al Sistema de Monitoreo Control de Gestantes usuario " + txtUsuario.Text + ".", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu.Show();
                    this.Hide();
                }
                else
                {
                    const string message = "El Usuario no existe o la contraseña es incorrecta.";
                    const string caption = "Error";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Text = ""; txtContraseña.Text = ""; txtUsuario.Focus();
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void cbVer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVer.Checked)
            {
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '●';
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtContraseña.Focus();
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnIniciar_Click(sender, e);
            }
        }
    }
}
