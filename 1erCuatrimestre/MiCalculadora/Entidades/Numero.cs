using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos
        private double numero;
        #endregion
        #region Constructores
        public Numero() 
        {
            this.numero = 0;
        }
        public Numero(double numero) : this(numero + "")
        {

        }
        public Numero(string numero)
        {
            SetNumero(numero);
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Metodo que realiza la operacion de suma entre dos numeros
        /// </summary>
        /// <param name="numeroUno"></param>
        /// <param name="numeroDos"></param>
        /// <returns>retona la suma</returns>
        public static double operator +(Numero numeroUno, Numero numeroDos)
        {
            return numeroUno.numero + numeroDos.numero;
        }
        /// <summary>
        /// Metodo que realiza la operacion de resta entre dos numeros
        /// </summary>
        /// <param name="numeroUno"></param>
        /// <param name="numeroDos"></param>
        /// <returns>retorna la resta de dos numeros</returns>
        public static double operator -(Numero numeroUno, Numero numeroDos)
        {
            return numeroUno.numero - numeroDos.numero;
        }
        /// <summary>
        /// Metodo que realiza la operacion de multiplicacion entre dos numeros
        /// </summary>
        /// <param name="numeroUno"></param>
        /// <param name="numeroDos"></param>
        /// <returns>retorna la multiplicacion de dos numeros</returns>
        public static double operator *(Numero numeroUno, Numero numeroDos)
        {
            return numeroUno.numero * numeroDos.numero;
        }
        /// <summary>
        /// Metodo que realiza la operacion de division entre dos numeros
        /// </summary>
        /// <param name="numeroUno"></param>
        /// <param name="numeroDos"></param>
        /// <returns>retorna la division de dos numeros, en caso de que el segundo numero sea un 0 se retornara</returns>
        public static double operator /(Numero numeroUno, Numero numeroDos)
        {
            if(numeroDos.numero == 0)
            {
                
                return double.MinValue;
            }
            else
            {
                return numeroUno.numero / numeroDos.numero;
            }
            
        }
        /// <summary>
        /// Comprueba que el valor recibido sea numerico y lo retorna en double
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>se retorna un numero casteado a double sino, 0</returns>
        private double ValidarNumero(string strNumero)
        {
            return double.Parse(strNumero);
        }
        /// <summary>
        /// Se asigna o valida al atributo numero y este es devuelto como string
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Un numero string</returns>
        public string SetNumero(string strNumero)
        {
            numero = ValidarNumero(strNumero);
            return numero.ToString();
        }
        //seguir desde EsBinario
        /// <summary>
        /// Metodo que valida que a una cadena se le paso solo 0 y 1
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Devuelve true si es un numero compuesto por 0 y 1, en caso contrario devuelve false</returns>
        private static bool EsBinario(string binario)
        {
            bool opcion = false;
         
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    opcion = false;
              
                }
                else
                {
                    opcion = true;
                }
            }
            return opcion;
        }
        /// <summary>
        /// Convierte un numero binario a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>retorna un decimal en formato string de un numero binario</returns>
        public static string BinarioDecimal(string binario)
        {
            string numeroDecimal = "";
            double potenciaDeDos = 0;
            for (int i = 1; i <= binario.Length; i++)
            {
                if (EsBinario(binario) == true)
                {
                    potenciaDeDos += double.Parse(binario[i - 1].ToString()) * (Math.Pow(2, binario.Length - i));
                }
                
            }
            numeroDecimal += potenciaDeDos;

            return numeroDecimal;
                
        }
        /// <summary>
        /// transforma de decimal a binario recibiendo un double como param
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>retornara un numero binario de tipo string</returns>
        public static string DecimalBinario(double numero)
        {
            string numeroBin = "";
            while((int)numero > 0)
            {
                numeroBin = ((int)numero % 2).ToString() + numeroBin;
                numero = numero / 2;
            }
            return numeroBin;
        }
        /// <summary>
        /// Metodo que parsea un numero string a double para pasarlo a la misma funcion que recibe un double
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>retonara un decimal de tipo string en binario</returns>
        public static string DecimalBinario(string numero)
        {
            double numeroDecimal;
            for (int i = 0; i < numero.Length; i++)
            {
                if(numero[i] < '0' || numero[i] > '9')
                {
                    return "Valor invalida";
                }
            }
            return double.TryParse(numero, out numeroDecimal) ? DecimalBinario(numeroDecimal) : "Valor invalido";

        }
        #endregion
    }
}
