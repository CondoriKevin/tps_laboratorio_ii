using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }
        /// <summary>
        /// SUV del "grande"
        /// </summary>
        protected override ETamanio Tamanio {
            get 
            { 
                return ETamanio.Grande; 
            } 
        }

        public override string Mostrar()
        {
            StringBuilder a = new StringBuilder();

            a.AppendLine("SUV");
            a.Append(base.Mostrar());
            a.AppendLine("");
            a.AppendLine("---------------------");

            return a.ToString();
        }
    }
}
