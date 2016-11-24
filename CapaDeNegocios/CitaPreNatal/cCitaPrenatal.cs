using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Data;

namespace CapaDeNegocios.CitaPreNatal
{
    public class cCitaPrenatal
    {
        
        string codigoCitaPrenatal;
        int numeroCita;
        DateTime fechaCitaPrenatal;
        int edadGestacional;
        string fua;
        int presionArterialS;
        int presionArterialD;
        DateTime fechaProximaCitaPrenatal;
        cHistoriaClinica historiaClinica;

        public int SulfatoFerroso{ get; set; }

        public cCitaPrenatal ()
        {
            historiaClinica = new cHistoriaClinica();
        }
        public string CodigoCitaPrenatal
        {
            get
            {
                return codigoCitaPrenatal;
            }

            set
            {
                codigoCitaPrenatal = value;
            }
        }

        public DateTime FechaCitaPrenatal
        {
            get
            {
                return fechaCitaPrenatal;
            }

            set
            {
                fechaCitaPrenatal = value;
            }
        }

        public int EdadGestacional
        {
            get
            {
                return edadGestacional;
            }

            set
            {
                edadGestacional = value;
            }
        }

        public string Fua
        {
            get
            {
                return fua;
            }

            set
            {
                fua = value;
            }
        }

        public int PresionArterialS
        {
            get
            {
                return presionArterialS;
            }

            set
            {
                presionArterialS = value;
            }
        }

        public int PresionArterialD
        {
            get
            {
                return presionArterialD;
            }

            set
            {
                presionArterialD = value;
            }
        }



        public int NumeroCita
        {
            get
            {
                return numeroCita;
            }

            set
            {
                numeroCita = value;
            }
        }

        public cHistoriaClinica HistoriaClinica
        {
            get
            {
                return historiaClinica;
            }

            set
            {
                historiaClinica = value;
            }
        }

        public DateTime FechaProximaCitaPrenatal
        {
            get
            {
                return fechaProximaCitaPrenatal;
            }

            set
            {
                fechaProximaCitaPrenatal = value;
            }
        }

        public int AgregarCita(cCitaPrenatal nuevaCitaPrenatal)
        {
            try
            {
                return Conexion.GDatos.Ejecutar("spCrearCitaPreNatal", nuevaCitaPrenatal.codigoCitaPrenatal, HistoriaClinica.Idthistoriaclinica  ,nuevaCitaPrenatal.numeroCita , nuevaCitaPrenatal.fechaCitaPrenatal, nuevaCitaPrenatal.edadGestacional, nuevaCitaPrenatal.fua, nuevaCitaPrenatal.presionArterialS, nuevaCitaPrenatal.PresionArterialD,  nuevaCitaPrenatal.FechaProximaCitaPrenatal, nuevaCitaPrenatal.SulfatoFerroso);
            }
            catch (Exception eCita)
            {
                throw new cReglaNegocioException("Error al crear Control PreNatal : Mensaje : " + eCita.Message, eCita);
            }
        }

        public int ModificarCita(cCitaPrenatal citaPrenatal)
        {
            try
            {
                return Conexion.GDatos.Ejecutar("spModificarCitaPreNatal", citaPrenatal.codigoCitaPrenatal, citaPrenatal.HistoriaClinica.Idthistoriaclinica , citaPrenatal.numeroCita,  citaPrenatal.fechaCitaPrenatal, citaPrenatal.edadGestacional, citaPrenatal.fua, citaPrenatal.presionArterialS, citaPrenatal.PresionArterialD, citaPrenatal.fechaProximaCitaPrenatal, citaPrenatal.SulfatoFerroso);
            }
            catch (Exception eCita)
            {
                throw new cReglaNegocioException("Error al modificar Control PreNatal : Mensaje : " + eCita.Message, eCita);
            }
        }

        public int EliminarCita(cCitaPrenatal citaPrenatal)
        {
            try
            {
                return Conexion.GDatos.Ejecutar("spEliminarCitaPreNatal", citaPrenatal.codigoCitaPrenatal);
            }
            catch (Exception eCita)
            {
                throw new cReglaNegocioException("Error al eliminar Control PreNatal : Mensaje : " + eCita.Message, eCita);
            }
        }

        public int EliminarCitaXHistoriaClinica(cCitaPrenatal citaPrenatal)
        {
            try
            {
                return Conexion.GDatos.Ejecutar("spEliminarCitaXHistoriaClinica", citaPrenatal.historiaClinica.Idthistoriaclinica);
            }
            catch (Exception eCita)
            {
                throw new cReglaNegocioException("Error al eliminar Control PreNatal por Historia Clinica : Mensaje : " + eCita.Message, eCita);
            }
        }

        public DataTable ListaCitasPreNatal()
        {
            try
            {
                return Conexion.GDatos.TraerDataTable("spListarCitasPreNatal", historiaClinica.Idthistoriaclinica);
            }
            catch (Exception eCita)
            {
                throw new cReglaNegocioException("Error al traer la lista de Citas: Mensaje : " + eCita.Message, eCita);
            }
        }

        
    }
}
