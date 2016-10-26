using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class cOdontologia
    {

        private string idtodontologia;

        public string Idtodontologia
        {
            get { return idtodontologia; }
            set { idtodontologia = value; }
        }

        private string fecha_servicio;

        public string Fecha_servicio
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

        private string idthistoriaclinica;

        public string Idthistoriaclinica
        {
            get { return idthistoriaclinica; }
            set { idthistoriaclinica = value; }
        }

    }
}
