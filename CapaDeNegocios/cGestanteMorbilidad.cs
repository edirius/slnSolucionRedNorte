using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios
{
    public class cGestanteMorbilidad
    {
        public string idtgestantemorbilidad { get; set; }
        public string idthistoriaclinica { get; set; }
        public string idtmorbilidad { get; set; }
        public string idtestablecimientosalud { get; set; }
        public DateTime fecha { get; set; }

        public DataTable CrearGestanteMorbilidad()
        {
            return Conexion.GDatos.TraerDataTable("spCrearGestanteMorbilidad", idthistoriaclinica, idtmorbilidad, fecha, idtestablecimientosalud);
        }

        public DataTable ListarGestanteMorbilidad()
        {
            return Conexion.GDatos.TraerDataTable("spListarGestanteMorbilidad", idthistoriaclinica);
        }

        public DataTable EliminarGestanteMorbilidad()
        {
            return Conexion.GDatos.TraerDataTable("spEliminarGestanteMorbilidad", idthistoriaclinica);
        }

    }
}
