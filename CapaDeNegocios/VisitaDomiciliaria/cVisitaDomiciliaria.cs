using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios.VisitaDomiciliaria
{
    public class cVisitaDomiciliaria
    {
        string sidtvisitadomiciliaria;
        DateTime sfecha;
        string smotivo;
        string sdetalle;
        string stipo;
        string sidthistoriaclinica;

        public string idtvisitadomiciliaria
        { get { return sidtvisitadomiciliaria; } set { sidtvisitadomiciliaria = value; } }
        public DateTime fecha
        { get { return sfecha; } set { sfecha = value; } }
        public string motivo
        { get { return smotivo; } set { smotivo = value; } }
        public string detalle
        { get { return sdetalle; } set { sdetalle = value; } }
        public string tipo
        { get { return stipo; } set { stipo = value; } }
        public string idthistoriaclinica
        { get { return sidthistoriaclinica; } set { sidthistoriaclinica = value; } }

        public DataTable ListarVisitaDomiciliaria(string idthistoriaclinica)
        {
            return Conexion.GDatos.TraerDataTable("spListarVisitaDomiciliaria", idthistoriaclinica);
        }

        public Boolean CrearVisitaDomiciliaria(cVisitaDomiciliaria miVisitaDomiciliaria)
        {
            Conexion.GDatos.Ejecutar("spCrearVisitaDomiciliaria", miVisitaDomiciliaria.idtvisitadomiciliaria, miVisitaDomiciliaria.fecha, miVisitaDomiciliaria.motivo, miVisitaDomiciliaria.detalle, miVisitaDomiciliaria.tipo, miVisitaDomiciliaria.idthistoriaclinica);
            return true;
        }

        public Boolean ModificarVisitaDomiciliaria(cVisitaDomiciliaria miVisitaDomiciliaria)
        {
            Conexion.GDatos.Ejecutar("spModificarVisitaDomiciliaria", miVisitaDomiciliaria.idtvisitadomiciliaria, miVisitaDomiciliaria.fecha, miVisitaDomiciliaria.motivo, miVisitaDomiciliaria.detalle, miVisitaDomiciliaria.tipo, miVisitaDomiciliaria.idthistoriaclinica);
            return true;
        }

        public Boolean EliminarVisitaDomiciliaria(string idtvisitadomiciliaria)
        {
            Conexion.GDatos.Ejecutar("spELiminarVisitaDomiciliaria", idtvisitadomiciliaria);
            return true;
        }
    }
}
