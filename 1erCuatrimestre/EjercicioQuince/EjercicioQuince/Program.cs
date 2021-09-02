using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
namespace EjercicioQuince
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUnoMain;
            int numeroDosMain;
            string operadorMain;
            Console.WriteLine("Ingrese numero 1");
            numeroUnoMain = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2");
            numeroDosMain = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese operador.");
            operadorMain = Console.ReadLine();

            Console.WriteLine("Resultado: {0}", Calculadora.Calcular(numeroUnoMain, numeroDosMain, operadorMain));
            Console.ReadKey();
        }
    }
}
