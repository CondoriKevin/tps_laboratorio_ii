using Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Tela
    {
        #region Atributos
        private EMaquina maquina;
        private string tela;
        private string cliente;
        private int cantidad;
        private ECalidadTela calidadTela;
        #endregion

        #region Propiedades
        public EMaquina Maquina
        {
            get { return this.maquina; }
            set { this.maquina = value; }
        }
        public string Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }
        public string Tela1
        {
            get { return this.tela; }
            set { this.tela = value; }
        }
        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }
        public ECalidadTela CalidadTela
        {
            get { return this.calidadTela; }
            set { this.calidadTela = value; }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Constructor de Tela
        /// </summary>
        /// <param name="maquina"></param>
        /// <param name="tela"></param>
        /// <param name="cliente"></param>
        /// <param name="cantidad"></param>
        /// <param name="calidadTela"></param>
        protected Tela(EMaquina maquina, string tela, string cliente, int cantidad, ECalidadTela calidadTela)
        {
            this.cantidad = cantidad;
            this.calidadTela = calidadTela;
            this.maquina = maquina;
            this.tela = tela;
            this.cliente = cliente;
        }
        /// <summary>
        /// Sobreescritura del metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del cliente {Cliente}");
            sb.AppendLine($"Cantidad: {Cantidad}");
            sb.AppendLine($"Calidad de la Tela: {CalidadTela}");
            sb.AppendLine($"Su maquina seleccionada es: {Maquina}");
            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga de operador == comparando 2 tela
        /// </summary>
        /// <param name="tela1"></param>
        /// <param name="tela2"></param>
        /// <returns></returns>
        public static bool operator ==(Tela tela1, Tela tela2)
        {
            bool retorno = false;
            if (tela1.Equals(tela2) &&
                tela1.Cantidad == tela2.Cantidad &&
                tela1.CalidadTela == tela2.CalidadTela)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="tela1"></param>
        /// <param name="tela2"></param>
        /// <returns></returns>
        public static bool operator !=(Tela tela1, Tela tela2)
        {
            return !(tela1 == tela2);
        }

        #endregion

    }
}
