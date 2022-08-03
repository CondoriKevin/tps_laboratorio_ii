using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SqlExcepcion : Exception
    {
        /// <summary>
        /// Excepcion que se lanza si hay algun problema a la hora de trabajar con la base de datos
        /// </summary>
        /// <param name="message"></param>
        public SqlExcepcion(string message)
            : base(message)
        {
        }
    }
}
