using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios.Cronograma
{
    public class cCronograma
    {
        public cHistoriaClinica miCicloGestacion = new cHistoriaClinica();

        public DateTime FechaFur { get; set;}
        public DateTime FechaPP { get; set; }

        public DateTime FechaInicio { get; set; }

        public List<cFechasPrenatales> misFechasPrenatales;

        public List<cFechaOdontologia> misFechasProbalesOdontologias;

        public List<cFechaEcografia> misFechasProbablesEcogafrias;
        public List<cFechasBateria> misFechasProbablesBateria;
        public List<cFechaControlPuerperio> misFechasProbablesControlPuerperio;
        
        
        public cCronograma (cHistoriaClinica cicloGestacion)
        {
            miCicloGestacion = cicloGestacion;
            misFechasPrenatales = new List<cFechasPrenatales>();
            misFechasProbalesOdontologias = new List<cFechaOdontologia>();
            misFechasProbablesEcogafrias = new List<cFechaEcografia>();
            misFechasProbablesBateria = new List<cFechasBateria>();
            misFechasProbablesControlPuerperio = new List<cFechaControlPuerperio>();
            FechaFur = miCicloGestacion.Fur;
            FechaPP = miCicloGestacion.Fpp;
            FechaInicio = miCicloGestacion.Fecha;
              

            CalcularFechasCitasPrenatales();
            CalcularAtencionesOdontologicas();
            CalcularFechasEcografias();
            CalcularFechasBaterias();
            CalcularFechasControlPuerperio(); 
        }

        private void CalcularFechasCitasPrenatales()
        {
            

            int SemanaActualGestacion = HallarSemana(FechaInicio - FechaFur);

            do
            {
                cFechasPrenatales miFechaPrenatal = new cFechasPrenatales();
                miFechaPrenatal.nombre = "Nro. Cita " + misFechasPrenatales.Count + 1;
                if (misFechasPrenatales.Count == 0)
                {
                    miFechaPrenatal.fechaCita = FechaInicio.AddDays(30);
                    miFechaPrenatal.semanaGestacional = HallarSemana(FechaInicio - FechaFur);
                }
                else
                {
                    miFechaPrenatal.semanaGestacional = HallarSemana(FechaFur - misFechasPrenatales[misFechasPrenatales.Count -1].fechaCita );
                    if (miFechaPrenatal.semanaGestacional   <= 24)
                    {
                        miFechaPrenatal.fechaCita = misFechasPrenatales[misFechasPrenatales.Count - 1].fechaCita.AddDays(30);
                    }
                    else if (miFechaPrenatal.semanaGestacional <= 34)
                    {
                        miFechaPrenatal.fechaCita = misFechasPrenatales[misFechasPrenatales.Count - 1].fechaCita.AddDays(15);
                    }
                    else if (miFechaPrenatal.semanaGestacional <= 42)
                    {
                        miFechaPrenatal.fechaCita = misFechasPrenatales[misFechasPrenatales.Count - 1].fechaCita.AddDays(7);
                    }
                }
                miFechaPrenatal.semanaGestacional = HallarSemana(FechaFur - miFechaPrenatal.fechaCita);
                misFechasPrenatales.Add(miFechaPrenatal);
            } while ((misFechasPrenatales[misFechasPrenatales.Count -1].semanaGestacional <42) && (misFechasPrenatales[misFechasPrenatales.Count - 1].fechaCita.AddDays(7).Date  <= FechaPP.Date    ));

          

            
        }

        private void CalcularAtencionesOdontologicas()
        {
            cFechaOdontologia miPrimeraFechaProbableAtencion = new cFechaOdontologia();
            miPrimeraFechaProbableAtencion.Nombre = "Primera Atencion Odontologica";
            miPrimeraFechaProbableAtencion.FechaAtencionProbable = FechaFur.AddDays(30);

            cFechaOdontologia miSegundaFechaProbableAtencion = new cFechaOdontologia();
            miSegundaFechaProbableAtencion.Nombre = "Segunda Atencion Odontologica";
            miSegundaFechaProbableAtencion.FechaAtencionProbable = FechaFur.AddDays(180);

            misFechasProbalesOdontologias.Add(miPrimeraFechaProbableAtencion);
            misFechasProbalesOdontologias.Add(miSegundaFechaProbableAtencion);
        }
        

        private void CalcularFechasBaterias()
        {
            cFechasBateria miPrimeraBateria = new cFechasBateria();
            miPrimeraBateria.Nombre = "Fecha Maxima Primera Bateria";
            miPrimeraBateria.FechaMaxima = misFechasPrenatales[1].fechaCita;

            cFechasBateria miSegundaBateria = new cFechasBateria();
            miSegundaBateria.Nombre = "Fecha Maxima Segunda Bateria";
            miSegundaBateria.FechaMaxima = misFechasPrenatales[3].fechaCita;

            misFechasProbablesBateria.Add(miPrimeraBateria);
            misFechasProbablesBateria.Add(miSegundaBateria);      
        }

        private int HallarSemana(TimeSpan dias)
        {
            double NrOfDays = dias.TotalDays;
            int semanas = (int)Math.Ceiling(Math.Abs(NrOfDays / 7));
            return semanas;
        }

        private void CalcularFechasControlPuerperio()
        {
            cFechaControlPuerperio miPrimerControlPuerperio = new cFechaControlPuerperio();
            miPrimerControlPuerperio.Nombre = "Mi Primer Control Puerperio";
            miPrimerControlPuerperio.FechaControlPuerperio = FechaPP.AddDays(7);

            cFechaControlPuerperio miSegundoPuerperio = new cFechaControlPuerperio();
            miSegundoPuerperio.Nombre = "Mi Segundo COntrol Puerperio";
            miSegundoPuerperio.FechaControlPuerperio = FechaPP.AddDays(30);     
        }

        private void CalcularFechasEcografias()
        {
            cFechaEcografia miPrimeraEcografia = new cFechaEcografia();
            miPrimeraEcografia.Nombre = "Primera Fecha Ecogafria";
            miPrimeraEcografia.FechaProbableAtencion = FechaFur.AddDays(30);

            cFechaEcografia miSegundaEcogafria = new cFechaEcografia();
            miSegundaEcogafria.Nombre = "Segunda Fecha Ecografia";
            miSegundaEcogafria.FechaProbableAtencion = FechaFur.AddDays(60);

            misFechasProbablesEcogafrias.Add(miPrimeraEcografia);
            misFechasProbablesEcogafrias.Add(miSegundaEcogafria);  
        }


    }
}
