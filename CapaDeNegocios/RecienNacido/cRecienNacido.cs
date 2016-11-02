using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Data;
namespace CapaDeNegocios.RecienNacido
{
    public class cRecienNacido
    {
        public string IdRecienNacido { get; set; }

        public string IdHistoriaClinica { get; set; }

        public DateTime FechaDerivado { get; set; }

        public string Apgar1 { get; set; }

        public string Apgar5 { get; set; }

        public string Peso { get; set; }

        public string Sexo { get; set; }

        public DataTable AgregarRecienNacido()
        {
            return Conexion.GDatos.TraerDataTable("spCrearRecienNacido", IdRecienNacido, IdHistoriaClinica, FechaDerivado, Apgar1, Apgar5, Peso, Sexo);
        }
        public DataTable ModificarRecienNacido()
        {
            return Conexion.GDatos.TraerDataTable("spModificarRecienNacido", IdRecienNacido, IdHistoriaClinica, FechaDerivado, Apgar1, Apgar5, Peso, Sexo);
        }
        public DataTable EliminarRecienNacido()
        {
            return Conexion.GDatos.TraerDataTable("spEliminarRecienNacido", IdRecienNacido);
        }
        public DataTable ListarRecienNacido()
        {
            return Conexion.GDatos.TraerDataTable("spListarRecienNacido");
        }


    }
}
