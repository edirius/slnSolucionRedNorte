using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios.Reportes
{
    public class cReporteObstetra
    {
        public DataTable ReporteObstetra()
        {
            return Conexion.GDatos.TraerDataTable("spReporteObstetra");
        }
    }
}
