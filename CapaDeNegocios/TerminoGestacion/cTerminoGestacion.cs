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
        string sgestacion;
        string slugar;
        string sreciennacido;
        DateTime sfecha;
        string spersona;
        string stipoparto;
        string smodoparto;
        string smanejoalumbramiento;
        string stipoinstitucion;
        string snombreinstitucion;
        string sidthistoriaclinica;
        string sidtobstetra;

        public string idtterminogestacion
        { get { return sidtterminogestacion; } set { sidtterminogestacion = value; } }
        public string gestacion
        { get { return sgestacion; } set { sgestacion = value; } }
        public string lugar
        { get { return slugar; } set { slugar = value; } }
        public string reciennacido
        { get { return sreciennacido; } set { sreciennacido = value; } }
        public DateTime fecha
        { get { return sfecha; } set { sfecha = value; } }
        public string persona
        { get { return spersona; } set { spersona = value; } }
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
        public string idtobstetra
        { get { return sidtobstetra; } set { sidtobstetra = value; } }

        public DataTable ListarTerminoGestacion(string idthistoriaclinica)
        {
            return Conexion.GDatos.TraerDataTable("spListarTerminoGestacion", idthistoriaclinica);
        }

        public Boolean CrearTerminoGestacion(cTerminoGestacion miTerminoGestacion)
        {
            Conexion.GDatos.Ejecutar("spCrearTerminoGestacion", miTerminoGestacion.idtterminogestacion, miTerminoGestacion.gestacion, miTerminoGestacion.lugar, miTerminoGestacion.reciennacido, miTerminoGestacion.fecha, miTerminoGestacion.persona, miTerminoGestacion.tipoparto, miTerminoGestacion.modoparto, miTerminoGestacion.manejoalumbramiento, miTerminoGestacion.tipoinstitucion, miTerminoGestacion.nombreinstitucion, miTerminoGestacion.idthistoriaclinica, miTerminoGestacion.idtobstetra);
            return true;
        }

        public Boolean ModificarTerminoGestacion(cTerminoGestacion miTerminoGestacion)
        {
            Conexion.GDatos.Ejecutar("spModificarTerminoGestacion", miTerminoGestacion.idtterminogestacion, miTerminoGestacion.gestacion, miTerminoGestacion.lugar, miTerminoGestacion.reciennacido, miTerminoGestacion.fecha, miTerminoGestacion.persona, miTerminoGestacion.tipoparto, miTerminoGestacion.modoparto, miTerminoGestacion.manejoalumbramiento, miTerminoGestacion.tipoinstitucion, miTerminoGestacion.nombreinstitucion, miTerminoGestacion.idthistoriaclinica, miTerminoGestacion.idtobstetra);
            return true;
        }

        public Boolean EliminarTerminoGestacion(string idtterminogestacion)
        {
            Conexion.GDatos.Ejecutar("spELiminarTerminoGestacion", idtterminogestacion);
            return true;
        }
    }
}
