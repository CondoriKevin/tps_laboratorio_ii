using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ErrorCargarException : Exception
    {
        /// <summary>
        /// Excepcionse lanza si hubo un probmlema a la hora de cargar los datos
        /// </summary>
        /// <param name="mensajeExcepcion"></param>
        public ErrorCargarException(string mensajeExcepcion)
            : base("Error al tratar de leer el archivo: " + mensajeExcepcion)
        {
        }
    }
}
