using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDeDatos;
using CapaDeNegocios;

namespace CapaDeNegocios
{
    public class cHistoriaClinica
    {
        
        private string idthistoriaclinica;

        public string Idthistoriaclinica
        {
            get { return idthistoriaclinica; }
            set { idthistoriaclinica = value; }
        }

        private string codigohistoriaclinica;

        public string Codigohistoriaclinica
        {
            get { return codigohistoriaclinica; }
            set { codigohistoriaclinica = value; }
        }

        private string tipollegada;

        public string Tipollegada
        {
            get { return tipollegada; }
            set { tipollegada = value; }
        }

        private string tiempollegada;

        public string Tiempollegada
        {
            get { return tiempollegada; }
            set { tiempollegada = value; }
        }

        private Int32 edad;

        public Int32 Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        private int gestas;

        public int Gestas
        {
            get { return gestas; }
            set { gestas = value; }
        }

        private int partos;

        public int Partos
        {
            get { return partos; }
            set { partos = value; }
        }

        private int abortos;

        public int Abortos
        {
            get { return abortos; }
            set { abortos = value; }
        }

        private int hijosvivos;

        public int Hijosvivos
        {
            get { return hijosvivos; }
            set { hijosvivos = value; }
        }

        private int hijosmuertos;

        public int Hijosmuertos
        {
            get { return hijosmuertos; }
            set { hijosmuertos = value; }
        }

        private DateTime fur;

        public DateTime Fur
        {
            get { return fur; }
            set { fur = value; }
        }

        private DateTime fpp;

        public DateTime Fpp
        {
            get { return fpp; }
            set { fpp = value; }
        }

        private string trimestreapn;

        public string Trimestreapn
        {
            get { return trimestreapn; }
            set { trimestreapn = value; }
        }

        private string diaapn;

        public string Diaapn
        {
            get { return diaapn; }
            set { diaapn= value; }
        }

        private string observaciones;

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

        private string idtpaciente;

        public string Idtpaciente
        {
            get { return idtpaciente; }
            set { idtpaciente = value; }
        }

        private string idtobstetra;

        public string Idtobstetra
        {
            get { return idtobstetra; }
            set { idtobstetra = value; }
        }
        

        public DataTable ListarPacienteXDNI( )
        {
            return Conexion.GDatos.TraerDataTable("spListarPacienteXDNI" );
        }

        
        public DataTable CrearHistoriaClinica()
        {
            return Conexion.GDatos.TraerDataTable("spCrearHistoriaClinica", Codigohistoriaclinica, Tipollegada, Tiempollegada, Edad, Gestas, Partos, Abortos, Hijosvivos, Hijosmuertos, Fur, Fpp, Trimestreapn, Diaapn, Observaciones, Idtpaciente, Idtobstetra);
        }
        

        /*

        public DataTable CrearHistoriaClinica(cHistoriaClinica miHistoriaClinica)
        {
            return Conexion.GDatos.TraerDataTable("spCrearHistoriaClinica", miHistoriaClinica.Codigohistoriaclinica, miHistoriaClinica.Tipollegada, miHistoriaClinica.Tiempollegada, miHistoriaClinica.Edad, miHistoriaClinica.Gestas, miHistoriaClinica.Partos, miHistoriaClinica.Abortos, miHistoriaClinica.Hijosvivos, miHistoriaClinica.Hijosmuertos, miHistoriaClinica.Fur, miHistoriaClinica.Fpp, miHistoriaClinica.Trimestreapn, miHistoriaClinica.Diaapn, miHistoriaClinica.Observaciones, miHistoriaClinica.Idtpaciente, miHistoriaClinica.Idtobstetra);
        }

        public DataTable CrearHistoriaClinica(string Codigohistoriaclinica_ , string Tipollegada_, string Tiempollegada_, int Edad_, int Gestas_, int Partos_, int Abortos_, int Hijosvivos_, int Hijosmuertos_, string Fur_, string Fpp_, string Trimestreapn_, string Diaapn_, string observaciones_, string Idtpaciente_, string Idobstetra_)
        {
            return Conexion.GDatos.TraerDataTable("spCrearHistoriaClinica", Codigohistoriaclinica, Tipollegada, Tiempollegada, Edad, Gestas, Partos, Abortos, Hijosvivos, Hijosmuertos, Fur, Fpp, Trimestreapn, Diaapn, Observaciones, Idtpaciente, Idtobstetra);
        }
        */


    }
}
