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
using CapaDeDatos;
using System.IO;

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
        
    }
}
