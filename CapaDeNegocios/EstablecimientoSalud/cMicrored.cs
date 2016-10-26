using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios.EstablecimientoSalud
{
    public class cMicrored
    {
        public string IdMicrored { get; set; }

        public string Microred { get; set; }

        public string Direccion { get; set; }

        public DataTable AgregarMicrored()
        {
            return Conexion.GDatos.TraerDataTable("spCrearMicrored", IdMicrored, Microred, Direccion);
        }
        public DataTable ModificarMicrored()
        {
            return Conexion.GDatos.TraerDataTable("spModificarMicrored", IdMicrored, Microred, Direccion);
        }
        public DataTable EliminarMicrored()
        {
            return Conexion.GDatos.TraerDataTable("spEliminarMicrored", IdMicrored, Microred);
        }
        public DataTable ListarMicrored()
        {
            return Conexion.GDatos.TraerDataTable("spListarMicrored");
        }
    }
}
