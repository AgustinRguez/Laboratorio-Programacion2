using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Conversor
    {
        public static string Invertir(string cadena)
        {
            string auxCadena = "";//hola aloh
            for (int i = cadena.Length-1; i >= 0; i--)
            {
                auxCadena += cadena[i];
            }
            return auxCadena;
        }
        /// <summary>
        /// Convierte un número de entero a binario.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string DecimalBinario(int num)
        {
            string resto = "";

            for (; num >= 2;)
            {
                resto += num % 2; 
                num = num / 2;    
            }
            resto += num;
            return Conversor.Invertir(resto);
        }
        /// <summary>
        /// Convierte un número de binario a entero.
        /// </summary>
        /// <param name="bin"></param>
        /// <returns></returns>
        public static int BinarioDecimal(string bin)
        {
            int valor = 0;
            bin = Conversor.Invertir(bin);

            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i] == '1')
                {
                    valor += (int)Math.Pow(2, i);
                }
            }
            return valor;
        }
    }
}
