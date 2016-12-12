using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios
{
    public class cEcografia
    {
        public string idtecografia;

        public string Idtecografia
        {
            get { return idtecografia; }
            set { idtecografia = value; }
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

        private string edadgestacional;

        public string Edadgestacional
        {
            get { return edadgestacional; }
            set { edadgestacional = value; }
        }

        private string diagestacional;

        public string Diagestacional
        {
            get { return diagestacional; }
            set { diagestacional = value; }
        }


        private string idthistoriaclinica;

        public string Idthistoriaclinica
        {
            get { return idthistoriaclinica; }
            set { idthistoriaclinica = value; }
        }

        public string Idtestablecimientosalud { get; set; }
        public string Idtobstetra { get; set; }
  



        public DataTable CrearEcografia()
        {
            return Conexion.GDatos.TraerDataTable("spCrearEcografia", Fecha_servicio,Edadgestacional, Diagestacional,Idthistoriaclinica, Idtestablecimientosalud, Idtobstetra);
        }

        public DataTable ListarEcografiaXIdHC()
        {
            return Conexion.GDatos.TraerDataTable("spListarEcografiaXIdHC", Idthistoriaclinica);
        }

        public DataTable EliminarEcografia()
        {
            return Conexion.GDatos.TraerDataTable("spEliminarEcografia", Idtecografia);
        }

        public DataTable ExisteEcografia()
        {
            return Conexion.GDatos.TraerDataTable("spExisteEcografia", Idtecografia);
        }

    }
}
