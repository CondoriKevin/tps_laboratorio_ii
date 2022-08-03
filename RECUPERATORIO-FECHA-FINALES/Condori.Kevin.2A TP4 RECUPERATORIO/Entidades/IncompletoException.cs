using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class IncompletoException : Exception
    {
        /// <summary>
        /// Excepcion que se lanzara cuando se treten de guardar con los datos incompletos
        /// </summary>
        /// <param name="message"></param>
        public IncompletoException(string message)
            : base(message)
        {
        }
    }
}
