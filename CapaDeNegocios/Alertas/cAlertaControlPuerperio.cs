using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios.Alertas
{
    public class cAlertaControlPuerperio
    {
        public DataTable ListarAlertaControlPuerperio(string pidtobstetra, string pidtestablecimientosalud)
        {
            return Conexion.GDatos.TraerDataTable("spAlertaControlPuerperio", pidtobstetra, pidtestablecimientosalud);
        }
    }
}
