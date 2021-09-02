using System;
using Biblioteca;
namespace Clase_04_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sum1 = new Sumador(3);
            Sumador sum2 = new Sumador();
           
            Console.WriteLine("Sum1: " + sum1.Sumar(100, 200));
            Console.WriteLine("Sum1: " + sum1.Sumar("3", "16"));
            int cantidadSumas = (int)sum1;
            Console.WriteLine("Cantidad de sumas: " + cantidadSumas);

            Console.WriteLine("-----------------------");
            Console.WriteLine("Sum2: " + sum2.Sumar(300, 500));
            Console.WriteLine("Sum2: " + sum2.Sumar("1000", "5654"));
            int cantidadSumasDos = (int)sum2;
            Console.WriteLine("Cantidad de sumas: " + cantidadSumasDos);

            Console.WriteLine("-----------------------");
            if (sum1 | sum2)
            {
                Console.Write("True");
            }
            else
            {
                Console.Write("False\n");
            }
            Console.WriteLine(sum1 + sum2);
            Console.ReadKey();
        }
    }
}
