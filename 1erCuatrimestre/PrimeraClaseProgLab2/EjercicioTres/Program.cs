using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroAMostrar;
            int i;
            int j;
            Console.WriteLine("Ingrese numero para verificar si es primo: ");
            if (int.TryParse(Console.ReadLine(), out numeroAMostrar))
            {
               
                for (j = 2; j <= numeroAMostrar; j++)
                {

                    for (i = 2; i < j; i++)
                    {
                        if ((j % i) == 0)
                        {
                            break;         
                        }
                    }
                        if (i == j)
                        {
                            Console.WriteLine(" {0} es primo", j);
                            Console.ReadLine();
                        } 
                }
            }
            
        }
    }
}
