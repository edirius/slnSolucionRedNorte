using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios.ControlPeuperio
{
    public class cControlPeuperio
    {
        string sidtcontrolpeuperio;
        int snumero;
        DateTime sfecha;
        int spresionarterials;
        int spresionarteriald;
        int salturauterino;
        string sfua;
        string sdetalle;
        string sidthistoriaclinica;

        public string idtcontrolpeuperio
        { get { return sidtcontrolpeuperio; } set { sidtcontrolpeuperio = value; } }
        public int numero
        { get { return snumero; } set { snumero = value; } }
        public DateTime fecha
        { get { return sfecha; } set { sfecha = value; } }
        public int presionarterials
        { get { return spresionarterials; } set { spresionarterials = value; } }
        public int presionarteriald
        { get { return spresionarteriald; } set { spresionarteriald = value; } }
        public int alturauterino
        { get { return salturauterino; } set { salturauterino = value; } }
        public string fua
        { get { return sfua; } set { sfua = value; } }
        public string detalle
        { get { return sdetalle; } set { sdetalle = value; } }
        public string idthistoriaclinica
        { get { return sidthistoriaclinica; } set { sidthistoriaclinica = value; } }

        public DataTable ListarControlPeuperio(string idthistoriaclinica)
        {
            return Conexion.GDatos.TraerDataTable("spListarControlPeuperio", idthistoriaclinica);
        }

        public Boolean CrearControlPeuperio(cControlPeuperio miControlPeuperio)
        {
            Conexion.GDatos.Ejecutar("spCrearControlPeuperio", miControlPeuperio.idtcontrolpeuperio, miControlPeuperio.numero, miControlPeuperio.fecha, miControlPeuperio.presionarterials, miControlPeuperio.presionarteriald, miControlPeuperio.alturauterino, miControlPeuperio.fua, miControlPeuperio.detalle, miControlPeuperio.idthistoriaclinica);
            return true;
        }

        public Boolean ModificarControlPeuperio(cControlPeuperio miControlPeuperio)
        {
            Conexion.GDatos.Ejecutar("spModificarControlPeuperio", miControlPeuperio.idtcontrolpeuperio, miControlPeuperio.numero, miControlPeuperio.fecha, miControlPeuperio.presionarterials, miControlPeuperio.presionarteriald, miControlPeuperio.alturauterino, miControlPeuperio.fua, miControlPeuperio.detalle, miControlPeuperio.idthistoriaclinica);
            return true;
        }

        public Boolean EliminarControlPeuperio(string idtcontrolpeuperio)
        {
            Conexion.GDatos.Ejecutar("spELiminarControlPeuperio", idtcontrolpeuperio);
            return true;
        }
    }
}
