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
        int codigoCitaPrenatal;
        
        DateTime fechaCitaPrenatal;
        int edadGestacional;
        string fua;
        int presionArterialS;
        int presionArterialD;

        public int CodigoCitaPrenatal
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

        public int AgregarCita(cCitaPrenatal nuevaCitaPrenatal)
        {
            try
            {
                return Conexion.GDatos.Ejecutar("spAgregarCitaPreNatal", nuevaCitaPrenatal.codigoCitaPrenatal, nuevaCitaPrenatal.fechaCitaPrenatal, nuevaCitaPrenatal.edadGestacional, nuevaCitaPrenatal.fua, nuevaCitaPrenatal.PresionArterialD, nuevaCitaPrenatal.presionArterialS);
            }
            catch (Exception eCita)
            {
                throw new cReglaNegocioException("Error al crear Control PreNatal ", eCita);
            }
        }

        public int ModificarCita(cCitaPrenatal citaPrenatal)
        {
            try
            {
                return Conexion.GDatos.Ejecutar("spModificarCitaPreNatal", citaPrenatal.codigoCitaPrenatal, citaPrenatal.fechaCitaPrenatal, citaPrenatal.edadGestacional, citaPrenatal.fua, citaPrenatal.PresionArterialD, citaPrenatal.presionArterialS);
            }
            catch (Exception eCita)
            {
                throw new cReglaNegocioException("Error al modificar Control PreNatal ", eCita);
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
                throw new cReglaNegocioException("Error al eliminar Control PreNatal ", eCita);
            }
        }

       public DataTable ListaCitasPreNatal()
        {
            try
            {
                return Conexion.GDatos.TraerDataTable("spListarCitasPreNatal");
            }
            catch (Exception eCita)
            {
                throw new cReglaNegocioException("Error al traer la lista de CItas.", eCita);
            }
        }
    }
}
