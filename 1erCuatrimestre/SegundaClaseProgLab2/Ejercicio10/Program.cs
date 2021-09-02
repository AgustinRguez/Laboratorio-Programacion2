using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //ClassPersona.texto();
            int numeroEscalar = 10;
            int auxiliar;
            int minimoMain = int.MaxValue;
            int maximoMain = int.MinValue;
            float promedio = 0;
            string texto;
            

            for (int i = 0; i < numeroEscalar; i++)
            {
                Console.WriteLine("Ingrese 10 numeros: ");
                texto = Console.ReadLine();
                if(int.TryParse(texto, out auxiliar))
                {
                    if(!Validacion.Validar(auxiliar, -100, 100))
                    {
                        if (auxiliar > maximoMain)
                        {
                            maximoMain = auxiliar;
                        }

                        if (auxiliar < minimoMain)
                        {
                            minimoMain = auxiliar;
                        }
                    }
                    
                    promedio = (promedio + auxiliar);
                }
                else
                {
                    Console.WriteLine("Error, rango incorrecto.");
                }
                
            }
            promedio = promedio / numeroEscalar;
            Console.WriteLine("Maximo: {0}", maximoMain);
            Console.WriteLine("Minimo: {0}", minimoMain);
            Console.WriteLine("Promedio: {0:#.#}", promedio);
            Console.ReadKey();

        }
    }
}
