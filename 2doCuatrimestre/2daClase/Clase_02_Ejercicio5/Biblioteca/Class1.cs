using System;

namespace Biblioteca
{
    public class Class1
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double resultado;
            return resultado = longitudLado = Math.Pow(longitudLado, 2);
        }
        public static double CalcularAreaTriangulo(double basse, double altura)
        {
            double resultado;
            return resultado = basse * altura / 2;
        }
        public static double CalcularAreaCirculo(double radio)
        {
            double resultado;
            return resultado = 3.14 * Math.Pow(radio, 2);
        }
    }
}
