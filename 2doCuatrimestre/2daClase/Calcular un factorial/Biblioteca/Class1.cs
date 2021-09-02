using System;

namespace Biblioteca
{
    public class Class1
    {
        public static long factorial(long numero)
        {
            long auxiliar;
            auxiliar = numero;
            while(numero > 1)
            {
               numero--;
               auxiliar = auxiliar * numero;
            }
            return auxiliar;
        }
    }
}
