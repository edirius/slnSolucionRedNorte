using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;
//using MySql.Data.MySqlClient;

namespace CapaDeNegocios.Exportacion
{
    public class cExportar
    {
        string rutaArchivo;

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

        public List<string> TraerDatosTabla(string nombreTabla)
        {
            List<string>  filasTabla = new List<string>();
            DataTable tablaAuxiliar;
            string lineaInsert= "";
            string lineaInsertCabeza = "Insert into " + nombreTabla + "(";

            tablaAuxiliar = Conexion.GDatos.TraerDataTableSql("Select * from " + nombreTabla);
            foreach (DataColumn col in tablaAuxiliar.Columns)
            {
                lineaInsertCabeza = lineaInsertCabeza + col.ColumnName + "," ;
                
                
            }

            lineaInsertCabeza = lineaInsertCabeza + ") values (";

            foreach (DataRow fila in tablaAuxiliar.Rows)
            {
                lineaInsert = lineaInsertCabeza;
                for (int i = 0; i < tablaAuxiliar.Columns.Count; i++)
                {
                    if ( tablaAuxiliar.Columns[i].DataType.Name == "String" )
                    {
                        lineaInsert = lineaInsert + "'" + (fila[i]).ToString() + "'" + ",";
                    }
                    else
                    {
                        //(MySql.Data.MySqlClient.MySqlDbType)fila[i];
                        lineaInsert = lineaInsert + (fila[i]).ToString() + ",";
                    }
                    
                    
                }
                
            }
            lineaInsert = lineaInsert + ");";
            filasTabla.Add(lineaInsert);
            
            return filasTabla;
        }
        //insert into tObstetra(idObstetra, nombre, apellido, fecha) values(
    }
}
