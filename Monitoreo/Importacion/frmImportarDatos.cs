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
using CapaDeDatos;

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
        public int total_lineas = 0;
        int porcentaje_avanzado = 0;
        int total_delimitadores = 0;

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
        
        /*
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
        */

        public bool ContarDatosImportados(string nombreArchivo)
        {
            int porcentaje_avanzado = 0;
                    //
                    string[] lineas = File.ReadAllLines(nombreArchivo);
                    total_lineas = lineas.Count();
                    
            return true;
        }

        public bool InsertarDatosTabla(string nombreTabla, string[] datosTabla)
        {
            
            DataTable tablaAuxiliar;
            string lineaInsertCabeza = "Insert into " + nombreTabla + "(";
            string lineaSQL = "";
            tablaAuxiliar = Conexion.GDatos.TraerDataTableSql("Select * from " + nombreTabla);
            for (int i = 0; i < tablaAuxiliar.Columns.Count; i++)
            {
                lineaInsertCabeza = lineaInsertCabeza + tablaAuxiliar.Columns[i].ColumnName;
                if (i < tablaAuxiliar.Columns.Count - 1)
                {
                    lineaInsertCabeza = lineaInsertCabeza + ",";
                }
            }
            lineaInsertCabeza = lineaInsertCabeza + ") values (";

            //if (nombreTabla == "thistoriaclinica")



            string[] columnas = null;

            for (int i = 0; i < datosTabla.Length; i++)
            {
                lineaSQL = lineaInsertCabeza;

                columnas = datosTabla[i].Split('®');
                for (int j = 0; j < columnas.Length; j++)
                {

                    switch (tablaAuxiliar.Columns[j].DataType.ToString())
                    {
                        case "System.String":
                            /*Desencriptar Aquí en las columnas */
                            lineaSQL = lineaSQL + "'" + cSeguridad.DesEncriptar(columnas[j]) + "'";
                            //lineaSQL = lineaSQL + "'" + columnas[j] + "'";
                            break;
                        case "System.DateTime":
                            /*Desencriptar Aquí en las columnas */
                            DateTime fechaAUxiliar = Convert.ToDateTime(cSeguridad.DesEncriptar(columnas[j]));
                            //DateTime fechaAUxiliar = Convert.ToDateTime(columnas[j]);
                            //lineaSQL = lineaSQL + "'" + fechaAUxiliar + "'";
                            lineaSQL = lineaSQL + "'" + fechaAUxiliar.ToString("yyyy-MM-dd hh:mm:ss") + "'";
                            break;

                        //case "System.Decimal":
                        //    /*Desencriptar Aquí en las columnas */
                        //    //DateTime fechaAUxiliar = Convert.ToDateTime(cSeguridad.DesEncriptar(columnas[j]));
                        //    //lineaSQL = lineaSQL + "'" + fechaAUxiliar + "'";
                        //    lineaSQL = lineaSQL + "" + cSeguridad.DesEncriptar(Convert.ToDecimal(columnas[j]).ToString()) + "";
                        //    break;

                        default:
                            /*Desencriptar Aquí en las columnas */
                            lineaSQL = lineaSQL + cSeguridad.DesEncriptar(columnas[j]);
                            //lineaSQL = lineaSQL + columnas[j];
                            break;
                    }


                    if (j < columnas.Length - 1)
                    {
                        lineaSQL = lineaSQL + ",";
                    }
                    else
                    {
                        lineaSQL = lineaSQL + ")";
                    }



                }

                Conexion.GDatos.EjecutarSql(lineaSQL);

                porcentaje_avanzado++;
                circularProgressBar.Value = (porcentaje_avanzado * 100) / (total_lineas- total_delimitadores/2);
                
                circularProgressBar.Update();
                this.Update();
                lblStatus.Text = string.Format("Importando información...{0}%", circularProgressBar.Value);
                lblStatus.Update();

                //txtPb.Text = circularProgressBar.Value+"%";
                //txtPb.Update();

                //MessageBox.Show(circularProgressBar.Value+"%");
                if (circularProgressBar.Value == 100)
                {
                    lblStatus.Text = "¡Datos importados exitosamente!";
                    total_lineas = 0;
                    porcentaje_avanzado = 0;
                }

            }
            return true;
        }

        public bool ImportarDatosArchivoABaseDeDatos(string nombreArchivo)
        {

            /*
            try
            {
            */
            string[] archivos;
            

            using (System.IO.StreamReader ReadFile = new System.IO.StreamReader(nombreArchivo))
            {
                string FileText = ReadFile.ReadToEnd();
                string[] delimiters = new string[] { "@@" };
                archivos = FileText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            }
            string nombreTablaAuxiliar = "";
            string[] contenidoAuxiliar = null;
            string[] camposAuxiliar = null;

            total_delimitadores = archivos.Length;

            for (int i = 0; i < archivos.Length; i = i + 2)
            {
                nombreTablaAuxiliar = archivos[i];
                string[] delimiters2 = new string[] { "\r\n" };
                contenidoAuxiliar = archivos[i + 1].Split(delimiters2, StringSplitOptions.RemoveEmptyEntries);
                
                InsertarDatosTabla(nombreTablaAuxiliar, contenidoAuxiliar);
                
                

            }

            return true;
            /*
            }
            catch (Exception ex)
            {
                throw new cReglaNegocioException("Error al importar Datos: " + ex.Message);
            }
            */

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
                lblStatus.Text = "Cargando...";
                lblStatus.Update();
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
                            total_lineas = 0;
                            ContarDatosImportados(dlgAbrir.FileName);

                            ImportarDatosArchivoABaseDeDatos(dlgAbrir.FileName);
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
            else { 
                MessageBox.Show("¡La importación fue cancelada!", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblStatus.Text = "";
                lblStatus.Update();
            }
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
