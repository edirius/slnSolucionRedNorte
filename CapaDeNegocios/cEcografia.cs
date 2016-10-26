using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    class cEcografia
    {
        private string idtecografia;

        public string Idtecografia
        {
            get { return idtecografia; }
            set { idtecografia = value; }
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

        private string edadgestacional;

        public string Edadgestacional
        {
            get { return edadgestacional; }
            set { edadgestacional = value; }
        }

        private string idthistoriaclinica;

        public string Idthistoriaclinica
        {
            get { return idthistoriaclinica; }
            set { idthistoriaclinica = value; }
        }

    }
}
