using System;
using Biblioteca;
namespace Clase_02_Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double cuadrado;
            double triangulo;
            double circulo;
            cuadrado = Class1.CalcularAreaCuadrado(5);
            triangulo = Class1.CalcularAreaTriangulo(10, 10);
            circulo = Class1.CalcularAreaCirculo(4.15);

            Console.WriteLine("Area de cuadrado: " + cuadrado +
                "\nArea de triangulo: " + triangulo + "\nArea de circulo: " + circulo);
        }
    }
}
