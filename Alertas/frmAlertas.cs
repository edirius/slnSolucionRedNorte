﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alertas.Properties;
using CapaDeDatos;
using System.Media;
using WMPLib;
using System.Runtime.InteropServices;
using System.Collections;
namespace Alertas
{
    public partial class frmAlertas : Form
    {
        [DllImport("user32.dll", EntryPoint = "GetSystemMenu")]
        private static extern IntPtr GetSystemMenu(IntPtr hwnd, int revert);
        [DllImport("user32.dll", EntryPoint = "GetMenuItemCount")]
        private static extern int GetMenuItemCount(IntPtr hmenu);
        [DllImport("user32.dll", EntryPoint = "RemoveMenu")]
        private static extern int RemoveMenu(IntPtr hmenu, int npos, int wflags);
        [DllImport("user32.dll", EntryPoint = "DrawMenuBar")]
        private static extern int DrawMenuBar(IntPtr hwnd);
        private const int MF_BYPOSITION = 0x0400;
        private const int MF_DISABLED = 0x0002;

        cAlertas miAlerta = new cAlertas();
        ArrayList miLista = new ArrayList();
        string FechaTexto = "";
        public frmAlertas()
        {
            InitializeComponent();
            HacerConeccion();
            Arbol.ExpandAll();
            CargarAños();
            DateTime Ahora = DateTime.Today;
            CargarMes(Ahora);
            CargarTodosGrid();
            timerActualizar.Start();

        }
        private void CargarGrid(string tipo)
        {
            dgvGestantesSinBateria.DataSource = miAlerta.ListadeAlertasenBateria2(tipo, cbMes.Text, cbAños.Text);
        }
        private void HacerConeccion()
        {
            try
            {
                Conexion.IniciarSesion(Settings.Default.ConexionMySql, "bdcontrolgestantes", "root", "root");
                //MessageBox.Show(String.Format("{0}", "Se conecto exitosamente"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarMes(DateTime FechaActual)
        {
            string Ahora = Convert.ToString(FechaActual.Date.Month);
            switch (Ahora)
            {
                case "1":
                    {
                        FechaTexto = "ENERO";
                        break;
                    }
                case "2":
                    {
                        FechaTexto = "FEBRERO";
                        break;
                    }
                case "3":
                    {
                        FechaTexto = "MARZO";
                        break;
                    }
                case "4":
                    {
                        FechaTexto = "ABRIL";
                        break;
                    }
                case "5":
                    {
                        FechaTexto = "MAYO";
                        break;
                    }
                case "6":
                    {
                        FechaTexto = "JUNIO";
                        break;
                    }
                case "7":
                    {
                        FechaTexto = "JULIO";
                        break;
                    }
                case "8":
                    {
                        FechaTexto = "AGOSTO";
                        break;
                    }
                case "9":
                    {
                        FechaTexto = "SEPTIEMBRE";
                        break;
                    }
                case "10":
                    {
                        FechaTexto = "OCTUBRE";
                        break;
                    }
                case "11":
                    {
                        FechaTexto = "NOVIEMBRE";
                        break;
                    }
                case "12":
                    {
                        FechaTexto = "DICIEMBRE";
                        break;
                    }

            }
        }
        private void CargarAños()
        {
            string años = "";
            for (int i = DateTime.Now.Year; i >= 2000; i--)
            {
                cbAños.Items.Add(i);
            }
            cbAños.Text = años;
            cbAños.Text = Convert.ToString(DateTime.Now.Year);
        }
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAlertas_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(1000, "Alertas en el Sistema de Control de Gestantes", "Para ver la lista de gestantes con problemas haga click aquí.", ToolTipIcon.Warning);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
        }
        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
        }

        private void lbleliminar_Click(object sender, EventArgs e)
        {
            Close();
            //MessageBox.Show("La gestante presenta complicaciones y no le ha dado una fecha para su tratamiento.", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void lblmaximizar_Click(object sender, EventArgs e)
        {

            //this.WindowState = FormWindowState.Maximized;
            //lblmaximizar.Visible = false;
            //lblnormal.Visible = true;
        }

        private void lblnormal_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;

            //lblnormal.Visible = false;
            //lblmaximizar.Visible = true;
        }

        private void lblminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        WindowsMediaPlayer Sonido;
        private void SonidoAlerta()
        {
            try
            {
                if (Sonido == null)
                {
                    Sonido = new WindowsMediaPlayer();
                    Sonido.URL = Application.StartupPath + @"\El-Exorcista.mp3";
                    Sonido.controls.play();
                }
            }
            catch { }

        }
        
