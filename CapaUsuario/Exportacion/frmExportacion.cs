using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using CapaDeNegocios;
using CapaDeNegocios.Exportacion;
using System.Collections;
namespace CapaUsuario.Exportacion
{
    public partial class frmExportacion : Form
    {
        public frmExportacion()
        {
            InitializeComponent();
        }
        cExportar oExportar = new cExportar();
        
        public string NombreObstetra { get; set; }
        public string IdObstetra { get; set; }
        public string NombreEstablecimientoSalud { get; set; }
        public string IdEstablecimientoSalud { get; set; }

        private void frmExportacion_Load(object sender, EventArgs e)
        {
            
        }

        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
        //                                                               Color.DarkBlue,
        //                                                               Color.Aquamarine,
        //                                                               45F))
        //    {
        //        e.Graphics.FillRectangle(brush, this.ClientRectangle);
        //    }
        //}
        string NombreArchivo;
        private async void btnExportar_Click(object sender, EventArgs e)
        {
            try { }
            catch { }
            oExportar.CodigoEstablecimiento = IdEstablecimientoSalud;
            dlgGuardar.Filter = "Archivos de Exportacion de GESSYS (*.GSYS)|*.GSYS";
            dlgGuardar.DefaultExt = ".GSYS";

            char[] delimiter = { '/' };
            string[] substring = (IdEstablecimientoSalud + NombreEstablecimientoSalud + DateTime.Today.ToShortDateString()).Split(delimiter);
            NombreArchivo = substring[0].ToString() + substring[1].ToString() + substring[2].ToString();
            dlgGuardar.FileName = NombreArchivo;
            dlgGuardar.ShowDialog();
            IniciarCarga();
            oExportar.InsertarDatosTablaAarchivo(dlgGuardar.FileName, "tobstetra", "tpaciente", "tecografia", "todontologia", "tgestantemorbilidad", "tcitaprenatal", "tbateria", "tcontrolpeuperio", "treciennacido", "tterminogestacion", "tvisitadomiciliariagestante", "tvisitadomiciliariapuerperarn", "thistoriaclinica");
            /////
            /////
            MessageBox.Show("Datos exportando en la ubicación: " + dlgGuardar.FileName);
        }
        
        private async void btnImportar_Click(object sender, EventArgs e)
        {
            
            //dlgAbrir.Filter = "Archivos de Exportacion de GESSYS (*.gsys)|*.gsys|Todos los archivos (*.*)|*.*";
            //dlgAbrir.ShowDialog();
            ////oExportar.BorrarDatosTabla(IdEstablecimientoSalud);
            //MessageBox.Show(IdEstablecimientoSalud);
            //oExportar.ImportarDatosArchivoABaseDeDatos(dlgAbrir.FileName);

            /////////////////////////////

        }
        private async void IniciarCarga()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 1000; i++)
                list.Add(i.ToString());
            lblStatus.Text = "Exportando...";
            var progress = new Progress<cProgressReport>();
            progress.ProgressChanged += (o, report) =>
            {
                lblStatus.Text = string.Format("Exportando información...{0}%", report.PercentComplete);
                progressBar.Value = report.PercentComplete;
                progressBar.Update();
            };
            await ProcessData(list, progress);
            lblStatus.Text = "¡Datos exportados exitosamente!";
        }
        private Task ProcessData(List<string> list, IProgress<cProgressReport> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var progressReport = new cProgressReport();
            return Task.Run(()=>
            {
                for (int i = 0; i < totalProcess; i++)
                {
                    progressReport.PercentComplete = index++ * 100 / totalProcess;
                    progress.Report(progressReport);
                    Thread.Sleep(10); //
                }
            });

        }
    }
}
