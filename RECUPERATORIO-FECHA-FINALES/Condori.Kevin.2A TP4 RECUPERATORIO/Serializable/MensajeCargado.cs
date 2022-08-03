using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializable
{
    public static class MensajeCargado
    {
        private static List<Mensaje> misMensajes;
        /// <summary>
        /// Instancia la lista de mensajes
        /// </summary>
        static MensajeCargado()
        {
            misMensajes = new List<Mensaje>();
        }
        /// <summary>
        /// permite settear y agregar un mensaje
        /// </summary>
        public static Mensaje Mensaje
        {
            set
            {
                misMensajes += value;
            }
        }
        /// <summary>
        /// Retorna un string del contenido de la lista de mensajes
        /// </summary>
        /// <returns></returns>
        public static string MostrarMensajes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Mensaje item in misMensajes)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
