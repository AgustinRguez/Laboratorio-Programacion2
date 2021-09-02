using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraClaseProgLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string texto;
            string textoParaLine;
            int numeroParse;
            
            Console.Write("Ingresa un numero");
            texto = Console.ReadLine(); //scanf(%s, texto);

            Console.WriteLine("hola con write line");//agrega salto de linea
            textoParaLine = Console.ReadLine();

            //casteo explicito
            numeroParse = (int)float.Parse(texto);

            //Parseo
            numeroParse = int.Parse(texto);
            Console.WriteLine(numeroParse + 5);
            Console.ReadLine();

            //casteo implicito
            double valor = numeroParse;
            double resultadoSuma = suma(ref valor,10); //ref pasa la direccion de memoria y no el valor
                                                             // out retorna mas de un valor o variable
            Console.WriteLine(resultadoSuma);
            Console.ReadLine();*/

            //pedir un texto en pantalla y contar cuantas a tiene

            string texto;
            string textoA;
            int contadorDeA=0;
            Console.WriteLine("Ingrese un texto:");
            texto = Console.ReadLine();
            for(int i = 0; i < texto.Length; i++)
            {
                textoA = texto.Substring(i,1); //Devuelve los caracteres extraídos de una cadena según la posición
                                               //del carácter especificado para una cantidad especificada de caracteres.
                if (textoA == "a")
                {
                    contadorDeA++;
                }
            }
            Console.WriteLine("Cantidad de A: "+contadorDeA);
            Console.ReadLine();
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numeroUno"></param>
        /// <param name="numeroDos"></param>
        /// <returns></returns>
        public static double suma(ref double numeroUno, double numeroDos)
        {
            double resultado;
            resultado = numeroUno + numeroDos;
            return resultado;
        }

    }
}
