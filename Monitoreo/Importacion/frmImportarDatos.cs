using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CapaDeNegocios;
using CapaDeNegocios.Exportacion;
using System.IO;
namespace Monitoreo.Importacion
{
    public partial class frmImportarDatos : Form
    {
        CapaDeNegocios.Exportacion.cExportar oExportar = new CapaDeNegocios.Exportacion.cExportar();
        CapaDeNegocios.EstablecimientoSalud.cEstablecimientoSalud miEstablecimiento = new CapaDeNegocios.EstablecimientoSalud.cEstablecimientoSalud();
        CapaDeNegocios.EstablecimientoSalud.cMicrored miMicrored = new CapaDeNegocios.EstablecimientoSalud.cMicrored();
        public string NombreObstetra { get; set; }
        public string IdObstetra { get; set; }
        public string NombreEstablecimientoSalud { get; set; }
        public string IdEstablecimientoSalud { get; set; }
        public frmImportarDatos()
        {
            InitializeComponent();
            
        }
        private async void btnExportar_Click(object sender, EventArgs e)
        {
            dlgGuardar.Filter = "Archivos de Exportacion de GESSYS (*.gsys)|*.gsys";
            dlgGuardar.DefaultExt = ".gsys";
            dlgGuardar.ShowDialog();
            IniciarCarga();
            oExportar.CodigoEstablecimiento = IdEstablecimientoSalud;
            oExportar.InsertarDatosTablaAarchivo(dlgGuardar.FileName, "tobstetra", "tpaciente", "tecografia", "todontologia", "tgestantemorbilidad", "tcitaprenatal", "tbateria", "tcontrolpeuperio", "treciennacido", "tterminogestacion", "tvisitadomiciliariagestante", "tvisitadomiciliariapuerperarn", "thistoriaclinica");
            /////
            /////
            MessageBox.Show("Datos exportando en la ubicación: " + dlgGuardar.FileName);
        }
        public static string ExtractFilename(string filepath)
        {
            // If path ends with a "\", it's a path only so return String.Empty.
            if (filepath.Trim().EndsWith(@"\"))
                return String.Empty;

            // Determine where last backslash is.
            int position = filepath.LastIndexOf('\\');
            // If there is no backslash, assume that this is a filename.
            if (position == -1)
            {
                // Determine whether file exists in the current directory.
                if (File.Exists(Environment.CurrentDirectory + Path.DirectorySeparatorChar + filepath))
                    return filepath;
                else
                    return String.Empty;
            }
            else
            {
                // Determine whether file exists using filepath.
                if (File.Exists(filepath))
                    // Return filename without file path.
                    return filepath.Substring(position + 1);
                else
                    return String.Empty;
            }
        }
        private void btnImportar_Click(object sender, EventArgs e)  
        {
            //SYNC
            try
            {
                string CodigoEstablecimiento;
                dlgAbrir.Filter = "Archivos de Exportacion de GESSYS (*.gsys)|*.gsys|Todos los archivos (*.*)|*.*";
                dlgAbrir.ShowDialog();
                string CadenaTexto = "";
                CadenaTexto = dlgAbrir.FileName.ToString();
                CodigoEstablecimiento = (ExtractFilename(CadenaTexto)).Substring(0, 4);

                if (cbEstablecimientoSalud.SelectedValue.ToString() == CodigoEstablecimiento)
                {
                    MessageBox.Show("Importando datos del establecimiento '" + cbEstablecimientoSalud.Text + "'", "Mensaje de importación...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string[] archivos;
                    using (System.IO.StreamReader ReadFile = new System.IO.StreamReader(dlgAbrir.FileName))
                    {
                        string FileText = ReadFile.ReadToEnd();
                        string[] delimiters = new string[] { "@@" };
                        archivos = FileText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                        if (archivos.Length != 0)
                        {
                            oExportar.BorrarDatosTabla(CodigoEstablecimiento);
                            oExportar.ImportarDatosArchivoABaseDeDatos(dlgAbrir.FileName);
                            IniciarCircularProgressBar();
                            IniciarCarga();
                        }
                        else
                        {
                            MessageBox.Show("El archivo esta vacio.", "Mensaje de error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("El código de establecimiento '" + cbEstablecimientoSalud.Text + "' no coincide con el código del establecimiento del archivo. Asegúrese que esta importando los datos del establecimiento seleccionado.", "Mensaje de error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }

        }
        private async void IniciarCarga()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 500; i++)
                list.Add(i.ToString());
            lblStatus.Text = "Importando...";
            var progress = new Progress<cProgressReport>();
            progress.ProgressChanged += (o, report) =>
            {
                lblStatus.Text = string.Format("Importando información...{0}%", report.PercentComplete);
                progressBar.Value = report.PercentComplete;
                progressBar.Update();
            };
            await ProcessData(list, progress);
            lblStatus.Text = "¡Datos importados exitosamente!";
        }
        private Task ProcessData(List<string> list, IProgress<cProgressReport> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var progressReport = new cProgressReport();
            return Task.Run(() =>
            {
                for (int i = 0; i < totalProcess; i++)
                {
                    progressReport.PercentComplete = index++ * 100 / totalProcess;
                    progress.Report(progressReport);
                    Thread.Sleep(10); //
                }
            });

        }

        private void frmImportarDatos_Load(object sender, EventArgs e)
        {
            cbMicrored.ValueMember = "idtmicrored";
            cbMicrored.DisplayMember = "microred";
            cbMicrored.DataSource = miMicrored.ListarMicrored();
            circularProgressBar.Value = 0;
            circularProgressBar.Minimum = 0;
            circularProgressBar.Maximum = 1000;
        }

        private void cbMicrored_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEstablecimientoSalud.ValueMember = "idtestablecimientosalud";
            cbEstablecimientoSalud.DisplayMember = "descripcion";
            cbEstablecimientoSalud.DataSource = miEstablecimiento.ListarEstablecimientoXMicrored(cbMicrored.SelectedValue.ToString());
        }
        private void IniciarCircularProgressBar()
        {
            for (int i = 1; i <= 1000; i++)
            {
                Thread.Sleep(5);
                circularProgressBar.Value = i;
                circularProgressBar.Update();
            }
        }
    }
}
