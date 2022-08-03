using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// <set>
        /// le damos valor a "Numero" y luego se validara
        /// </set>
        /// <get>
        /// NULL
        /// </get>
        /// </summary>
        private string Numero 
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        /// iniciamos el valor de "numero"
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// asiganamos el valor de numero 
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// vemos que el dato ingresado sea numerico, en todo caso devuelve un cero
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarOperando(string strNumero)
        {
            if (!double.TryParse(strNumero.Replace(".", ","), out double retorno))
            {
                retorno = 0;
            }

            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private static bool EsBinario(string binario)
        {
            foreach (char i in binario)
            {
                if (i != '1' && i != '0')
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// pasamos de decimal a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(double numero)
        {
            string binario = string.Empty;
            int resultado = (int)numero;
            int resto;

            while (resultado > 0)
            {
                resto = resultado % 2;

                binario = resto.ToString() + binario;
                resultado /= 2;
            }

            return binario;
        }

        /// <summary>
        /// aseguramos que sea binario y en caso contrario mostrara el mensaje de "Valor invalido"
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(string numero)
        {
            string retorno = "Valor inválido";
            if(double.TryParse(numero, out double nDecimal))
            {
                retorno = DecimalBinario(nDecimal);

            }

            return retorno;
        }

        /// <summary>
        /// de binario a decimal si es posible, si no muestra el mensaje de "valor invalido"
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public static string BinarioDecimal(string binario)
        {
            string strRetorno = "Valor inválido";
            if (EsBinario(binario))
            {
                int nDecimal = 0;
                int pos = binario.Length;
                foreach (char i in binario)
                {
                    pos--;
                    if (i == '1')
                    {
                        nDecimal += (int)Math.Pow(2, pos);
                    }
                }
                strRetorno = nDecimal.ToString();
            }
             return strRetorno; 

        }

        /// <summary>
        /// sobrecarga del operador +
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// sobrecarga del operador -
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// sobrecarga del operador *
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// sobrecarga del operador /, en caso de ser una division invalida, devolvera el mensaje
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator /(Operando n1, Operando n2)
        {

            if (n2.numero != 0)
            {
                return n1.numero / n2.numero;
            }
            return double.MinValue;  
        }

    }
}
