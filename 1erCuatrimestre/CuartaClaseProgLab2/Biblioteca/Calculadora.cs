using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Calculadora
    {

        public static float Sumar(float numeroUnoParam, float numeroDosParam)
        {
            return numeroUnoParam + numeroDosParam;
        }
        /// <summary>
        /// Segunda sobrecarga del metodo Sumar
        /// </summary>
        /// <param name="numeroUnoParam"></param>
        /// <param name="numeroDosParam"></param>
        /// <param name="numeroTresParam"></param>
        /// <returns>un numero del segundo metodo sumandose con el primero metodo (en donde se pasan dos parametros)</returns>
        public static float Sumar(float numeroUnoParam, float numeroDosParam, float numeroTresParam)
        {
            //return numeroUnoParam + numeroDosParam + numeroTresParam;
            return numeroTresParam + Calculadora.Sumar(numeroUnoParam, numeroDosParam);
        }
        public static float Sumar(float numeroUnoParam, int numeroDosParam, float numeroTresParam)
        {
            return numeroUnoParam + (float)(numeroDosParam) + numeroTresParam;
        }
        public static float Sumar(float numeroUnoParam, int numeroDosParam, int numeroTresParam)
        {
            return numeroUnoParam + (float)(numeroDosParam) + (float)(numeroTresParam);
        }
    }
}
