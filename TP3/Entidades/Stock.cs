using Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Stock
    {
        private string nombre;
        private List<Tela> listaDeTelas;
        /// <summary>
        /// Constructor que instancia la lista de telas
        /// </summary>
        private Stock()
        {
            this.listaDeTelas = new List<Tela>();
        }
        /// <summary>
        /// Constructor de Stock
        /// </summary>
        /// <param name="nombre"></param>
        public Stock(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        /// <summary>
        /// Retorna la lista de telas completa
        /// </summary>
        public List<Tela> ListaDeTelas
        {
            get { return this.listaDeTelas; }
        }
        /// <summary>
        /// Agrega un telal a la lista
        /// </summary>
        /// <param name="tela"></param>
        private void AgregarTela(Tela tela)
        {
            this.listaDeTelas.Add(tela);
        }
        /// <summary>
        /// Sobrecarga del operador == que identifica si ya esta cargado o no un telal a la lista
        /// </summary>
        /// <param name="stock"></param>
        /// <param name="tela"></param>
        /// <returns></returns>
        public static bool operator ==(Stock stock, Tela tela)
        {
            bool retorno = false;
            foreach (Tela item in stock.ListaDeTelas)
            {
                if (item == tela)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="stock"></param>
        /// <param name="tela"></param>
        /// <returns></returns>
        public static bool operator !=(Stock stock, Tela tela)
        {
            return !(stock == tela);
        }
        /// <summary>
        /// Sobrecarga del operador + para agregar un telal a la lista
        /// </summary>
        /// <param name="stock"></param>
        /// <param name="tela"></param>
        /// <returns></returns>
        public static Stock operator +(Stock stock, Tela tela)
        {
            if (stock != tela && !(tela is null))
            {
                stock.AgregarTela(tela);
            }
            return stock;
        }
        /// <summary>
        /// Filtra la lista de telas segun el maquina en el que se encuentre el telal
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="maquina"></param>
        /// <returns></returns>
        public List<Tela> FiltrarLista(List<Tela> lista, EMaquina maquina)
        {
            List<Tela> listaFiltrada = new List<Tela>();
            foreach (Tela item in listaDeTelas)
            {
                if (item.Maquina == maquina)
                {
                    listaFiltrada.Add(item);
                }
            }
            return listaFiltrada;
        }
        /// <summary>
        /// Identifica si un telal esta en el maquina de Finalizado
        /// </summary>
        /// <param name="telal"></param>
        /// <returns></returns>
        public bool Finalizar(Tela telal)
        {
            bool retorno = false;
            if (telal.Maquina == EMaquina.Bordadora)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
