using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class cVariables
    {
        string snombreobstetra;
        string sidobstetra;
        string snombreestablecimientosalud;
        string sidestablecimientosalud;

        public string NombreObstetra
        { get { return snombreobstetra; } set { snombreobstetra = value; } }
        public string IdObstetra
        { get { return sidobstetra; } set { sidobstetra = value; } }
        public string NombreEstablecimientoSalud
        { get { return snombreestablecimientosalud; } set { snombreestablecimientosalud = value; } }
        public string IdEstablecimientoSalud
        { get { return sidestablecimientosalud; } set { sidestablecimientosalud = value; } }
    }
}
