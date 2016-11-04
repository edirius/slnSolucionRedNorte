using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios.TerminoGestacion
{
    public class cTerminoGestacion
    {
        string sidtterminogestacion;
        string sparto;
        string sreciennacido;
        DateTime sfecha;
        string stipoparto;
        string smodoparto;
        string smanejoalumbramiento;
        string stipoinstitucion;
        string snombreinstitucion;
        string sidthistoriaclinica;

        public string idtterminogestacion
        { get { return sidtterminogestacion; } set { sidtterminogestacion = value; } }
        public string parto
        { get { return sparto; } set { sparto = value; } }
        public string reciennacido
        { get { return sreciennacido; } set { sreciennacido = value; } }
        public DateTime fecha
        { get { return sfecha; } set { sfecha = value; } }
        public string tipoparto
        { get { return stipoparto; } set { stipoparto = value; } }
        public string modoparto
        { get { return smodoparto; } set { smodoparto = value; } }
        public string manejoalumbramiento
        { get { return smanejoalumbramiento; } set { smanejoalumbramiento = value; } }
        public string tipoinstitucion
        { get { return stipoinstitucion; } set { stipoinstitucion = value; } }
        public string nombreinstitucion
        { get { return snombreinstitucion; } set { snombreinstitucion = value; } }
        public string idthistoriaclinica
        { get { return sidthistoriaclinica; } set { sidthistoriaclinica = value; } }

        public DataTable ListarTerminoGestacion(string idthistoriaclinica)
        {
            return Conexion.GDatos.TraerDataTable("spListarTerminoGestacion", idthistoriaclinica);
        }

        public Boolean CrearTerminoGestacion(cTerminoGestacion miTerminoGestacion)
        {
            Conexion.GDatos.Ejecutar("spCrearTerminoGestacion", miTerminoGestacion.idtterminogestacion, miTerminoGestacion.parto, miTerminoGestacion.reciennacido, miTerminoGestacion.fecha, miTerminoGestacion.tipoparto, miTerminoGestacion.modoparto, miTerminoGestacion.manejoalumbramiento, miTerminoGestacion.tipoinstitucion, miTerminoGestacion.nombreinstitucion, miTerminoGestacion.idthistoriaclinica);
            return true;
        }

        public Boolean ModificarTerminoGestacion(cTerminoGestacion miTerminoGestacion)
        {
            Conexion.GDatos.Ejecutar("spModificarTerminoGestacion", miTerminoGestacion.idtterminogestacion, miTerminoGestacion.parto, miTerminoGestacion.reciennacido, miTerminoGestacion.fecha, miTerminoGestacion.tipoparto, miTerminoGestacion.modoparto, miTerminoGestacion.manejoalumbramiento, miTerminoGestacion.tipoinstitucion, miTerminoGestacion.nombreinstitucion, miTerminoGestacion.idthistoriaclinica);
            return true;
        }

        public Boolean EliminarTerminoGestacion(string idtterminogestacion)
        {
            Conexion.GDatos.Ejecutar("spELiminarTerminoGestacion", idtterminogestacion);
            return true;
        }
    }
}
