using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios.EstablecimientoSalud
{
    public class cEstablecimientoSalud
    {
        public string IdEstablecimientoSalud { get; set; }

        public string IdMicrored { get; set; }

        public string Direccion { get; set; }

        public string Descripcion { get; set; }

        public DataTable AgregarEstablecimiento()
        {
            return Conexion.GDatos.TraerDataTable("spCrearEstablecimientoSalud", IdEstablecimientoSalud, IdMicrored, Direccion, Descripcion);
        }
        public DataTable ModificarEstablecimiento()
        {
            return Conexion.GDatos.TraerDataTable("spModificarEstablecimientoSalud", IdEstablecimientoSalud, IdMicrored, Direccion, Descripcion);
        }
        public DataTable EliminarEstablecimiento()
        {
            return Conexion.GDatos.TraerDataTable("spEliminarEstablecimientoSalud", IdEstablecimientoSalud, Descripcion);
        }
        public DataTable ListarEstablecimiento()
        {
            return Conexion.GDatos.TraerDataTable("spListarEstablecimientoSalud");
        }
        public DataTable SiguienteCodigo()
        {
            return Conexion.GDatos.TraerDataTable("spSiguienteCodigoEstablecimiento");
        }
    }
}
