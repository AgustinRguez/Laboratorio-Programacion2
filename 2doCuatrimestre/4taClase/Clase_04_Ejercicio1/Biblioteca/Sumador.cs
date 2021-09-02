using System;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador():this(0)
        {
            
        }
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        
        public long Sumar(long a, long b)
        {
           this.cantidadSumas++;
            long resultado = 0;
            resultado = a + b;
            return resultado;
        }
        public String Sumar(string a, string b)
        {
            this.cantidadSumas++;
            String texto="";
            texto = String.Concat(a + b);
            return texto;
        }
        public static explicit operator int (Sumador s)
        {
            return s.cantidadSumas;
        }
        public static long operator +(Sumador s1, Sumador s2)
        {
            return (s1.cantidadSumas + s2.cantidadSumas);
        }
        public static bool operator |(Sumador s1, Sumador s2)
        {
            if (s1.cantidadSumas.Equals(s2.cantidadSumas))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
