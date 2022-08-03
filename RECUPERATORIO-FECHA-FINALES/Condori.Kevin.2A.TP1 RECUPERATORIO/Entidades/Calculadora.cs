using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// mediante el operador, realiza la operacion deseada entre 2 tipos "Operando"
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = double.NaN;
            switch (ValidadOperador(operador))
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break; 
            }

            return Math.Round(resultado, 3, MidpointRounding.ToEven);
        }

        /// <summary>
        /// si el operador es distinto de las cuatro eperaciones principales( + - * /) entonces decuelve una +
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static char ValidadOperador(char operador)
        {
            if (operador != '+' && operador != '-' && operador != '*' && operador != '/')
            {
                operador = '+';
            }
            return operador;
        }
    }
}
