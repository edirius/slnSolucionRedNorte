using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios.Alertas
{
    public class cAlertas
    {
        public DataTable ListarGestantesQueNoAcudenCita(string codigoEstablecimiento)
        {
            return Conexion.GDatos.TraerDataTable("spListarGestantesQueNoAcudenALasCitas", codigoEstablecimiento);
        }

        public DataTable ListarGestanteConRiesgoXPresionArterial(string codigoEstablecimiento, int presionarterialMaxS, int presionarterialMaxD)
        {
            return Conexion.GDatos.TraerDataTable("spListarGestantesConRiesgoXPresionArterial", presionarterialMaxS, presionarterialMaxD, codigoEstablecimiento);
        }
    }
}
