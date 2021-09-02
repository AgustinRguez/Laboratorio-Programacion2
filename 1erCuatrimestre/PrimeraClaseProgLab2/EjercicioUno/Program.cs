using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUno
{
    class Program
    {
        
        static void Main(string[] args)
        {
          //tryparse Su objetivo es intentar (try) interpretar (parse) una cadena de texto como un dato de tipo int
          // devuelve una variable booleana para indicar si lo consiguió o no. Devuelve bool

            int cantidadNumeros = 5;
            int auxiliarAComparar;
            string texto;
            int maximo = 0;
            int minimo = int.MaxValue;
            float promedio = 0;

            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.WriteLine("Ingrese numeros: ");
                texto = Console.ReadLine();
                if (int.TryParse(texto, out auxiliarAComparar))
                {
                    if (auxiliarAComparar > maximo)
                    {
                        maximo = auxiliarAComparar;
                    }

                    if (auxiliarAComparar < minimo)
                    {
                        minimo = auxiliarAComparar;
                    }
                    promedio = (promedio + auxiliarAComparar);
                }
                else
                {
                    Console.WriteLine("Numero equivocado.");
                    
                }
            }
            promedio = promedio / cantidadNumeros;

          
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Maximo: {0}", maximo);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Minimo: {0}", minimo);
            Console.WriteLine("Promedio: {0:#.#}", promedio);
            Console.ReadKey();
        }
    }
}
