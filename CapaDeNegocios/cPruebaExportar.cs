using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Data;

namespace CapaDeNegocios
{
    public class cPruebaExportar
    {
        public DataTable ListarMicroRed()
        {
            return Conexion.GDatos.TraerDataTable("spListarMicrored");
        }
        public DataTable ListarEstablecimientoSalud()
        {
            return Conexion.GDatos.TraerDataTable("spListarEstablecimientoSalud");
        }

    }
}
