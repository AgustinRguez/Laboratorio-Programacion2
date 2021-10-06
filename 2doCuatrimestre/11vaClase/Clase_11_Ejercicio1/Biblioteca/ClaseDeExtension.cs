using System;

namespace Biblioteca
{
    public static class ClaseDeExtension
    {
        public static string FizzBuzz(this Int32 numero)
        {
            string texto = string.Empty;
            if (numero % 3 == 0)
            {
                texto += "Fizz";
            }
            if (numero % 5 == 0)
            {
                texto += "Buzz";
            }
            if (numero % 3 != 0 && numero % 5 != 0)
            {
                texto += string.IsNullOrEmpty(texto);
            }
            return texto;
        }
    }
}