        private void CargarTodosGrid()
        {
            dgvGestantesSinBateria.DataSource = miAlerta.AlertaGestanteSinBateria2(cbMes.Text, cbAños.Text);
            dgvGestantesConAnemia.DataSource = miAlerta.AlertaGestanteAnemia2(cbMes.Text, cbAños.Text);
            dgvGestantesSinTratamiento.DataSource = miAlerta.AlertaGestanteSinFechaTratamiento2(cbMes.Text, cbAños.Text);
            dgvGestantesSifilis.DataSource = miAlerta.AlertaGestanteSifilis2(cbMes.Text, cbAños.Text);
            dgvGestantesVIH.DataSource = miAlerta.AlertaGestanteVIH2(cbMes.Text, cbAños.Text);
            dgvGestantesInfeccionUrinaria.DataSource = miAlerta.AlertaGestanteOrina2(cbMes.Text, cbAños.Text);
            dgvGestantesSinExamenOrina.DataSource = miAlerta.AlertaGestanteSinExamenOrina2(cbMes.Text, cbAños.Text);

        }
        private void OcultarGrids()
        {
            dgvGestantesSinBateria.Visible = false;
            dgvGestantesConAnemia.Visible = false;
            dgvGestantesSinTratamiento.Visible = false;
            dgvGestantesSifilis.Visible = false;
            dgvGestantesVIH.Visible = false;
            dgvGestantesInfeccionUrinaria.Visible = false;
            dgvGestantesSinExamenOrina.Visible = false;
        }
        private void MostrarNuevasGestantesConProblemas()
        {
            try
            {
                int contarRegistro = dgvGestantesSinBateria.RowCount;
                string valorcelda = dgvGestantesSinBateria[1, contarRegistro - 1].Value.ToString();
                txtUltimaGestanteSinBateria.Text = valorcelda;
            } catch { }
            try
            {
                int contarRegistro2 = dgvGestantesConAnemia.RowCount;
                string valorcelda2 = dgvGestantesConAnemia[1, contarRegistro2 - 1].Value.ToString();
                txtUltimaGestanteConAnemia.Text = valorcelda2;}catch { }
            try
            {
                int contarRegistro3 = dgvGestantesSinTratamiento.RowCount;
                string valorcelda3 = dgvGestantesSinTratamiento[1, contarRegistro3 - 1].Value.ToString();
                txtUltimaGestanteSinTrata.Text = valorcelda3;
            }catch { }
            try
            {
                int contarRegistro4 = dgvGestantesSifilis.RowCount;
                string valorcelda4 = dgvGestantesSifilis[1, contarRegistro4 - 1].Value.ToString();
                txtUltimaGestanteSifilis.Text = valorcelda4;
            }
            catch { }
            try
            {
                int contarRegistro5 = dgvGestantesVIH.RowCount;
                string valorcelda5 = dgvGestantesVIH[1, contarRegistro5 - 1].Value.ToString();
                txtUltimaGestanteVIH.Text = valorcelda5;
            }
            catch { }
            try
            {
                int contarRegistro6 = dgvGestantesInfeccionUrinaria.RowCount;
                string valorcelda6 = dgvGestantesInfeccionUrinaria[1, contarRegistro6 - 1].Value.ToString();
                txtUltimaGestanteInfeccion.Text = valorcelda6;
            }
            catch { }
            try
            {
                int contarRegistro7 = dgvGestantesSinExamenOrina.RowCount;
                string valorcelda7 = dgvGestantesSinExamenOrina[1, contarRegistro7 - 1].Value.ToString();
                txtUltimaGestanteSinEOrina.Text = valorcelda7;
            }
            catch { }
        }

