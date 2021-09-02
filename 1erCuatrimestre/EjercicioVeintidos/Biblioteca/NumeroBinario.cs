using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class NumeroBinario
    {
        public string numero;
        private NumeroBinario(string numeroParam)
        {
            this.numero = numeroParam;
        }
        public static string operator +(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {
            return Conversor.DecimalBinario((int)numDecimal.numero + Conversor.BinarioDecimal(numBinario.numero));
        }
        public static string operator -(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {
            return Conversor.DecimalBinario((int)numDecimal.numero - Conversor.BinarioDecimal(numBinario.numero));
        }
        public static bool operator ==(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {
            return (int)numDecimal.numero == Conversor.BinarioDecimal(numBinario.numero);
            // el igual no se puede aplicar a operandos de tipo string e int, se resuelve sacando el conversor para el numeroDecimal
            // y hay que castear ya que el numero de numDecimal es double
        }
        public static bool operator !=(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {
            return !(numBinario == numDecimal);
        }

        /*Agregar conversiones implícitas para poder ejecutar:
        e. NumeroBinario objBinario = "1001";*/
        //tengo que retornar un objeto de numero binario recibiendo un string como parametro
        public static implicit operator NumeroBinario(string numeroBinString)
        {
            return new NumeroBinario(numeroBinString);
        }

        /*Agregar conversiones explícitas para poder ejecutar:
        g. (string)objBinario*/
        //aca debo devolver un string del numero que asigne en los atributos recibiendo un numero de tipo NumeroBinario
        public static explicit operator string(NumeroBinario numeroBin)
        {
            return numeroBin.numero;
        }
    }
}
