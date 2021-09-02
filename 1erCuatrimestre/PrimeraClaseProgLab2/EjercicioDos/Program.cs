using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDos
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroIngresadoMain;
            string texto;
            double resultadoDeMain;
            Console.WriteLine("Ingrese numero");
            texto = Console.ReadLine();
            numeroIngresadoMain = double.Parse(texto);
            if(numeroIngresadoMain > 0)
            {
                resultadoDeMain=elevarALaPotencia(numeroIngresadoMain, 5);
                Console.WriteLine("Resultado {0}", resultadoDeMain);
                Console.ReadKey();
            }
            
        }
        public static double elevarALaPotencia(double numeroIngresado, double numeroDePotencia)
        {
            double resultado;
            resultado = Math.Pow(numeroIngresado, numeroDePotencia);

            return resultado;
        }
    }
}
