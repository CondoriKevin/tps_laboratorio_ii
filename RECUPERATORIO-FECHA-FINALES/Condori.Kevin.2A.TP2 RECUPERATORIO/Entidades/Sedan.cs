using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo 
        { 
            CuatroPuertas, 
            CincoPuertas 
        }private ETipo tipo;

        /// <summary>
        /// Constructor de Sedan, con sus respectivos parametros 
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : this(marca, chasis, color, ETipo.CuatroPuertas)
        {
        }
        /// <summary>
        /// Constructor de Sedan 
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// del tipo "mediano"
        /// </summary>
        protected override ETamanio Tamanio {
            get 
            {
                return ETamanio.Mediano; 
            }
        }

        /// <summary>
        /// Dnos muestra todos los datos del sedan
        /// </summary>
        /// <returns>Retorna la descripcion del Sedan.</returns>
        public override string Mostrar()
        {
            StringBuilder a = new StringBuilder();

            a.AppendLine("SEDAN");
            a.Append(base.Mostrar());
            a.AppendLine($"TIPO : {this.tipo}");
            a.AppendLine("");
            a.AppendLine("---------------------");

            return a.ToString();
        }
    }
}
