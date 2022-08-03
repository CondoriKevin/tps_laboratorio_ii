using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ErrorGuardarException : Exception
    {
        /// <summary>
        /// Excepcion que se lanza si algo fallo a la hora de guardar los datos 
        /// </summary>
        /// <param name="mensajeExcepcion"></param>
        public ErrorGuardarException(string mensajeExcepcion)
            : base("Error al tratar de escribir el archivo : " + mensajeExcepcion)
        {
        }
    }
}