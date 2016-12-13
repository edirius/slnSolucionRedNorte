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
            Close();
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
        public int total_lineas = 0;
        private void MostrarProgreso(int CantidadLineas)
        {
            int porcentaje_avanzado = 0;
            porcentaje_avanzado++;
            total_lineas = CantidadLineas;
            progressBar.Value = (porcentaje_avanzado * 100) / total_lineas;
            progressBar.Update();

            lblStatus.Text = string.Format("Exportando información...{0}%", progressBar.Value);

            if (progressBar.Value == 100)
            {
                lblStatus.Text = "¡Datos exportados exitosamente!";
                total_lineas = 0;
            }
        }
        public bool ContarDatosImportados(string nombreArchivo)
        {
            int porcentaje_avanzado = 0;
            
                    //
                    string[] lineas = File.ReadAllLines(nombreArchivo);
                    total_lineas = lineas.Count();
                    for (int j = 0; j <= total_lineas; j++)
                    {
                        porcentaje_avanzado++;
                        circularProgressBar.Value = (porcentaje_avanzado * 100) / total_lineas;
                        circularProgressBar.Update();
                        lblStatus.Text = string.Format("Importando información...{0}%", circularProgressBar.Value);
                        if (circularProgressBar.Value == 100)
                        {
                            lblStatus.Text = "¡Datos importados exitosamente!";
                            total_lineas = 0;
                        }
                    }
            return true;
        }
        private void btnImportar_Click(object sender, EventArgs e)  
        {
            circularProgressBar.Value = 0;
            //try
            //{
                string CodigoEstablecimiento;
                dlgAbrir.Filter = "Archivos de Exportacion de GESSYS (*.gsys)|*.gsys|Todos los archivos (*.*)|*.*";
            if (this.dlgAbrir.ShowDialog() == DialogResult.OK)
            {
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
                            //oExportar.BorrarDatosTabla(CodigoEstablecimiento);
                            total_lineas = 0;
                            ContarDatosImportados(dlgAbrir.FileName);
                            //oExportar.ImportarDatosArchivoABaseDeDatos(dlgAbrir.FileName);
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
            else
                MessageBox.Show("¡La importación fue cancelada!", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //    catch { }

        }
        private void frmImportarDatos_Load(object sender, EventArgs e)
        {
            cbMicrored.ValueMember = "idtmicrored";
            cbMicrored.DisplayMember = "microred";
            cbMicrored.DataSource = miMicrored.ListarMicrored();
            circularProgressBar.Value = 0;
            circularProgressBar.Minimum = 0;
            circularProgressBar.Maximum = 100;
        }

        private void cbMicrored_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEstablecimientoSalud.ValueMember = "idtestablecimientosalud";
            cbEstablecimientoSalud.DisplayMember = "descripcion";
            cbEstablecimientoSalud.DataSource = miEstablecimiento.ListarEstablecimientoXMicrored(cbMicrored.SelectedValue.ToString());
        }
    }
}
