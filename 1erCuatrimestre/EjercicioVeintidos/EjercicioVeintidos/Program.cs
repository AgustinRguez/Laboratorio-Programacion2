using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
namespace EjercicioVeintidos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*String cadena = "hola";
            Console.WriteLine(Biblioteca.Conversor.Invertir(cadena));
            Console.ReadLine();*/

            NumeroBinario objBinario = "1001";
            NumeroDecimal objDecimal = 9;
            // NumeroBinario binario = new NumeroBinario("10"); no se puede acceder ya que es privado el constructor,
            // hace el trabajo el implicit

            //Converciones Explicitas

            Console.WriteLine("Converciones Explicitas:");
            Console.WriteLine((string)objBinario);
            Console.WriteLine((double)objDecimal);

            //Sobrecarga de Operadores

            Console.WriteLine("Sobrecarga de Operadores:");
            Console.WriteLine(objBinario + objDecimal);
            Console.WriteLine(objBinario - objDecimal);

            Console.ReadKey();


        }
    }
}
