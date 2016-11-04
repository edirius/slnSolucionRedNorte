using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios
{
    public class cMorbilidad
    {
        public string Idtmorbilidad { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public string Idtestablecimientosalud { get; set; }

        public DataTable CrearMorbilidad()
        {
            return Conexion.GDatos.TraerDataTable("spCrearMantenimientoMorbilidad", Descripcion, Tipo, Idtestablecimientosalud);
        }

        public DataTable ModificarMorbilidad()
        {
            return Conexion.GDatos.TraerDataTable("spModificarMantenimientoMorbilidad", Idtmorbilidad, Descripcion, Tipo, Idtestablecimientosalud);
        }

        public DataTable EliminarMorbilidad()
        {
            return Conexion.GDatos.TraerDataTable("spEliminarMantenimientoMorbilidad", Idtmorbilidad);
        }

        public DataTable ListarMorbilidad()
        {
            return Conexion.GDatos.TraerDataTable("spListarMantenimientoMorbilidad", Idtestablecimientosalud);
        }

        public DataTable BuscarMorbilidad()
        {
            return Conexion.GDatos.TraerDataTable("spBusquedaMantenimientoMorbilidad", Descripcion);
        }

    }
}
