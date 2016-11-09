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

        public DataTable CrearMantenimientoMorbilidad()
        {
            return Conexion.GDatos.TraerDataTable("spCrearMantenimientoMorbilidad", Descripcion, Tipo, Idtestablecimientosalud);
        }

        public DataTable ModificarMantenimientoMorbilidad()
        {
            return Conexion.GDatos.TraerDataTable("spModificarMantenimientoMorbilidad", Idtmorbilidad, Descripcion, Tipo, Idtestablecimientosalud);
        }

        public DataTable EliminarMantenimientoMorbilidad()
        {
            return Conexion.GDatos.TraerDataTable("spEliminarMantenimientoMorbilidad", Idtmorbilidad);
        }

        public DataTable ListarMantenimientoMorbilidad()
        {
            return Conexion.GDatos.TraerDataTable("spListarMantenimientoMorbilidad");
        }

        public DataTable ListarMorbilidadXTipo()
        {
            return Conexion.GDatos.TraerDataTable("spListarMorbilidadXTipo", Tipo);
        }

        public DataTable BuscarMorbilidad()
        {
            return Conexion.GDatos.TraerDataTable("spBusquedaMantenimientoMorbilidad", Descripcion);
        }

        public DataTable CrearMorbilidad()
        {
            return Conexion.GDatos.TraerDataTable("spCrearMorbilidad", Descripcion, Tipo, Idtestablecimientosalud);
        }

    }
}
