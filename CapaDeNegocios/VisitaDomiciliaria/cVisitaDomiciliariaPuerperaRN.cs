using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios.VisitaDomiciliaria
{
    public class cVisitaDomiciliariaPuerperaRN
    {
        string sidtvisitadomiciliariapuerperarn;
        DateTime sfecha;
        string smotivopuerpera;
        string sfuapuerpera;
        string sdetallepuerpera;
        string smotivoreciennacido;
        string sfuareciennacido;
        string sdetallereciennacido;
        string sidthistoriaclinica;
        string sidtobstetra;

        public string idtvisitadomiciliariapuerperarn
        { get { return sidtvisitadomiciliariapuerperarn; } set { sidtvisitadomiciliariapuerperarn = value; } }
        public DateTime fecha
        { get { return sfecha; } set { sfecha = value; } }
        public string motivopuerpera
        { get { return smotivopuerpera; } set { smotivopuerpera = value; } }
        public string fuapuerpera
        { get { return sfuapuerpera; } set { sfuapuerpera = value; } }
        public string detallepuerpera
        { get { return sdetallepuerpera; } set { sdetallepuerpera = value; } }
        public string motivoreciennacido
        { get { return smotivoreciennacido; } set { smotivoreciennacido = value; } }
        public string fuareciennacido
        { get { return sfuareciennacido; } set { sfuareciennacido = value; } }
        public string detallereciennacido
        { get { return sdetallereciennacido; } set { sdetallereciennacido = value; } }
        public string idthistoriaclinica
        { get { return sidthistoriaclinica; } set { sidthistoriaclinica = value; } }
        public string idtobstetra
        { get { return sidtobstetra; } set { sidtobstetra = value; } }

        public DataTable ListarVisitaDomiciliariaPuerperaRN(string idthistoriaclinica)
        {
            return Conexion.GDatos.TraerDataTable("spListarVisitaDomiciliariaPuerperaRN", idthistoriaclinica);
        }

        public Boolean CrearVisitaDomiciliariaPuerperaRN(cVisitaDomiciliariaPuerperaRN miVisitaDomiciliariaPuerperaRN)
        {
            Conexion.GDatos.Ejecutar("spCrearVisitaDomiciliariaPuerperaRN", miVisitaDomiciliariaPuerperaRN.idtvisitadomiciliariapuerperarn, miVisitaDomiciliariaPuerperaRN.fecha, miVisitaDomiciliariaPuerperaRN.motivopuerpera, miVisitaDomiciliariaPuerperaRN.fuapuerpera, miVisitaDomiciliariaPuerperaRN.detallepuerpera, miVisitaDomiciliariaPuerperaRN.motivoreciennacido, miVisitaDomiciliariaPuerperaRN.fuareciennacido, miVisitaDomiciliariaPuerperaRN.detallereciennacido, miVisitaDomiciliariaPuerperaRN.idthistoriaclinica, miVisitaDomiciliariaPuerperaRN.idtobstetra);
            return true;
        }

        public Boolean ModificarVisitaDomiciliariaPuerperaRN(cVisitaDomiciliariaPuerperaRN miVisitaDomiciliariaPuerperaRN)
        {
            Conexion.GDatos.Ejecutar("spModificarVisitaDomiciliariaPuerperaRN", miVisitaDomiciliariaPuerperaRN.idtvisitadomiciliariapuerperarn, miVisitaDomiciliariaPuerperaRN.fecha, miVisitaDomiciliariaPuerperaRN.motivopuerpera, miVisitaDomiciliariaPuerperaRN.fuapuerpera, miVisitaDomiciliariaPuerperaRN.detallepuerpera, miVisitaDomiciliariaPuerperaRN.motivoreciennacido, miVisitaDomiciliariaPuerperaRN.fuareciennacido, miVisitaDomiciliariaPuerperaRN.detallereciennacido, miVisitaDomiciliariaPuerperaRN.idthistoriaclinica, miVisitaDomiciliariaPuerperaRN.idtobstetra);
            return true;
        }

        public Boolean EliminarVisitaDomiciliariaPuerperaRN(string idtvisitadomiciliariaPuerperaRN)
        {
            Conexion.GDatos.Ejecutar("spELiminarVisitaDomiciliariaPuerperaRN", idtvisitadomiciliariaPuerperaRN);
            return true;
        }
    }
}
