using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;
using System.IO;
using System.Windows.Forms;

namespace CapaDeNegocios.Exportacion
{
    public class cExportar
    {
        string rutaArchivo;
        public string CodigoEstablecimiento { get; set; }

        string[] tablas;
        


        public string RutaArchivo
        {
            get
            {
                return rutaArchivo;
            }

            set
            {
                rutaArchivo = value;
            }
        }

        public Boolean ExportarDatos()
        {
            //ConseguirDatosTabla("");
            return true;
        }

        public bool BorrarDatosTabla(string codigoEstablecimiento)
        {
            try
            {
                Conexion.GDatos.Ejecutar("spBorrarDatosTabla", codigoEstablecimiento);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
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
                            lineaSQL = lineaSQL + "'" +  cSeguridad.DesEncriptar(columnas[j]) + "'";
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
            }
            return true;
        }

        cUtilitarios miUtilitario = new cUtilitarios();

        

        public int ContarDatosTablaAarchivo(string nombreArchivo, params string[] nombresTablas)
        {
            int cantidad_lineas = 0;
            DataTable tAuxiliar;
            try
            {

                using (System.IO.StreamWriter Output = new System.IO.StreamWriter(nombreArchivo))
                {
                    foreach (string iTablas in nombresTablas)
                    {
                        tAuxiliar = Conexion.GDatos.TraerDataTableSql("Select * from " + iTablas);
                        tAuxiliar = Conexion.GDatos.TraerDataTableSql("Select * from " + iTablas + " where left(" + tAuxiliar.Columns[0].ColumnName + ", 4) = '" + CodigoEstablecimiento + "'");
                        if (tAuxiliar.Rows.Count > 0)
                        {
                            Output.WriteLine("@@" + iTablas + "@@");
                            for (int i = 0; i < tAuxiliar.Rows.Count; i++)
                            {

                                foreach (DataColumn col in tAuxiliar.Columns)
                                {

                                    /*Encriptar Aquí*/
                                    Output.Write(cSeguridad.Encriptar(tAuxiliar.Rows[i][col.Ordinal].ToString()));
                                    //Output.Write(tAuxiliar.Rows[i][col.Ordinal].ToString());
                                    if (col.Ordinal < tAuxiliar.Columns.Count - 1)
                                    {
                                        Output.Write("®");
                                    }
                                    else
                                    {
                                        Output.WriteLine();
                                        cantidad_lineas++;
                                        
                                    }
                                }

                            }
                        }

                    }

                }

                //MessageBox.Show(cantidad_lineas.ToString());
                return cantidad_lineas;
            }
            catch (Exception e)
            {
                throw new cReglaNegocioException("Error al insertar datos al backup: " + e.Message);
            }
        }

        public int Contador(int c) {
            return c;
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
    }
}
