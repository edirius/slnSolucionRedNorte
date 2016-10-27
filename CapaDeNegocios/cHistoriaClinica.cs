﻿using System;
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
        public string Codigohistoriaclinica { get; set; }
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
        public string Diaapn { get; set; }
        public string Observaciones { get; set; }
        public string Idtpaciente { get; set; }
        public string Idtobstetra { get; set; }
         
        public DataTable CrearHistoriaClinica()
        {
            return Conexion.GDatos.TraerDataTable("spCrearHistoriaClinica", Idtestablecimientosalud ,Codigohistoriaclinica, Tipollegada, Tiempollegada, Edad, Gestas, Partos, Abortos, Hijosvivos, Hijosmuertos, Fur, Fpp, Trimestreapn, Diaapn, Observaciones, Idtpaciente, Idtobstetra);
        }
     }
}

