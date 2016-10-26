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

        private TimeZone tipollegada;

        public TimeZone Tipollegada
        {
            get { return tipollegada; }
            set { tipollegada = value; }
        }

        private Int32 edad;

        public Int32 Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        private string gestas;

        public string Gestas
        {
            get { return gestas; }
            set { gestas = value; }
        }

        private string partos;

        public string Partos
        {
            get { return partos; }
            set { partos = value; }
        }

        private string abortos;

        public string Abortos
        {
            get { return abortos; }
            set { abortos = value; }
        }

        private string hijosvivos;

        public string Hijosvivos
        {
            get { return hijosvivos; }
            set { hijosvivos = value; }
        }

        private string hijosmuertos;

        public string Hijosmuertos
        {
            get { return hijosmuertos; }
            set { hijosmuertos = value; }
        }

        private string fur;

        public string Fur
        {
            get { return fur; }
            set { fur = value; }
        }

        private string fpp;

        public string Fpp
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

 
        public DataTable ListarPacienteXDNI( )
        {
            return Conexion.GDatos.TraerDataTable("spListarPacienteXDNI" );
        }

    }
}
