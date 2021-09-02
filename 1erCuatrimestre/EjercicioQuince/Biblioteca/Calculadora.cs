using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Calculadora
    {
        private static Boolean Validar(int segundoNumeroParam)
        {
            if(segundoNumeroParam != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int Calcular(int numeroUno, int numeroDos, string operacion)
        {
            int resultado=0;
            switch (operacion)
            {
                case "+":
                    resultado = numeroUno + numeroDos;
                    break;
                case "-":
                    resultado = numeroUno - numeroDos;
                    break;
                case "*":
                    resultado = numeroUno * numeroDos;
                    break;
                case "/":
                    if(Validar(numeroDos) == true)
                        resultado = numeroUno / numeroDos;
                    break;
            }
            return resultado;
        }
    }
}
