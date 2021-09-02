using System;
using Biblioteca;
namespace Clase_02_Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            long numeroMain = 0;
            
            Console.WriteLine("Ingrese numero para calcularle factorial: ");
            numeroMain = long.Parse(Console.ReadLine());
            Console.WriteLine("El factorial es: " + Class1.factorial(numeroMain));
            Console.ReadKey();
        }
        
    }
}
