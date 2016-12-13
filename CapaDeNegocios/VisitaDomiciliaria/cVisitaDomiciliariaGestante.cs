using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios.VisitaDomiciliaria
{
    public class cVisitaDomiciliariaGestante
    {
        string sidtvisitadomiciliariagestante;
        DateTime sfecha;
        string smotivo;
        string sfua;
        string sdetalle;
        string sidthistoriaclinica;
        string sidtobstetra;

        public string idtvisitadomiciliariagestante
        { get { return sidtvisitadomiciliariagestante; } set { sidtvisitadomiciliariagestante = value; } }
        public DateTime fecha
        { get { return sfecha; } set { sfecha = value; } }
        public string motivo
        { get { return smotivo; } set { smotivo = value; } }
        public string fua
        { get { return sfua; } set { sfua = value; } }
        public string detalle
        { get { return sdetalle; } set { sdetalle = value; } }
        public string idthistoriaclinica
        { get { return sidthistoriaclinica; } set { sidthistoriaclinica = value; } }
        public string idtobstetra
        { get { return sidtobstetra; } set { sidtobstetra = value; } }

        public DataTable ListarVisitaDomiciliariaGestante(string idthistoriaclinica)
        {
            return Conexion.GDatos.TraerDataTable("spListarVisitaDomiciliariaGestante", idthistoriaclinica);
        }

        public DataTable ListarVisitaDomiciliariaGestanteR(string idthistoriaclinica)
        {
            return Conexion.GDatos.TraerDataTable("spListarVisitaDomiciliariaGestanteR", idthistoriaclinica);
        }

        public Boolean CrearVisitaDomiciliariaGestante(cVisitaDomiciliariaGestante miVisitaDomiciliariaGestante)
        {
            Conexion.GDatos.Ejecutar("spCrearVisitaDomiciliariaGestante", miVisitaDomiciliariaGestante.idtvisitadomiciliariagestante, miVisitaDomiciliariaGestante.fecha, miVisitaDomiciliariaGestante.motivo, miVisitaDomiciliariaGestante.fua, miVisitaDomiciliariaGestante.detalle, miVisitaDomiciliariaGestante.idthistoriaclinica, miVisitaDomiciliariaGestante.idtobstetra);
            return true;
        }

        public Boolean ModificarVisitaDomiciliariaGestante(cVisitaDomiciliariaGestante miVisitaDomiciliariaGestante)
        {
            Conexion.GDatos.Ejecutar("spModificarVisitaDomiciliariaGestante", miVisitaDomiciliariaGestante.idtvisitadomiciliariagestante, miVisitaDomiciliariaGestante.fecha, miVisitaDomiciliariaGestante.motivo, miVisitaDomiciliariaGestante.fua, miVisitaDomiciliariaGestante.detalle, miVisitaDomiciliariaGestante.idthistoriaclinica, miVisitaDomiciliariaGestante.idtobstetra);
            return true;
        }

        public Boolean EliminarVisitaDomiciliariaGestante(string idtvisitadomiciliariagestante)
        {
            Conexion.GDatos.Ejecutar("spELiminarVisitaDomiciliariaGestante", idtvisitadomiciliariagestante);
            return true;
        }
    }
}
