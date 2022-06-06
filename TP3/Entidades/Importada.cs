﻿using Entidades.Enumerados;
using Entidades.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Importada : Tela, ITela<Importada>
    {
        /// <summary>
        /// Constructor de Importada con todos los parametros
        /// </summary>
        /// <param name="maquina"></param>
        /// <param name="tela"></param>
        /// <param name="cliente"></param>
        /// <param name="cantidad"></param>
        /// <param name="calidadTela"></param>
        public Importada(EMaquina maquina, string tela, string cliente, int cantidad, ECalidadTela calidadTela)
            : base(maquina, tela, cliente, cantidad, calidadTela)
        {
        }
        /// <summary>
        /// Sobreescritura del metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tela Importada");
            sb.Append(base.ToString());
            return sb.ToString();
        }
        /// <summary>
        /// Sobreescritura del metodo Equals()
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Importada;
        }
        /// <summary>
        /// Calcula la ganancia dependiendo la cantidad de dicho tela
        /// </summary>
        /// <returns></returns>
        public float CalcularGanancia(Importada tela)
        {
            float ganancia = 0;
            switch (tela.CalidadTela)
            {
                case ECalidadTela.Malo:
                    {
                        ganancia = base.Cantidad * (float)0.6;
                        break;
                    }
                case ECalidadTela.Bueno:
                    {
                        ganancia = base.Cantidad * (float)0.7;
                        break;
                    }
                case ECalidadTela.Excelente:
                    {
                        ganancia = base.Cantidad * (float)0.8;
                        break;
                    }
            }
            return ganancia;
        }
        /// <summary>
        /// Retorna true si el tela es de calidadTela Excelente
        /// </summary>
        /// <param name="tela"></param>
        /// <returns></returns>
        public bool EsValioso(Importada tela)
        {
            bool retorno = false;
            if (tela.CalidadTela == ECalidadTela.Excelente)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
