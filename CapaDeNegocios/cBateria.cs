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

        public DataTable AgregarBateria()
        {
            return Conexion.GDatos.TraerDataTable("spCrearBateria", IdBateria, IdHistoriaClinica, Fecha, Hemoglobina, Vih, Sifilis, Glucosa, Orina, FechaExamenOrina);
        }
        public DataTable ModificarBateria()
        {
            return Conexion.GDatos.TraerDataTable("spModificarBateria", IdBateria, IdHistoriaClinica, Fecha, Hemoglobina, Vih, Sifilis, Glucosa, Orina, FechaExamenOrina);
        }
        public DataTable EliminarBateria()
        {
            return Conexion.GDatos.TraerDataTable("spEliminarBateria", IdBateria);
        }
        public DataTable ListarBateria()
        {
            return Conexion.GDatos.TraerDataTable("spListarBateria");
        }

    }
}
