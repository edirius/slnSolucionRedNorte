using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios
{
    public class cBateria
    {
        public string IdBateria { get; set; }

        public string IdHistoriaClinica { get; set; }

        public DateTime Fecha { get; set; }

        public string Hemoglobina { get; set; }

        public string Vih { get; set; }

        public string Sifilis { get; set; }

        public string Glucosa { get; set; }

        public string Orina { get; set; }

        public string FechaExamenOrina { get; set; }

        public string FechaTratamiento { get; set; }

        public DataTable AgregarBateria()
        {
            return Conexion.GDatos.TraerDataTable("spCrearBateria", IdBateria, IdHistoriaClinica, Fecha, Hemoglobina, Vih, Sifilis, Glucosa, Orina, FechaExamenOrina, FechaTratamiento);
        }
        public DataTable ModificarBateria()
        {
            return Conexion.GDatos.TraerDataTable("spModificarBateria", IdBateria, IdHistoriaClinica, Fecha, Hemoglobina, Vih, Sifilis, Glucosa, Orina, FechaExamenOrina, FechaTratamiento);
        }
        public DataTable EliminarBateria()
        {
            return Conexion.GDatos.TraerDataTable("spEliminarBateria", IdBateria);
        }
        public DataTable ListarBateria(string id)
        {
            return Conexion.GDatos.TraerDataTable("spListarBateria2", id);
        }

        public DataTable ReporteBateria(string id)
        {
            return Conexion.GDatos.TraerDataTable("spListarBateria", id);
        }

        public DataTable ListadeAlertasenBateria(string tipo, string id, string id2, string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spAlertasBateria", tipo, id, id2, mes, año);
        }
        public DataTable AlertaGestanteAnemia(string id, string id2, string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spAlertaGestanteAnemia", id, id2, mes, año);
        }
        public DataTable AlertaGestanteVIH(string id, string id2, string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spAlertaGestanteVIH", id, id2, mes, año);
        }
        public DataTable AlertaGestanteSifilis(string id, string id2, string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spAlertaGestanteSifilis", id, id2, mes, año);
        }
        public DataTable AlertaGestanteOrina(string id, string id2, string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spAlertaGestanteOrina", id, id2, mes, año);
        }
        public DataTable AlertaGestanteSinFechaTratamiento(string id, string id2, string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spAlertaGestanteSinFechaTratamiento", id, id2, mes, año);
        }
        public DataTable AlertaGestanteSinExamenOrina(string id, string id2, string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spAlertaGestanteSinExamenOrina", id, id2, mes, año);
        }
        public DataTable AlertaGestanteSinBateria(string id, string id2, string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spAlertaGestanteBateria", id, id2, mes, año);
        }


    }
}
