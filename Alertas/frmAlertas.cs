using System;
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
        string FechaTexto = "";
        public frmAlertas()
        {
            InitializeComponent();
            HacerConeccion();
            Arbol.ExpandAll();
            CargarAños();
            DateTime Ahora = DateTime.Today;
            CargarMes(Ahora);
            //CargarTodosGrid();

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
                timer.Start();
                notifyIcon1.ShowBalloonTip(1000, "Alertas en el Sistema de Control de Gestantes", "Para ver las alertas haga click aquí.", ToolTipIcon.Warning);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
        }
        private void ActualizarAlertas()
        {

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            string Tiempo;
            Tiempo = DateTime.Now.Minute.ToString();
            if ((int.Parse(Tiempo) % 5) == 0)
            {
                notifyIcon1.ShowBalloonTip(1000, "Alertas en el Sistema de Control de Gestantes", "Para ver las alertas haga click aquí.", ToolTipIcon.Warning);
                SonidoAlerta();
            }
            else { }

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
        //93, 85
        private void CargarTodosGrid()
        {
            dgvGestantesSinBateria.DataSource = miAlerta.AlertaGestanteSinBateria2(cbMes.Text, cbAños.Text);
            dgvGestantesConAnemia.DataSource = miAlerta.AlertaGestanteAnemia2(cbMes.Text, cbAños.Text);
            dgvGestantesSinTratamiento.DataSource = miAlerta.AlertaGestanteSinFechaTratamiento2(cbMes.Text,cbAños.Text);
            dgvGestantesSifilis.DataSource = miAlerta.AlertaGestanteSifilis2(cbMes.Text, cbAños.Text);
            dgvGestantesVIH.DataSource = miAlerta.AlertaGestanteVIH2(cbMes.Text, cbAños.Text);
            dgvGestantesInfeccionUrinaria.DataSource = miAlerta.AlertaGestanteOrina2(cbMes.Text, cbAños.Text);
            dgvGestantesSinExamenOrina.DataSource = miAlerta.AlertaGestanteSinExamenOrina2(cbMes.Text, cbAños.Text);

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
                                CargarGrid(e.Node.Text);
                                break;
                            case "Gestantes con anemia":
                                lblTipoDeAlerta.Text = e.Node.Text;
                                CargarGrid(e.Node.Text);
                                break;
                            case "Gestantes sin tratamiento":
                                lblTipoDeAlerta.Text = e.Node.Text;
                                CargarGrid(e.Node.Text);
                                break;
                            case "Gestantes con sifilis reactivo":
                                lblTipoDeAlerta.Text = e.Node.Text;
                                CargarGrid(e.Node.Text);
                                break;
                            case "Gestantes con VIH reactivo":
                                lblTipoDeAlerta.Text = e.Node.Text;
                                CargarGrid(e.Node.Text);
                                break;
                            case "Gestantes con infección urinaria":
                                lblTipoDeAlerta.Text = e.Node.Text;
                                CargarGrid(e.Node.Text);
                                break;
                            case "Gestantes sin examen de orina":
                                lblTipoDeAlerta.Text = e.Node.Text;
                                CargarGrid(e.Node.Text);
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
    }
}
