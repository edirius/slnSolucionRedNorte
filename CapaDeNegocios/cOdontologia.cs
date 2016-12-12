using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios
{
    public class cOdontologia
    {

        public string idtodontologia;

        public string Idtodontologia
        {
            get { return idtodontologia; }
            set { idtodontologia = value; }
        }

        private DateTime fecha_servicio;

        public DateTime Fecha_servicio
        {
            get { return fecha_servicio; }
            set { fecha_servicio = value; }
        }

        private string observaciones;

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

        private string idthistoriaclinica;

        public string Idthistoriaclinica
        {
            get { return idthistoriaclinica; }
            set { idthistoriaclinica = value; }
        }

        public string Idtestablecimientosalud { get; set; }
        public string Idtobstetra { get; set; }

        public DataTable CrearOdontologia()
        {
            return Conexion.GDatos.TraerDataTable("spCrearOdontologia", Fecha_servicio, Idthistoriaclinica, Idtestablecimientosalud,Idtobstetra);
        }

        public DataTable ListarOdontologiaXIdHC()
        {
            return Conexion.GDatos.TraerDataTable("spListarOdontologiaXIdHC", Idthistoriaclinica);
        }

        public DataTable EliminarOdontologia()
        {
            return Conexion.GDatos.TraerDataTable("spEliminarOdontologia", Idtodontologia);
        }

        public DataTable ExisteOdontologia()
        {
            return Conexion.GDatos.TraerDataTable("spExisteOdontologia", Idtodontologia);
        }

    }
}
