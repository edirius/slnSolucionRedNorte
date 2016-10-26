using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class cReglaNegocioException:ApplicationException 
    {
        /// <summary>
        /// Construye una instancia con un mensaje de error, 
        /// invocando al constructor de la clase base.
        /// </summary>
        /// <param name="mensaje">El mensaje de error.</param>
        /// <param name="original">El error original.</param>
        public cReglaNegocioException(string mensaje, Exception original) : base(mensaje, original)
        {

        }

        /// <summary>
        /// Construye una instancia con un mensaje de error, 
        /// invocando al constructor de la clase base.
        /// </summary>
        /// <param name="mensaje">El mensaje de error.</param>
        public cReglaNegocioException(string mensaje) : base(mensaje)
        {

        }
    }
}
