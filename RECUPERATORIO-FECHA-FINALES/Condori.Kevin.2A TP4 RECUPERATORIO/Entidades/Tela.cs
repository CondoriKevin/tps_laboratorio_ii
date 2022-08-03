using Entidades;
using Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Tela
    {
        #region Atributos
        private int id;
        private string tela;
        private string maquina;
        private string cliente;
        private int cantidad;
        private string calidadTela;
        #endregion

        /// <summary>
        /// Identifica si un tela esta en el maquina de Bordadora
        /// </summary>
        /// <param name="tela"></param>
        /// <returns></returns>
        public static bool Finalizar(Tela tela)
        {
            bool retorno = false;
            if (tela.Maquina == "Bordadora")
            {
                retorno = true;
            }
            return retorno;
        }


        #region Propiedades
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Tela1
        {
            get { return this.tela; }
            set { this.tela = value; }
        }
        public string Maquina
        {
            get { return this.maquina; }
            set { this.maquina = value; }
        }
        public string Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }
        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }
        public string CalidadTela
        {
            get { return this.calidadTela; }
            set { this.calidadTela = value; }
        }
        #endregion

        #region Metodos
        public Tela()
        {

        }
        /// <summary>
        /// Constructor de Tela
        /// </summary>
        /// <param name="maquina"></param>
        /// <param name="tela"></param>
        /// <param name="cliente"></param>
        /// <param name="cantidad"></param>
        /// <param name="calidadTela"></param>
        protected Tela(int id, string maquina, string tela, string cliente, int cantidad, string calidadTela)
        {
            this.id = id;
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
            sb.AppendLine($"Proveniente de {Cliente}");
            sb.AppendLine($"Cantidad: {Cantidad}");
            sb.AppendLine($"Calidad Tela: {CalidadTela}");
            sb.AppendLine($"Su maquina para el trabajo es: {Maquina}");
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
        /// <summary>
        /// Calcula las ganancias de los telaes diferenciando su tipo y calidadTela
        /// </summary>
        /// <param name="tela"></param>
        /// <returns></returns>
        public float CalcularGanancia(Tela tela)
        {
            float ganancia = 0;
            if (tela is Nacional)
            {
                switch (tela.CalidadTela)
                {
                    case "Malo":
                        {
                            ganancia = Cantidad * (float)0.7;
                            break;
                        }
                    case "Bueno":
                        {
                            ganancia = Cantidad * (float)0.8;
                            break;
                        }
                    case "Excelente":
                        {
                            ganancia = Cantidad * (float)0.9;
                            break;
                        }
                }
            }
            else
            {
                switch (tela.CalidadTela)
                {
                    case "Malo":
                        {
                            ganancia = Cantidad * (float)0.6;
                            break;
                        }
                    case "Bueno":
                        {
                            ganancia = Cantidad * (float)0.7;
                            break;
                        }
                    case "Excelente":
                        {
                            ganancia = Cantidad * (float)0.8;
                            break;
                        }
                }
            }
            return ganancia;
        }
        
        #endregion

    }
}

