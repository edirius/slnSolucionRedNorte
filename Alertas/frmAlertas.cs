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
using System.Collections;
using System.Data.SqlClient;

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
        DateTime Ahora = DateTime.Today;
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

        }
        DataTable odt = new DataTable();
        public DateTime FUR;
        public DateTime FPP;
        public DateTime FechaRegistro;
        int SemanaAPN;
        DataTable NroCitas;
        DateTime primera_fecha_max = DateTime.Now;
        DateTime segunda_fecha_max = DateTime.Now;

        private void CalcularCitas()
        {
            dgvOdontologia.DataSource = miAlerta.AlertaOdontologia();
            dgvEcografia.DataSource = miAlerta.AlertaEcografia();
            dgvGestantesSinBateria.DataSource = miAlerta.AlertaGestanteSinBateria2();
            foreach (DataGridViewRow Fila in dgvOdontologia.Rows)
            {
                FUR = Convert.ToDateTime(Fila.Cells["fur1"].Value);
                FPP = Convert.ToDateTime(Fila.Cells["fpp1"].Value);
                FechaRegistro = Convert.ToDateTime(Fila.Cells["fecha1"].Value);
                SemanaAPN = Convert.ToInt16(Fila.Cells["semanaapn1"].Value);
                odt = miAlerta.realizar_citas(FPP, FechaRegistro, SemanaAPN);
                Fila.Cells["PrimerControlOdo"].Value = miAlerta.determinar_1er_control(odt).ToShortDateString();
                //Fila.Cells["SegundoControlOdo"].Value = miAlerta.determinar_2do_control(odt).ToShortDateString();
            }
            foreach (DataGridViewRow Fila in dgvEcografia.Rows)
            {
                FUR = Convert.ToDateTime(Fila.Cells["fur2"].Value);
                FPP = Convert.ToDateTime(Fila.Cells["fpp2"].Value);
                FechaRegistro = Convert.ToDateTime(Fila.Cells["fecha2"].Value);
                SemanaAPN = Convert.ToInt16(Fila.Cells["semanaapn2"].Value);
                odt = miAlerta.realizar_citas(FPP, FechaRegistro, SemanaAPN);
                Fila.Cells["PrimerControlEco"].Value = miAlerta.determinar_1er_control(odt).ToShortDateString();
                //Fila.Cells["SegundoControlOdo"].Value = miAlerta.determinar_2do_control(odt).ToShortDateString();
            }
            foreach (DataGridViewRow Fila in dgvGestantesSinBateria.Rows)
            {
                FUR = Convert.ToDateTime(Fila.Cells["fur3"].Value);
                FPP = Convert.ToDateTime(Fila.Cells["fpp3"].Value);
                FechaRegistro = Convert.ToDateTime(Fila.Cells["fecha3"].Value);
                SemanaAPN = Convert.ToInt16(Fila.Cells["semanaapn3"].Value);
                odt = miAlerta.realizar_citas(FPP, FechaRegistro, SemanaAPN);
                Fila.Cells["FechaBateria1"].Value = miAlerta.determinar_1er_control(odt).ToShortDateString();
                //Fila.Cells["SegundoControlOdo"].Value = miAlerta.determinar_2do_control(odt).ToShortDateString();
            }
            ///----------------------------------------------------------------------------------------------------
            dgvOdontologia2.DataSource = miAlerta.AlertaOdontologia2();
            dgvEcografia2.DataSource = miAlerta.AlertaEcografia2();
            //dgvGestantesSinBateria.DataSource = miAlerta.AlertaGestanteSinBateria2();
            foreach (DataGridViewRow Fila in dgvOdontologia2.Rows)
            {
                FUR = Convert.ToDateTime(Fila.Cells["fur5"].Value);
                FPP = Convert.ToDateTime(Fila.Cells["fpp5"].Value);
                FechaRegistro = Convert.ToDateTime(Fila.Cells["fecha5"].Value);
                SemanaAPN = Convert.ToInt16(Fila.Cells["semanaapn5"].Value);
                odt = miAlerta.realizar_citas(FPP, FechaRegistro, SemanaAPN);
                //Fila.Cells["PrimerControlOdo"].Value = miAlerta.determinar_1er_control(odt).ToShortDateString();
                Fila.Cells["FechaControlOdo2"].Value = miAlerta.determinar_2do_control(odt).ToShortDateString();
            }
            foreach (DataGridViewRow Fila in dgvEcografia2.Rows)
            {
                FUR = Convert.ToDateTime(Fila.Cells["fur4"].Value);
                FPP = Convert.ToDateTime(Fila.Cells["fpp4"].Value);
                FechaRegistro = Convert.ToDateTime(Fila.Cells["fecha4"].Value);
                SemanaAPN = Convert.ToInt16(Fila.Cells["semanaapn4"].Value);
                odt = miAlerta.realizar_citas(FPP, FechaRegistro, SemanaAPN);
                //Fila.Cells["PrimerControlEco"].Value = miAlerta.determinar_1er_control(odt).ToShortDateString();
                Fila.Cells["FechaControlEco2"].Value = miAlerta.determinar_2do_control(odt).ToShortDateString();
            }
            //foreach (DataGridViewRow Fila in dgvGestantesSinBateria.Rows)
            //{
            //    FUR = Convert.ToDateTime(Fila.Cells["fur3"].Value);
            //    FPP = Convert.ToDateTime(Fila.Cells["fpp3"].Value);
            //    FechaRegistro = Convert.ToDateTime(Fila.Cells["fecha3"].Value);
            //    SemanaAPN = Convert.ToInt16(Fila.Cells["semanaapn3"].Value);
            //    odt = miAlerta.realizar_citas(FPP, FechaRegistro, SemanaAPN);
            //    Fila.Cells["FechaBateria1"].Value = miAlerta.determinar_1er_control(odt).ToShortDateString();
            //    //Fila.Cells["SegundoControlOdo"].Value = miAlerta.determinar_2do_control(odt).ToShortDateString();
            //}

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
            //Application.Exit();
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
            this.WindowState = FormWindowState.Normal;
            mostrarAlertaSeleccionada(notifyIcon1.Text);
        }
        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            mostrarAlertaSeleccionada(notifyIcon1.Text);
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
                    Sonido.URL = Application.StartupPath + @"\SD_ALERT_12.mp3";
                    Sonido.controls.play();
                    
                }
                Sonido = null;
            }
            catch { }

        }
        private void CargarTodosGrid()
        {
            dgvGestantesConAnemia.DataSource = miAlerta.AlertaGestanteAnemia2(cbMes.Text, cbAños.Text);
            
            dgvGestantesSinTratamiento.DataSource = miAlerta.AlertaGestanteSinFechaTratamiento2(cbMes.Text, cbAños.Text);
            
            dgvGestantesSifilis.DataSource = miAlerta.AlertaGestanteSifilis2(cbMes.Text, cbAños.Text);
            
            dgvGestantesVIH.DataSource = miAlerta.AlertaGestanteVIH2(cbMes.Text, cbAños.Text);
            
            dgvGestantesInfeccionUrinaria.DataSource = miAlerta.AlertaGestanteOrina2(cbMes.Text, cbAños.Text);
            
            dgvGestantesSinExamenOrina.DataSource = miAlerta.AlertaGestanteSinExamenOrina2(cbMes.Text, cbAños.Text);
            
            dgvRecienNacidosBajoPeso.DataSource = miAlerta.AlertaRecienNacidoBajoPeso(cbMes.Text, cbAños.Text);

            dgvGestantePAalta.DataSource = miAlerta.AlertaGestantePresionPAalta(cbMes.Text, cbAños.Text);

            dgvPuerperaSinControl.DataSource = miAlerta.AlertaPuerperaSinControlPuerperio(cbMes.Text, cbAños.Text);

            dgvPuerperaSin2doControl.DataSource = miAlerta.AlertaPuerperaSin2doControlPuerperio(cbMes.Text, cbAños.Text);

            dgvGestanteNoAcudeCitas.DataSource = miAlerta.AlertaGestanteNoAcudeCitas();
            
            CalcularCitas();
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
            dgvRecienNacidosBajoPeso.Visible = false;
            dgvGestantePAalta.Visible = false;
            dgvPuerperaSinControl.Visible = false;
            dgvPuerperaSin2doControl.Visible = false;
            dgvGestanteNoAcudeCitas.Visible = false;
            dgvEcografia.Visible = false;
            dgvOdontologia.Visible = false;
            dgvEcografia2.Visible = false;
            dgvOdontologia2.Visible = false;

        }
        private void MostrarNuevasGestantesConProblemas()
        {
            try
            {
                int contarRegistro = dgvGestantesSinBateria.RowCount;
                string valorcelda = dgvGestantesSinBateria[2, contarRegistro - 1].Value.ToString();
                dgvGestantesSinBateria.ClearSelection();
                dgvGestantesSinBateria[1, contarRegistro - 1].Selected = true;
                txtUltimaGestanteSinBateria.Text = valorcelda;
            }
            catch { }
            try
            {
                int contarRegistro2 = dgvGestantesConAnemia.RowCount;
                string valorcelda2 = dgvGestantesConAnemia[1, contarRegistro2 - 1].Value.ToString();
                dgvGestantesConAnemia.ClearSelection();
                dgvGestantesConAnemia[1, contarRegistro2 - 1].Selected = true;
                txtUltimaGestanteConAnemia.Text = valorcelda2;
            }
            catch { }
            try
            {
                int contarRegistro3 = dgvGestantesSinTratamiento.RowCount;
                string valorcelda3 = dgvGestantesSinTratamiento[1, contarRegistro3 - 1].Value.ToString();
                dgvGestantesSinTratamiento.ClearSelection();
                dgvGestantesSinTratamiento[1, contarRegistro3 - 1].Selected = true;
                txtUltimaGestanteSinTrata.Text = valorcelda3;
            }
            catch { }
            try
            {
                int contarRegistro4 = dgvGestantesSifilis.RowCount;
                string valorcelda4 = dgvGestantesSifilis[1, contarRegistro4 - 1].Value.ToString();
                dgvGestantesSifilis.ClearSelection();
                dgvGestantesSifilis[1, contarRegistro4 - 1].Selected = true;
                txtUltimaGestanteSifilis.Text = valorcelda4;
            }
            catch { }
            try
            {
                int contarRegistro5 = dgvGestantesVIH.RowCount;
                string valorcelda5 = dgvGestantesVIH[1, contarRegistro5 - 1].Value.ToString();
                dgvGestantesVIH.ClearSelection();
                dgvGestantesVIH[1, contarRegistro5 - 1].Selected = true;
                txtUltimaGestanteVIH.Text = valorcelda5;
            }
            catch { }
            try
            {
                int contarRegistro6 = dgvGestantesInfeccionUrinaria.RowCount;
                string valorcelda6 = dgvGestantesInfeccionUrinaria[1, contarRegistro6 - 1].Value.ToString();
                dgvGestantesInfeccionUrinaria.ClearSelection();
                dgvGestantesInfeccionUrinaria[1, contarRegistro6 - 1].Selected = true;
                txtUltimaGestanteInfeccion.Text = valorcelda6;
            }
            catch { }
            try
            {
                int contarRegistro7 = dgvGestantesSinExamenOrina.RowCount;
                string valorcelda7 = dgvGestantesSinExamenOrina[1, contarRegistro7 - 1].Value.ToString();
                dgvGestantesSinExamenOrina.ClearSelection();
                dgvGestantesSinExamenOrina[1, contarRegistro7 - 1].Selected = true;
                txtUltimaGestanteSinEOrina.Text = valorcelda7;
            }
            catch { }
            try
            {                int contarRegistro8 = dgvRecienNacidosBajoPeso.RowCount;
                string valorcelda8 = dgvRecienNacidosBajoPeso[1, contarRegistro8 - 1].Value.ToString();
                dgvRecienNacidosBajoPeso.ClearSelection();
                dgvRecienNacidosBajoPeso[1, contarRegistro8 - 1].Selected = true;
                txtRNBajoPeso.Text = valorcelda8;
            }
            catch { }
            try
            {
                int contarRegistro9 = dgvGestantePAalta.RowCount;
                string valorcelda8 = dgvGestantePAalta[1, contarRegistro9 - 1].Value.ToString();
                dgvGestantePAalta.ClearSelection();
                dgvGestantePAalta[1, contarRegistro9 - 1].Selected = true;
                txtGestantePAalta.Text = valorcelda8;
            }
            catch { }
            try
            {
                int contarRegistro10 = dgvPuerperaSinControl.RowCount;
                string valorcelda8 = dgvPuerperaSinControl[1, contarRegistro10 - 1].Value.ToString();
                dgvPuerperaSinControl.ClearSelection();
                dgvPuerperaSinControl[1, contarRegistro10 - 1].Selected = true;
                txtPuerperaSinControl.Text = valorcelda8;
            }
            catch { }
            try
            {
                int contarRegistro11 = dgvPuerperaSin2doControl.RowCount;
                string valorcelda8 = dgvPuerperaSin2doControl[1, contarRegistro11 - 1].Value.ToString();
                dgvPuerperaSin2doControl.ClearSelection();
                dgvPuerperaSin2doControl[1, contarRegistro11 - 1].Selected = true;
                txtPuerperaSin2doControl.Text = valorcelda8;
            }
            catch { }
            try
            {
                int contarRegistro11 = dgvGestanteNoAcudeCitas.RowCount;
                string valorcelda8 = dgvGestanteNoAcudeCitas[1, contarRegistro11 - 1].Value.ToString();
                dgvGestanteNoAcudeCitas.ClearSelection();
                dgvGestanteNoAcudeCitas[1, contarRegistro11 - 1].Selected = true;
                dgvGestanteNoAcudeCitas.Text = valorcelda8;
            }
            catch { }
            try
            {
                int contarRegistro12 = dgvEcografia.RowCount;
                string valorcelda9 = dgvEcografia[2, contarRegistro12 - 1].Value.ToString();
                dgvEcografia.ClearSelection();
                dgvEcografia[1, contarRegistro12 - 1].Selected = true;
                txtEcografia.Text = valorcelda9;
            }
            catch { }
            try
            {
                int contarRegistro13 = dgvOdontologia.RowCount;
                string valorcelda10 = dgvOdontologia[2, contarRegistro13 - 1].Value.ToString();
                dgvOdontologia.ClearSelection();
                dgvOdontologia[1, contarRegistro13 - 1].Selected = true;
                txtodontologia.Text = valorcelda10;
            }
            catch { }
            try
            {
                int contarRegistro14 = dgvEcografia2.RowCount;
                string valorcelda9 = dgvEcografia2[2, contarRegistro14 - 1].Value.ToString();
                dgvEcografia2.ClearSelection();
                dgvEcografia2[1, contarRegistro14 - 1].Selected = true;
                txtEcografia2.Text = valorcelda9;
            }
            catch { }
            try
            {
                int contarRegistro15 = dgvOdontologia2.RowCount;
                string valorcelda10 = dgvOdontologia[2, contarRegistro15 - 1].Value.ToString();
                dgvOdontologia2.ClearSelection();
                dgvOdontologia2[1, contarRegistro15 - 1].Selected = true;
                txtOdontologia2.Text = valorcelda10;
            }
            catch { }
        }

        private void Arbol_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                switch (e.Node.Parent.Text)
                {
                    case "Alertas en Bateria":
                        switch (e.Node.Text)
                        {
                            case "Gestantes sin bateria":
                                lblTipoDeAlerta.Text = "GESTANTES SIN BATERIA";
                                OcultarGrids();
                                dgvGestantesSinBateria.Visible = true;
                                dgvGestantesSinBateria.Location = new Point(55, 91);

                                break;
                            case "Gestantes con anemia":
                                lblTipoDeAlerta.Text = "GESTANTES CON ANEMIA";
                                OcultarGrids();
                                dgvGestantesConAnemia.Visible = true;
                                dgvGestantesConAnemia.Location = new Point(55, 91);
                                break;
                            case "Gestantes sin tratamiento":
                                lblTipoDeAlerta.Text = "GESTANTES SIN TRATAMIENTO";
                                OcultarGrids();
                                dgvGestantesSinTratamiento.Visible = true;
                                dgvGestantesSinTratamiento.Location = new Point(55, 91);

                                break;
                            case "Gestantes con sifilis reactivo":
                                lblTipoDeAlerta.Text = "GESTANTES CON SIFILIS REACTIVO";
                                OcultarGrids();
                                dgvGestantesSifilis.Visible = true;
                                dgvGestantesSifilis.Location = new Point(55, 91);

                                break;
                            case "Gestantes con VIH reactivo":
                                lblTipoDeAlerta.Text = "GESTANTES CON VIH REACTIVO";
                                OcultarGrids();
                                dgvGestantesVIH.Visible = true;
                                dgvGestantesVIH.Location = new Point(55, 91);

                                break;
                            case "Gestantes con infección urinaria":
                                lblTipoDeAlerta.Text = "GESTANTES CON INFECCION URINARIA";
                                OcultarGrids();
                                dgvGestantesInfeccionUrinaria.Visible = true;
                                dgvGestantesInfeccionUrinaria.Location = new Point(55, 91);

                                break;
                            case "Gestantes sin examen de orina":
                                lblTipoDeAlerta.Text = "GESTANTES SIN EXAMEN DE ORINA";
                                OcultarGrids();
                                dgvGestantesSinExamenOrina.Visible = true;
                                dgvGestantesSinExamenOrina.Location = new Point(55, 91);
                                break;
                        }
                        break;
                    case "Alertas en Cita Pre-Natal":
                        switch (e.Node.Text)
                        {
                            case "Gestantes que no acuden a sus citas":
                                lblTipoDeAlerta.Text = "GESTANTES QUE NO ACUDEN A SUS CITAS PRENATALES";
                                OcultarGrids();
                                dgvGestanteNoAcudeCitas.Visible = true;
                                dgvGestanteNoAcudeCitas.Location = new Point(7, 91);
                                break;
                        }
                        break;
                    case "Alertas en Presion Arterial":
                        switch (e.Node.Text)
                        {
                            case "Gestantes con presion arterial elevada":
                                lblTipoDeAlerta.Text = "GESTANTES CON PRESION ARTERIAL ELEVADA";
                                OcultarGrids();
                                dgvGestantePAalta.Visible = true;
                                dgvGestantePAalta.Location = new Point(55, 91);
                                //
                                break;
                        }
                        break;
                    case "Alertas en Recien Nacidos":
                        switch (e.Node.Text)
                        {
                            case "Recien nacidos con bajo peso":
                                lblTipoDeAlerta.Text = "RECIEN NACIDOS CON BAJO PESO";
                                OcultarGrids();
                                dgvRecienNacidosBajoPeso.Visible = true;
                                dgvRecienNacidosBajoPeso.Location = new Point(7, 91);
                                //
                                break;
                        }
                        break;
                    case "Alertas en Control Puerperio":
                        switch (e.Node.Text)
                        {
                            case "Puerpera sin control puerperio":
                                lblTipoDeAlerta.Text = "PUERPERA SIN CONTROL PUERPERIO";
                                OcultarGrids();
                                dgvPuerperaSinControl.Visible = true;
                                dgvPuerperaSinControl.Location = new Point(55, 91);
                                //
                                break;
                            case "Puerpera sin 2do control puerperio":
                                lblTipoDeAlerta.Text = "PUERPERA SIN 2DO CONTROL PUERPERIO";
                                OcultarGrids();
                                dgvPuerperaSin2doControl.Visible = true;
                                dgvPuerperaSin2doControl.Location = new Point(55, 91);
                                //
                                break;
                        }
                        break;
                    case "Alertas en Ecografia":
                        switch (e.Node.Text)
                        {
                            case "Gestantes sin examen de ecografia":
                                lblTipoDeAlerta.Text = "GESTANTES SIN EXAMEN DE ECOGRAFIA";
                                OcultarGrids();
                                dgvEcografia.Visible = true;
                                dgvEcografia.Location = new Point(55, 91);
                                break;
                            case "Gestantes sin 2do examen de ecografia":
                                lblTipoDeAlerta.Text = "GESTANTES 2DO SIN EXAMEN DE ECOGRAFIA";
                                OcultarGrids();
                                dgvEcografia2.Visible = true;
                                dgvEcografia2.Location = new Point(55, 91);
                                break;
                        }
                        break;
                    case "Alertas en Odontologia":
                        switch (e.Node.Text)
                        {
                            case "Gestantes sin examen de odontologia":
                                lblTipoDeAlerta.Text = "GESTANTES SIN EXAMEN DE ODONTOLOGIA";
                                OcultarGrids();
                                dgvOdontologia.Visible = true;
                                dgvOdontologia.Location = new Point(55, 91);
                                break;
                            case "Gestantes sin 2do examen de odontologia":
                                lblTipoDeAlerta.Text = "GESTANTES SIN 2DO EXAMEN DE ODONTOLOGIA";
                                OcultarGrids();
                                dgvOdontologia2.Visible = true;
                                dgvOdontologia2.Location = new Point(55, 91);
                                break;
                        }
                        break;



                }

            }
        }
        private void frmAlertas_Load(object sender, EventArgs e)
        {
            timerActualizar.Start();
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
            notifyIcon1.ShowBalloonTip(1000, "NUEVA GESTANTE CON PROBLEMAS EN GESSYS V.1",  "GESTANTE SIN BATERIA:" + "\n" + txtUltimaGestanteSinBateria.Text, ToolTipIcon.Warning);
            notifyIcon1.Text = "GESTANTES SIN BATERIA";
            mostrarAlertaSeleccionada(notifyIcon1.Text);
            SonidoAlerta();
        }

        private void txtUltimaGestanteConAnemia_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "NUEVA GESTANTE CON PROBLEMAS EN GESSYS V.1", "GESTANTE CON ANEMIA:" + "\n" + txtUltimaGestanteConAnemia.Text, ToolTipIcon.Warning);
            notifyIcon1.Text = "GESTANTES CON ANEMIA";
            mostrarAlertaSeleccionada(notifyIcon1.Text);
            SonidoAlerta();
        }

        private void txtUltimaGestanteSinTrata_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "NUEVA GESTANTE CON PROBLEMAS EN GESSYS V.1", "GESTANTE SIN TRATAMIENTO" + "\n" + txtUltimaGestanteSinTrata.Text, ToolTipIcon.Warning);
            notifyIcon1.Text = "GESTANTES SIN TRATAMIENTO";
            mostrarAlertaSeleccionada(notifyIcon1.Text);
            SonidoAlerta();
        }

        private void txtUltimaGestanteSifilis_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "NUEVA GESTANTE CON PROBLEMAS EN GESSYS V.1", "GESTANTE CON SIFILIS REACTIVO:" + "\n" + txtUltimaGestanteInfeccion.Text, ToolTipIcon.Warning);
            notifyIcon1.Text = "GESTANTES CON SIFILIS REACTIVO";
            mostrarAlertaSeleccionada(notifyIcon1.Text);
            SonidoAlerta();
        }

        private void txtUltimaGestanteVIH_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "NUEVA GESTANTE CON PROBLEMAS EN GESSYS V.1", "GESTANTE CON VIH REACTIVO:" + "\n" + txtUltimaGestanteVIH.Text, ToolTipIcon.Warning);
            notifyIcon1.Text = "GESTANTES CON VIH REACTIVO";
            mostrarAlertaSeleccionada(notifyIcon1.Text);
            SonidoAlerta();
        }

        private void txtUltimaGestanteInfeccion_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "NUEVA GESTANTE CON PROBLEMAS EN GESSYS V.1", "GESTANTE CON INFECCION URINARIA:" + "\n" + txtUltimaGestanteInfeccion.Text, ToolTipIcon.Warning);
            notifyIcon1.Text = "GESTANTES CON INFECCION URINARIA";
            mostrarAlertaSeleccionada(notifyIcon1.Text);
            SonidoAlerta();
        }

        private void txtUltimaGestanteSinEOrina_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "NUEVA GESTANTE CON PROBLEMAS EN GESSYS V.1", "GESTANTE SIN EXAMEN DE ORINA:" + "\n" + txtUltimaGestanteSinEOrina.Text, ToolTipIcon.Warning);
            notifyIcon1.Text = "GESTANTES SIN EXAMEN DE ORINA";
            mostrarAlertaSeleccionada(notifyIcon1.Text);
            SonidoAlerta();
        }
        private void mostrarAlertaSeleccionada(string formulario)
        {
            if (formulario == "GESTANTES SIN BATERIA")
            {
                OcultarGrids();
                dgvGestantesSinBateria.Location = new Point(55, 91);
                dgvGestantesSinBateria.Visible = true;
                lblTipoDeAlerta.Text = formulario;
            }
            if (formulario == "GESTANTES CON ANEMIA")
            {
                OcultarGrids();
                dgvGestantesConAnemia.Location = new Point(55, 91);
                dgvGestantesConAnemia.Visible = true;
                lblTipoDeAlerta.Text = formulario;
            }
            if (formulario == "GESTANTES SIN TRATAMIENTO")
            {
                OcultarGrids();
                dgvGestantesSinTratamiento.Location = new Point(55, 91);
                dgvGestantesSinTratamiento.Visible = true;
                lblTipoDeAlerta.Text = formulario;
            }
            if (formulario == "GESTANTES CON SIFILIS REACTIVO")
            {
                OcultarGrids();
                dgvGestantesSifilis.Location = new Point(55, 91);
                dgvGestantesSifilis.Visible = true;
                lblTipoDeAlerta.Text = formulario;
            }
            if (formulario == "GESTANTES CON VIH REACTIVO")
            {
                OcultarGrids();
                dgvGestantesVIH.Location = new Point(55, 91);
                dgvGestantesVIH.Visible = true;
                lblTipoDeAlerta.Text = formulario;
            }
            if (formulario == "GESTANTES CON INFECCION URINARIA")
            {
                OcultarGrids();
                dgvGestantesInfeccionUrinaria.Location = new Point(55, 91);
                dgvGestantesInfeccionUrinaria.Visible = true;
                lblTipoDeAlerta.Text = formulario;
            }
            if (formulario == "GESTANTES SIN EXAMEN DE ORINA")
            {
                OcultarGrids();
                dgvGestantesSinExamenOrina.Location = new Point(55, 91);
                dgvGestantesSinExamenOrina.Visible = true;
                lblTipoDeAlerta.Text = formulario;
            }
            if (formulario == "RECIEN NACIDOS CON BAJO PESO")
            {
                OcultarGrids();
                dgvRecienNacidosBajoPeso.Location = new Point(7, 91);
                dgvRecienNacidosBajoPeso.Visible = true;
                lblTipoDeAlerta.Text = formulario;
            }
            if (formulario == "GESTANTES CON PRESION ARTERIAL ELEVADA")
            {
                OcultarGrids();
                dgvGestantePAalta.Location = new Point(55, 91);
                dgvGestantePAalta.Visible = true;
                lblTipoDeAlerta.Text = formulario;
            }
            if (formulario == "PUERPERAS SIN CONTROL PUERPERIO")
            {
                OcultarGrids();
                dgvPuerperaSinControl.Location = new Point(55, 91);
                dgvPuerperaSinControl.Visible = true;
                lblTipoDeAlerta.Text = formulario;
            }
            if (formulario == "PUERPERAS SIN 2DO CONTROL PUERPERIO")
            {
                OcultarGrids();
                dgvPuerperaSin2doControl.Location = new Point(55, 91);
                dgvPuerperaSin2doControl.Visible = true;
                lblTipoDeAlerta.Text = formulario;
            }
            if (formulario == "GESTANTES QUE NO ACUDEN A SUS CITAS PRENATALES")
            {
                OcultarGrids();
                dgvGestanteNoAcudeCitas.Location = new Point(7, 91);
                dgvGestanteNoAcudeCitas.Visible = true;
                lblTipoDeAlerta.Text = formulario;
            }
            if (formulario == "GESTANTES SIN EXAMEN DE ODONTOLOGIA")
            {
                OcultarGrids();
                dgvOdontologia.Location = new Point(55, 91);
                dgvOdontologia.Visible = true;
                lblTipoDeAlerta.Text = formulario;
            }
            if (formulario == "GESTANTES SIN EXAMEN DE ECOGRAFIA")
            {
                OcultarGrids();
                dgvEcografia.Location = new Point(55, 91);
                dgvEcografia.Visible = true;
                lblTipoDeAlerta.Text = formulario;
            }
            if (formulario == "GESTANTES SIN 2DO EXAMEN DE ODONTOLOGIA")
            {
                OcultarGrids();
                dgvOdontologia2.Location = new Point(55, 91);
                dgvOdontologia2.Visible = true;
                lblTipoDeAlerta.Text = formulario;
            }
            if (formulario == "GESTANTES SIN 2DO EXAMEN DE ECOGRAFIA")
            {
                OcultarGrids();
                dgvEcografia2.Location = new Point(55, 91);
                dgvEcografia2.Visible = true;
                lblTipoDeAlerta.Text = formulario;
            }

        }
        private void timerActualizar_Tick(object sender, EventArgs e)
        {
            string Tiempo;
            Tiempo = DateTime.Now.Second.ToString();
            if ((int.Parse(Tiempo) % 5) == 0)
            {
                CargarTodosGrid();
                MostrarNuevasGestantesConProblemas();

            }
            else { }
        }
        private void txtRNBajoPeso_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "NUEVA GESTANTE CON PROBLEMAS EN GESSYS V.1", "RECIEN NACIDO CON BAJO PESO DE:" + "\n" + txtRNBajoPeso.Text, ToolTipIcon.Warning);
            notifyIcon1.Text = "RECIEN NACIDOS CON BAJO PESO";
            mostrarAlertaSeleccionada(notifyIcon1.Text);
            SonidoAlerta();
        }

        private void txtGestantePAalta_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "NUEVA GESTANTE CON PROBLEMAS EN GESSYS V.1", "GESTANTE CON PRESION ARTERIAL ELEVADA:" + "\n" + txtGestantePAalta.Text, ToolTipIcon.Warning);
            notifyIcon1.Text = "GESTANTES CON PRESION ARTERIAL ELEVADA";
            mostrarAlertaSeleccionada(notifyIcon1.Text);
            SonidoAlerta();
        }

        private void txtPuerperaSinControl_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "NUEVA GESTANTE CON PROBLEMAS EN GESSYS V.1", "PUERPERA SIN CONTROL PUERPERIO:" + "\n" + txtPuerperaSinControl.Text, ToolTipIcon.Warning);
            notifyIcon1.Text = "PUERPERAS SIN CONTROL PUERPERIO";
            mostrarAlertaSeleccionada(notifyIcon1.Text);
            SonidoAlerta();
        }

        private void txtPuerperaSin2doControl_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "NUEVA GESTANTE CON PROBLEMAS EN GESSYS V.1", "PUERPERA SIN 2DO CONTROL PUERPERIO:" + "\n" + txtPuerperaSin2doControl.Text, ToolTipIcon.Warning);
            notifyIcon1.Text = "PUERPERAS SIN 2DO CONTROL PUERPERIO";
            mostrarAlertaSeleccionada(notifyIcon1.Text);
            SonidoAlerta();
        }

        private void txtGestanteNoAcudeCitas_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "NUEVA GESTANTE CON PROBLEMAS EN GESSYS V.1", "GESTANTE QUE NO ACUDE A SUS CITAS PRENATALES:" + "\n" + txtGestanteNoAcudeCitas.Text, ToolTipIcon.Warning);
            notifyIcon1.Text = "GESTANTES QUE NO ACUDEN A SUS CITAS PRENATALES";
            mostrarAlertaSeleccionada(notifyIcon1.Text);
            SonidoAlerta();
        }

        private void txtodontologia_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "NUEVA GESTANTE CON PROBLEMAS EN GESSYS V.1", "GESTANTE SIN EXAMEN DE ODONTOLOGIA:" + "\n" + txtodontologia.Text, ToolTipIcon.Warning);
            notifyIcon1.Text = "GESTANTES SIN EXAMEN DE ODONTOLOGIA";
            mostrarAlertaSeleccionada(notifyIcon1.Text);
            SonidoAlerta();
        }

        private void txtEcografia_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "NUEVA GESTANTE CON PROBLEMAS EN GESSYS V.1", "GESTANTE SIN EXAMEN DE ECOGRAFIA:" + "\n" + txtEcografia.Text, ToolTipIcon.Warning);
            notifyIcon1.Text = "GESTANTES SIN EXAMEN DE ECOGRAFIA";
            mostrarAlertaSeleccionada(notifyIcon1.Text);
            SonidoAlerta();
        }
        private void dgvOdontologia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvOdontologia.Rows[e.RowIndex].Cells[0].Value != null)
            {
                if (Convert.ToDateTime(dgvOdontologia.Rows[e.RowIndex].Cells["PrimerControlOdo"].Value) <= DateTime.Now)
                {
                    dgvOdontologia.Rows[e.RowIndex].Cells["PrimerControlOdo"].Style.BackColor = Color.Red;
                }
            }
            else { }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dgvEcografia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEcografia.Rows[e.RowIndex].Cells[0].Value != null)
            {
                if (Convert.ToDateTime(dgvEcografia.Rows[e.RowIndex].Cells["PrimerControlEco"].Value) <= DateTime.Now)
                {
                    dgvEcografia.Rows[e.RowIndex].Cells["PrimerControlEco"].Style.BackColor = Color.Red;
                }
            }
            else { }
        }

        private void dgvGestantesSinBateria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvGestantesSinBateria.Rows[e.RowIndex].Cells[0].Value != null)
            {
                if (Convert.ToDateTime(dgvGestantesSinBateria.Rows[e.RowIndex].Cells["FechaBateria1"].Value) <= DateTime.Now)
                {
                    dgvGestantesSinBateria.Rows[e.RowIndex].Cells["FechaBateria1"].Style.BackColor = Color.Red;
                }
            }
            else { }
        }

        private void txtEcografia2_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "NUEVA GESTANTE CON PROBLEMAS EN GESSYS V.1", "GESTANTE SIN 2DO EXAMEN DE ECOGRAFIA:" + "\n" + txtEcografia2.Text, ToolTipIcon.Warning);
            notifyIcon1.Text = "GESTANTES SIN 2DO EXAMEN DE ECOGRAFIA";
            mostrarAlertaSeleccionada(notifyIcon1.Text);
            SonidoAlerta();
        }

        private void txtOdontologia2_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "NUEVA GESTANTE CON PROBLEMAS EN GESSYS V.1", "GESTANTE SIN 2DO EXAMEN DE ECOGRAFIA:" + "\n" + txtOdontologia2.Text, ToolTipIcon.Warning);
            notifyIcon1.Text = "GESTANTES SIN 2DO EXAMEN DE ECOGRAFIA";
            mostrarAlertaSeleccionada(notifyIcon1.Text);
            SonidoAlerta();
        }

        private void dgvEcografia2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEcografia2.Rows[e.RowIndex].Cells[0].Value != null)
            {
                if (Convert.ToDateTime(dgvEcografia2.Rows[e.RowIndex].Cells["FechaControlEco2"].Value) <= DateTime.Now)
                {
                    dgvEcografia2.Rows[e.RowIndex].Cells["FechaControlEco2"].Style.BackColor = Color.Red;
                }
            }
            else { }
        }

        private void dgvOdontologia2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvOdontologia2.Rows[e.RowIndex].Cells[0].Value != null)
            {
                if (Convert.ToDateTime(dgvOdontologia2.Rows[e.RowIndex].Cells["FechaControlOdo2"].Value) <= DateTime.Now)
                {
                    dgvOdontologia2.Rows[e.RowIndex].Cells["FechaControlOdo2"].Style.BackColor = Color.Red;
                }
            }
            else { }
        }
    }
}
