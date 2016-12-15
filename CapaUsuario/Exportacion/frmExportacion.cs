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
using CapaDeDatos;

namespace CapaUsuario.Exportacion
{
    public partial class frmExportacion : Form
    {
        int total_lineas = 0;

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
            lblEstablecimiento.Text = NombreEstablecimientoSalud;
            lblObstetra.Text = NombreObstetra;
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

        public bool InsertarDatosTablaAarchivo(string nombreArchivo, params string[] nombresTablas)
        {
            int porcentaje_avanzado = 0;
            string campo = "";
            DataTable tAuxiliar;
            try
            {

                using (System.IO.StreamWriter Output = new System.IO.StreamWriter(nombreArchivo))
                {
                    foreach (string iTablas in nombresTablas)
                    {
                        tAuxiliar = Conexion.GDatos.TraerDataTableSql("Select * from " + iTablas);
                        tAuxiliar = Conexion.GDatos.TraerDataTableSql("Select * from " + iTablas + " where left(" + tAuxiliar.Columns[0].ColumnName + ", 4) = '" + IdEstablecimientoSalud + "'");
                        if (tAuxiliar.Rows.Count > 0)
                        {
                            Output.WriteLine("@@" + iTablas + "@@");
                            for (int i = 0; i < tAuxiliar.Rows.Count; i++)
                            {

                                foreach (DataColumn col in tAuxiliar.Columns)
                                {

                                    /*Encriptar Aquí*/
                                    
                                    campo = tAuxiliar.Rows[i][col.Ordinal].ToString();
                                    campo = campo.Replace(System.Environment.NewLine, " ");

                                    //Output.Write(campo);
                                    Output.Write(cSeguridad.Encriptar(campo));
                                    if (col.Ordinal < tAuxiliar.Columns.Count - 1)
                                    {
                                        Output.Write("®");
                                    }
                                    else
                                    {
                                        Output.WriteLine();
                                        porcentaje_avanzado++;
                                        
                                        progressBar.Value = (porcentaje_avanzado*100)/total_lineas;
                                        progressBar.Update();

                                        lblStatus.Text = string.Format("Exportando información...{0}%", progressBar.Value);

                                        if (progressBar.Value == 100) {
                                            lblStatus.Text = "¡Datos exportados exitosamente!";
                                            total_lineas = 0;
                                        }
                                            

                                    }
                                }

                            }
                        }

                    }
                }
                return true;
            }
            catch (Exception e)
            {
                throw new cReglaNegocioException("Error al insertar datos al backup: " + e.Message);
            }
        }

        string NombreArchivo;
        private async void btnExportar_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            try
            {
                oExportar.CodigoEstablecimiento = IdEstablecimientoSalud;
                dlgGuardar.Filter = "Archivos de Exportacion de GESSYS (*.GSYS)|*.GSYS";
                dlgGuardar.DefaultExt = ".GSYS";

                char[] delimiter = { '/' };
                string[] substring = (IdEstablecimientoSalud + NombreEstablecimientoSalud + DateTime.Today.ToShortDateString()).Split(delimiter);
                NombreArchivo = substring[0].ToString() + substring[1].ToString() + substring[2].ToString();
                dlgGuardar.FileName = NombreArchivo;
                //dlgGuardar.ShowDialog();
                if (this.dlgGuardar.ShowDialog() == DialogResult.OK)
                {
                    total_lineas = 0;
                    total_lineas = oExportar.ContarDatosTablaAarchivo(dlgGuardar.FileName, "tobstetra", "tpaciente", "thistoriaclinica", "tecografia", "todontologia", "tgestantemorbilidad", "tcitaprenatal", "tbateria", "tcontrolpeuperio", "treciennacido", "tterminogestacion", "tvisitadomiciliariagestante", "tvisitadomiciliariapuerperarn");
                    //oExportar.InsertarDatosTablaAarchivo(dlgGuardar.FileName, "tobstetra", "tpaciente", "thistoriaclinica", "tecografia", "todontologia", "tgestantemorbilidad", "tcitaprenatal", "tbateria", "tcontrolpeuperio", "treciennacido", "tterminogestacion", "tvisitadomiciliariagestante", "tvisitadomiciliariapuerperarn");
                    InsertarDatosTablaAarchivo(dlgGuardar.FileName, "tobstetra", "tpaciente", "thistoriaclinica", "tecografia", "todontologia", "tgestantemorbilidad", "tcitaprenatal", "tbateria", "tcontrolpeuperio", "treciennacido", "tterminogestacion", "tvisitadomiciliariagestante", "tvisitadomiciliariapuerperarn");
                    MessageBox.Show("Datos exportando en la ubicación: " + dlgGuardar.FileName, "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("¡La exportación fue cancelada!", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                dlgGuardar.Dispose();
            }
            catch
            {
                progressBar.Visible = false;
                lblStatus.Visible = false;
            }
            
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
        private async void IniciarCarga(int progreso)
        {
            progressBar.Visible = true;
            lblStatus.Visible = true;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
