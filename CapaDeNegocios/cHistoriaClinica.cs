using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios
{
    public class cHistoriaClinica
    {
        public string Idthistoriaclinica { get; set; }
        public string Idtestablecimientosalud { get; set; }
        
        public string Tipollegada { get; set; }
        public string Tiempollegada { get; set; }
        public int Edad { get; set; }
        public int Gestas { get; set; }
        public int Partos { get; set; }
        public int Abortos { get; set; }
        public int Hijosvivos { get; set; }
        public int Hijosmuertos { get; set; }
        public DateTime Fur { get; set; }
        public DateTime Fpp { get; set; }
        public int Trimestreapn { get; set; }
        public string Semanaapn { get; set; }
        public string Observaciones { get; set; }
        public string Idtpaciente { get; set; }
        public string Idtobstetra { get; set; }
        public DateTime Fecha { get; set; }
        public int año { get; set; }
        public int mes { get; set; }
        public int Transeunte { get; set; }
        public string OrigenEESS { get; set; }
        public int Archivado { get; set; }
        public DateTime fecha_inicio{ get; set; }
        public DateTime fecha_fin { get; set; }

        public CapaDeNegocios.Paciente.cPaciente oPaciente;

        public cHistoriaClinica()
        {
            oPaciente = new CapaDeNegocios.Paciente.cPaciente();
        }

        public DataTable CrearHistoriaClinica()
        {
            return Conexion.GDatos.TraerDataTable("spCrearHistoriaClinica", Idtestablecimientosalud,  Tipollegada, Tiempollegada, Edad, Gestas, Partos, Abortos, Hijosvivos, Hijosmuertos, Fur, Fpp, Trimestreapn, Semanaapn, Observaciones, Idtpaciente, Idtobstetra, Fecha, Transeunte, OrigenEESS,Archivado);
        }

        public DataTable ModificarHistoriaClinica()
        {
            return Conexion.GDatos.TraerDataTable("spModificarHistoriaClinica", Idthistoriaclinica,  Tipollegada, Tiempollegada, Edad, Gestas, Partos, Abortos, Hijosvivos, Hijosmuertos, Fur, Fpp, Trimestreapn, Semanaapn, Observaciones, Idtpaciente, Idtobstetra, Fecha,Transeunte,OrigenEESS,Archivado);
        }

        public DataTable ListarHistoriaClinica()
        {
            return Conexion.GDatos.TraerDataTable("spListarHistoriaClinica", Idtobstetra, año, mes);
        }

        public DataTable ListarHistoriaClinicaLargo()
        {
            return Conexion.GDatos.TraerDataTable("spListarHistoriaClinicaLargo", Idthistoriaclinica, año, mes);
        }

        public DataTable ListarHistoriaClinicaXHistoriaClinica()
        {
            return Conexion.GDatos.TraerDataTable("spListarHistoriaClinicaXHistoriaClinica", oPaciente.codigohistoriaclinica,Idtobstetra);
        }

        public DataTable ReporteHistoriaClinicaXObstetraXFechasYTranseuntesYArchivado()
        {
            return Conexion.GDatos.TraerDataTable("spReporteHistoriaClinicaXObstetraXFechasYTranseuntesYArchivado", Idtobstetra, fecha_inicio, fecha_fin, Transeunte, Archivado );
        }
 

        public DataTable ReporteHistoriaClinicaParte1()
        {
            return Conexion.GDatos.TraerDataTable("spReporteHistoriaClinicaParte1", Idthistoriaclinica);
        }

        public DataTable ReporteHistoriaClinicaParte2()
        {
            return Conexion.GDatos.TraerDataTable("spReporteHistoriaClinicaParte2", Idthistoriaclinica);
        }

        public DataTable ReporteHistoriaClinicaParte3()
        {
            return Conexion.GDatos.TraerDataTable("spReporteHistoriaClinicaParte3", Idthistoriaclinica);
        }

        public DataTable ListarYear()
        {
            return Conexion.GDatos.TraerDataTable("spListarYear");
        }


    }
}

