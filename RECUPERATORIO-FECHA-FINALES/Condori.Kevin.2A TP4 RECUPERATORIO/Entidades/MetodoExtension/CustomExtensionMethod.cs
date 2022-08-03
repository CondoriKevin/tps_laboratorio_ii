using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class CustomExtensionMethod
    {
        /// <summary>
        /// Metodo de extension que cuenta la cantidad de letras de un string
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static int ContadorDeLetrasInforme(this string texto)
        {
            return texto.Length;
        }
    }
}
