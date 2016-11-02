using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios
{
    public class cTranseunte
    {

        public string Idttranseunte { get; set; }
        public string Codigocitaprenatal { get; set; }
        public DateTime Fechacitaprenatal { get; set; }
        public int Edadgestacional { get; set; }
        public string Origenestablecimientosalud { get; set; }
        public int PresionArterialS { get; set; }
        public int PresionArterialD { get; set; }
        public int NumeroCita { get; set; }
        public string HistoriaClinica { get; set; }
        public DateTime  FechaProximaCitaPrenatal { get; set; }

        public DataTable CrearTranseunte()
        {
            return Conexion.GDatos.TraerDataTable("spCrearTranseunte", Codigocitaprenatal, Fechacitaprenatal, Edadgestacional, Origenestablecimientosalud, PresionArterialS, PresionArterialD, NumeroCita, HistoriaClinica, FechaProximaCitaPrenatal);
        }

        public DataTable ModificarTranseunte()
        {
            return Conexion.GDatos.TraerDataTable("spModificarTranseunte", Idttranseunte, Codigocitaprenatal, Fechacitaprenatal, Edadgestacional, Origenestablecimientosalud, PresionArterialS, PresionArterialD, NumeroCita, HistoriaClinica, FechaProximaCitaPrenatal);
        }

        public DataTable EliminarTranseunte()
        {
            return Conexion.GDatos.TraerDataTable("spEliminarTranseunte", Idttranseunte );
        }

    }
}