        private void Arbol_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                switch (e.Node.Parent.Text)
                {
                    case "Alertas en bateria":
                        switch (e.Node.Text)
                        {
                            case "Gestantes sin bateria":
                                lblTipoDeAlerta.Text = e.Node.Text;
                                OcultarGrids();
                                dgvGestantesSinBateria.Visible = true;
                                
                                break;
                            case "Gestantes con anemia":
                                lblTipoDeAlerta.Text = e.Node.Text;
                                OcultarGrids();
                                dgvGestantesConAnemia.Visible = true;
                                dgvGestantesConAnemia.Location = new Point(7, 91);
                                break;
                            case "Gestantes sin tratamiento":
                                lblTipoDeAlerta.Text = e.Node.Text;
                                OcultarGrids();
                                dgvGestantesSinTratamiento.Visible = true;
                                dgvGestantesSinTratamiento.Location = new Point(7, 91);

                                break;
                            case "Gestantes con sifilis reactivo":
                                lblTipoDeAlerta.Text = e.Node.Text;
                                OcultarGrids();
                                dgvGestantesSifilis.Visible = true;
                                dgvGestantesSifilis.Location = new Point(7, 91);

                                break;
                            case "Gestantes con VIH reactivo":
                                lblTipoDeAlerta.Text = e.Node.Text;
                                OcultarGrids();
                                dgvGestantesVIH.Visible = true;
                                dgvGestantesVIH.Location = new Point(7, 91);

                                break;
                            case "Gestantes con infección urinaria":
                                lblTipoDeAlerta.Text = e.Node.Text;
                                OcultarGrids();
                                dgvGestantesInfeccionUrinaria.Visible = true;
                                dgvGestantesInfeccionUrinaria.Location = new Point(7, 91);

                                break;
                            case "Gestantes sin examen de orina":
                                lblTipoDeAlerta.Text = e.Node.Text;
                                OcultarGrids();
                                dgvGestantesSinExamenOrina.Visible = true;
                                dgvGestantesSinExamenOrina.Location = new Point(7, 91);
                                break;
                        }
                        break;
                    case "Alertas en Citas":
                        switch (e.Node.Text)
                        {
                            case "Gestantes que no acuden a sus citas":
                                lblTipoDeAlerta.Text = e.Node.Text;
                                break;
                        }
                        break;
                    case "Alertas en Presion Arterial":
                        switch (e.Node.Text)
                        {
                            case "Gestantes con presion arterial elevada":
                                //
                                break;
                        }
                        break;
                    case "Alertas en Recien Nacidos":
                        switch (e.Node.Text)
                        {
                            case "Recien nacidos con bajo peso":
                                //
                                break;
                        }
                        break;
                }

            }
        }
        private void frmAlertas_Load(object sender, EventArgs e)
        {
            cbMes.Text = FechaTexto;
            IntPtr hmenu = GetSystemMenu(this.Handle, 0);
            int cnt = GetMenuItemCount(hmenu);
            // remove 'close' action
            RemoveMenu(hmenu, cnt - 1, MF_DISABLED | MF_BYPOSITION);
            // remove extra menu line
            RemoveMenu(hmenu, cnt - 2, MF_DISABLED | MF_BYPOSITION);
            DrawMenuBar(this.Handle);
        }
        private void frmAlertas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Impedir que el formulario se cierre pulsando X o Alt + F4 
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
        
        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTodosGrid();
        }

        private void cbAños_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTodosGrid();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarNuevasGestantesConProblemas();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "Nueva gestante con problemas",  "Gestante sin Bateria:" + "\n" + txtUltimaGestanteSinBateria.Text, ToolTipIcon.Warning);
            SonidoAlerta();
        }

        private void txtUltimaGestanteConAnemia_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "Nueva gestante con problemas", "Gestante con Anemia:" + "\n" + txtUltimaGestanteConAnemia.Text, ToolTipIcon.Warning);
            SonidoAlerta();
        }

        private void txtUltimaGestanteSinTrata_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "Nueva gestante con problemas", "Gestante sin tratamiento:" + "\n" + txtUltimaGestanteSinTrata.Text, ToolTipIcon.Warning);
            SonidoAlerta();
        }

        private void txtUltimaGestanteSifilis_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "Nueva gestante con problemas", "Gestante con infección urinaria:" + "\n" + txtUltimaGestanteInfeccion.Text, ToolTipIcon.Warning);
            SonidoAlerta();
        }

        private void txtUltimaGestanteVIH_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "Nueva gestante con problemas", "Gestante con VIH reactivo:" + "\n" + txtUltimaGestanteVIH.Text, ToolTipIcon.Warning);
            SonidoAlerta();
        }

        private void txtUltimaGestanteInfeccion_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "Nueva gestante con problemas", "Gestante con Sifilis reactivo:" + "\n" + txtUltimaGestanteInfeccion.Text, ToolTipIcon.Warning);
            SonidoAlerta();
        }

        private void txtUltimaGestanteSinEOrina_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "Nueva gestante con problemas", "Gestante sin examén de orina:" + "\n" + txtUltimaGestanteSinEOrina.Text, ToolTipIcon.Warning);
            SonidoAlerta();
        }

        private void timerActualizar_Tick(object sender, EventArgs e)
        {
            string Tiempo;
            Tiempo = DateTime.Now.Minute.ToString();
            if ((int.Parse(Tiempo) % 1) == 0)
            {
                CargarTodosGrid();
                MostrarNuevasGestantesConProblemas();
            }
            else { }
        }
    }
}
