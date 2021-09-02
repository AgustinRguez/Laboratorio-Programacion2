using System;
using Biblioteca;
namespace Clase_02_Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un numero: ");
            int.TryParse(Console.ReadLine(), out numero);
            Console.WriteLine(Class1.Tabla(numero));
            Console.ReadKey();
        }
    }
}
