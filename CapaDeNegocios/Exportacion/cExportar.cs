using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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

        public Boolean ExportarDatos ()
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
                if (i < tablaAuxiliar.Columns.Count -1 )
                {
                    lineaInsertCabeza = lineaInsertCabeza + ",";
                }
            }
            lineaInsertCabeza = lineaInsertCabeza + ") values (";
            
            string[] columnas = null;

            for (int i = 0; i < datosTabla.Length; i++)
            {
                lineaSQL = lineaInsertCabeza;

                columnas = datosTabla[i].Split(',');
                for (int j = 0; j < columnas.Length; j++)
                {

                    switch (tablaAuxiliar.Columns[j].DataType.ToString())
                    {
                        case "System.String":
                            /*Desencriptar Aquí en las columnas */ lineaSQL = lineaSQL + "'" + columnas[j] + "'";
                            break;
                        case "System.DateTime":
                            /*Desencriptar Aquí en las columnas */ DateTime fechaAUxiliar = Convert.ToDateTime(columnas[j]);

                            lineaSQL = lineaSQL + "'" + fechaAUxiliar.ToString("yyyy-MM-dd") + "'";
                            break;
                        default:
                            /*Desencriptar Aquí en las columnas */ lineaSQL = lineaSQL + columnas[j];
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
        //insert into tObstetra(idObstetra, nombre, apellido, fecha) values(

        public bool InsertarDatosTablaAarchivo(string nombreArchivo,params string[] nombresTablas)
        {
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
                                    
                                    /*Desencriptar Aquí*/ Output.Write(tAuxiliar.Rows[i][col.Ordinal].ToString());
                                    if (col.Ordinal < tAuxiliar.Columns.Count - 1)
                                    {
                                        Output.Write(",");
                                    }
                                    else
                                    {
                                        Output.WriteLine();
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
                throw new cReglaNegocioException ("Error al insertar datos al backup: " + e.Message );
            }
        } 

        public bool ImportarDatosArchivoABaseDeDatos(string nombreArchivo)
        {
            try
            {
                string[] archivos;
                
                using (System.IO.StreamReader ReadFile = new System.IO.StreamReader(nombreArchivo))
                {
                    string FileText = ReadFile.ReadToEnd();
                    string[] delimiters = new string[] { "@@" };
                    archivos = FileText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                }
                string nombreTablaAuxiliar= "";
                string[] contenidoAuxiliar = null;
                string[] camposAuxiliar = null;
                for (int i = 0; i < archivos.Length; i=i+2)
                {
                    nombreTablaAuxiliar = archivos[i];
                    string[] delimiters2 = new string[] { "\r\n" };
                    contenidoAuxiliar = archivos[i + 1].Split(delimiters2,StringSplitOptions.RemoveEmptyEntries);
                    InsertarDatosTabla(nombreTablaAuxiliar, contenidoAuxiliar);
                    //for (int j = 0; j < contenidoAuxiliar.Length; j++)
                    //{
                    //    camposAuxiliar = contenidoAuxiliar[j].Split(',');
                    //    switch (nombreTablaAuxiliar)
                    //    {
                    //        case "tobstetra":
                    //            Obstetra.cObstetra oObstetra = new Obstetra.cObstetra();
                    //            oObstetra.idtobstetra = camposAuxiliar[0];
                    //            oObstetra.nombres = camposAuxiliar[1];
                    //            oObstetra.apellidopaterno = camposAuxiliar[2];
                    //            oObstetra.apellidomaterno = camposAuxiliar[3];
                    //            oObstetra.sexo = camposAuxiliar[4];
                    //            oObstetra.dni = camposAuxiliar[5];
                    //            oObstetra.fechanacimiento = Convert.ToDateTime(camposAuxiliar[6]);
                    //            oObstetra.direccion = camposAuxiliar[7];
                    //            oObstetra.telefono = camposAuxiliar[8];
                    //            oObstetra.tituloprofesional = camposAuxiliar[9];
                    //            oObstetra.idtestablecimientosalud = camposAuxiliar[10];
                    //            oObstetra.usuario = camposAuxiliar[11];
                    //            oObstetra.password = camposAuxiliar[12];
                    //            oObstetra.CrearObstetra(oObstetra);
                    //            break;
                    //        case "thistoriaclinica":
                    //            cHistoriaClinica oHistoriaClinica = new cHistoriaClinica();
                    //            oHistoriaClinica.Idtestablecimientosalud = camposAuxiliar[0];
                    //            oHistoriaClinica.Codigohistoriaclinica = camposAuxiliar[0];
                    //            oHistoriaClinica.Tipollegada = camposAuxiliar[0];
                    //            oHistoriaClinica.Tiempollegada = camposAuxiliar[0];
                    //            oHistoriaClinica.Edad = Convert.ToInt16(camposAuxiliar[0]);
                    //            oHistoriaClinica.Gestas = Convert.ToInt16(camposAuxiliar[0]);
                    //            oHistoriaClinica.Partos = Convert.ToInt16(camposAuxiliar[0]);
                    //            oHistoriaClinica.Abortos = Convert.ToInt16(camposAuxiliar[0]);
                    //            oHistoriaClinica.Hijosvivos = Convert.ToInt16(camposAuxiliar[0]);
                    //            oHistoriaClinica.Hijosmuertos = Convert.ToInt16(camposAuxiliar[0]);
                    //            oHistoriaClinica.Fur = Convert.ToDateTime(camposAuxiliar[0]);
                    //            oHistoriaClinica.Fpp = Convert.ToDateTime(camposAuxiliar[0]);

                    //            oHistoriaClinica.Trimestreapn = Convert.ToInt16(camposAuxiliar[0]);
                    //            oHistoriaClinica.Diaapn = camposAuxiliar[0];
                    //            oHistoriaClinica.Observaciones = camposAuxiliar[0];
                    //            oHistoriaClinica.Idtpaciente = camposAuxiliar[0];
                    //            oHistoriaClinica.Idtobstetra = camposAuxiliar[0];
                    //            oHistoriaClinica.Fecha = Convert.ToDateTime(camposAuxiliar[0]);
                    //            oHistoriaClinica.Transeunte = Convert.ToInt16(camposAuxiliar[0]);
                    //            oHistoriaClinica.OrigenEESS = camposAuxiliar[0];
                    //            break;

                    //        default:
                    //            break;
                    //    }
                    //}

                }

                return true;
            }
            catch ( Exception ex)
            {
                throw new cReglaNegocioException ("Error al importar Datos: " + ex.Message);
            }
        }
    }
}
