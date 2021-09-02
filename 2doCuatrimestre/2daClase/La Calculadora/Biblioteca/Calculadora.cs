using System;

namespace Biblioteca
{
    public class Calculadora
    {
        public static float Calcular(float numeroUno, float numeroDos, char operador)
        {
            float resultado=0;
            if (operador == '+')
                resultado = numeroUno + numeroDos;
            if (operador == '-')
                resultado = numeroUno - numeroDos;
            if (operador == '*')
                resultado = numeroUno * numeroDos;
            if (operador == '/' && Validar(numeroDos))
                resultado = numeroUno / numeroDos;
            return resultado;
        }
        private static bool Validar(float numeroDos)
        {
            if(numeroDos != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
