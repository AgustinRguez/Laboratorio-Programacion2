using System;
using Biblioteca;
namespace Clase_03_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta c1 = new Cuenta("Agus", 100);
            c1.Ingresar(20);
            Console.WriteLine(c1.Mostrar());
            c1.Retirar(5);
            Console.WriteLine(c1.Mostrar());

            Console.ReadKey();
        }
    }
}
