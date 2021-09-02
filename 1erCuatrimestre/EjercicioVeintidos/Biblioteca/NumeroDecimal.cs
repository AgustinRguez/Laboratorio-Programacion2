using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
   public class NumeroDecimal
    {
        public double numero;
        private NumeroDecimal(double numeroParam)
        {
            this.numero = numeroParam;
        }
        public static double operator +(NumeroDecimal numDecimal, NumeroBinario numBinario)
        {
            return Conversor.BinarioDecimal(numBinario.numero) + numDecimal.numero;
        }
        public static double operator -(NumeroDecimal numDecimal, NumeroBinario numBinario)
        {
            return Conversor.BinarioDecimal(numBinario.numero) - numDecimal.numero;
        }
        public static bool operator ==(NumeroDecimal numDecimal, NumeroBinario numBinario)
        {
            return Conversor.BinarioDecimal(numBinario.numero) == numDecimal.numero; //duda si castearlo a int aunque se pierdan datos
        }
        public static bool operator !=(NumeroDecimal numDecimal, NumeroBinario numBinario)
        {
            return !(numBinario == numDecimal);
        }

        /*Agregar conversiones implícitas para poder ejecutar:
        f. NumeroDecimal objDecimal = 9;*/
        //tiene que devolver un NumeroDecimal y pasarle un Double para convertirlo
        public static implicit operator NumeroDecimal(double numeroDecString)
        {
            return new NumeroDecimal(numeroDecString);
        }

        /*Agregar conversiones explícitas para poder ejecutar:
        h. (double)objDecimal*/
        //Devuelvo un double recibiendo un numero de tipo NumeroDecimal
        public static explicit operator double(NumeroDecimal numeroDec)
        {
            return numeroDec.numero;
        }
    }
}
