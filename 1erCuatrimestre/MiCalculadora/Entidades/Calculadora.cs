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
        /// Validara que el ooperador recibido sea de suma resta multiplicacion o division
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>devolvera el operador elegido o retornara, en caso de error, el +</returns>
        private static String ValidarOperador(string operador)
        {
            
            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                return operador;
            }
            else {
                return "+";
            }
        }
        /// <summary>
        /// Realiza la operacion que se elija
        /// </summary>
        /// <param name="numeroUno"></param>
        /// <param name="numeroDos"></param>
        /// <param name="operar"></param>
        /// <returns>retornara la operacion dependiendo que operador se elija</returns>
        public static double Operar(Numero numeroUno, Numero numeroDos, string operar)
        {
            
            switch (ValidarOperador(operar))
            {
                case "+" :
                    return numeroUno + numeroDos;
                case "-" :
                    return numeroUno - numeroDos;
                case "*":
                    return numeroUno * numeroDos;
                case "/":
                    return numeroUno / numeroDos;
                default:
                    return 0;

            }
        }
    }
}
