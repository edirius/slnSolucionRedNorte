using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios
{
    public class cSiguienteCodigo
    {

        public DataTable SiguientesCodigo(string tabla, string idtestablecimientosalud)
        {
            return Conexion.GDatos.TraerDataTable("spSiguienteCodigo", tabla, idtestablecimientosalud);
        }
    }
}
