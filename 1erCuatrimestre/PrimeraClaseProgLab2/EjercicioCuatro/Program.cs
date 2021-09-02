using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            int encontradoPerfecto=0;
            int numero = 1;
            
            do
            {
                int acumulador = 0;
                for (int i = numero-1; i > 0; i--)
                {
                    if((numero % i)==0)
                    {
                        acumulador += i;
                        if(acumulador > numero)
                        {
                            break;
                        }
                    }
                }
                if(acumulador == numero)
                {
                    encontradoPerfecto++;
                    Console.WriteLine("{0} numero perfecto",numero);
                }
                numero++;
            } while (encontradoPerfecto < 4);
            Console.ReadKey();
        }
    }
}
