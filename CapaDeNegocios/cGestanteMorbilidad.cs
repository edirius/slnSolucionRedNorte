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
        public string idtobstetra { get; set; }
        public DateTime fecha { get; set; }

        public DataTable CrearGestanteMorbilidad()
        {
            return Conexion.GDatos.TraerDataTable("spCrearGestanteMorbilidad", idthistoriaclinica, idtmorbilidad, fecha, idtestablecimientosalud, idtobstetra);
        }

        public DataTable ListarGestanteMorbilidad()
        {
            return Conexion.GDatos.TraerDataTable("spListarGestanteMorbilidad", idthistoriaclinica);
        }

        public DataTable EliminarGestanteMorbilidad()
        {
            return Conexion.GDatos.TraerDataTable("spEliminarGestanteMorbilidad", idtgestantemorbilidad);
        }

        public DataTable ExisteGestanteMorbilidad()
        {
            return Conexion.GDatos.TraerDataTable("spExisteGestanteMorbilidad", idtgestantemorbilidad);
        }

        public DataTable ReporteMorbilidadExtrema(int Ene, int Feb, int Mar, int Abr, int May, int Jun, int Jul, int Ago, int Sep, int Oct, int Nov, int Dic, int Año)
        {
            return Conexion.GDatos.TraerDataTable("spReporteMorbilidadExtrema", Ene,Feb,Mar,Abr,May,Jun,Jul,Ago,Sep,Oct,Nov,Dic,Año );
        }

        public DataTable ReporteMorbilidadPotencial(int Ene, int Feb, int Mar, int Abr, int May, int Jun, int Jul, int Ago, int Sep, int Oct, int Nov, int Dic, int Año)
        {
            return Conexion.GDatos.TraerDataTable("spReporteMorbilidadPotencial", Ene, Feb, Mar, Abr, May, Jun, Jul, Ago, Sep, Oct, Nov, Dic, Año);
        }

    }
}
