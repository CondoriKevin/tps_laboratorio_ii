using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        /// <summary>
        /// constructor del sedan 
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
        }

        /// <summary>
        /// Ciclomotor "Chico"
        /// </summary>
        protected override ETamanio Tamanio 
        { 
            get 
            {
                return ETamanio.Chico; 
            } 
        }

        public override string Mostrar()
        {
            StringBuilder a = new StringBuilder();

            a.AppendLine(" Ciclomotor ");
            a.Append(base.Mostrar());
            a.AppendLine("");
            a.AppendLine("---------------------------");

            return a.ToString();
        }
    }
}
