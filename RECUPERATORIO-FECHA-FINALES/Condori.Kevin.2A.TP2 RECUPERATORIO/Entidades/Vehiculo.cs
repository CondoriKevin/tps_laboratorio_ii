using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// clase Vehiculo
    /// </summary>
    public abstract class Vehiculo
    {
        public enum EMarca 
        { 
            Chevrolet,
            Ford,
            Renault,
            Toyota,
            BMW,
            Honda,
            HarleyDavidson 
        }
        public enum ETamanio
        {
            Chico, 
            Mediano, 
            Grande 
        }

        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        /// <summary>
        /// inicializo
        /// </summary>
        protected abstract ETamanio Tamanio
        { 
            get;
        }

        /// <summary>
        /// mostramos todo de los vahiculos
        /// </summary>
        /// <returns>todos los datos del vehiculo</returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        /// <summary>
        /// Constructor de Vehiculo cargando sus parametros que ya fueron inicializados 
        /// </summary>
        /// <param name="chasis"></param>
        /// <param name="marca"></param>
        /// <param name="color"></param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }
        /// <summary>
        /// Descripcion del Vehiculo con chasis, marca color y tamanio
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CHASIS: {p.chasis}");
            sb.AppendLine($"MARCA : {p.marca.ToString()}");
            sb.AppendLine($"COLOR : {p.color.ToString()}");
            sb.AppendLine("---------------------");
            sb.AppendLine("");
            sb.Append($"TAMAÑO : {p.Tamanio}");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>True si tienen el mismo chasis, false si no.</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>True si tienen chasis diferentes, false si son iguales.</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}



