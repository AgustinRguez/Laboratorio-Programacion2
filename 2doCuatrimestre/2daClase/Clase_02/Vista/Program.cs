using System;
using Biblioteca;
namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            /*float temperaturaKelvin;
            float temperaturaCelsius;
            temperaturaKelvin = ConversorDeTemperatura.ConvertirCelsiusAKelvin(14.2F);
            temperaturaCelsius = ConversorDeTemperatura.ConvertirKelvinACelsius(201.4F);
            Console.WriteLine("Temperatura Kelvin {0} y Temperatura Celsius {1}", temperaturaKelvin,
                temperaturaCelsius);*/

            /*Ejercicio 1 del dia*/
            int valor = 0;
            int acumulador = 0;
            int index = 0;
            int valorMinimo = -100;
            int valorMaximo = 100;
            int maximo = 0;
            int minimo = 0;
            
            while (index < 10)
            {
                Console.WriteLine("Ingrese 10 numeros");
                valor = int.Parse(Console.ReadLine());
                if (/*Validador.Validar(valor, -100, 100)*/Validador.Validar(valor,valorMinimo,valorMaximo))
                {
                    acumulador += valor;
                    if (valor > maximo)
                    {
                        maximo = valor;
                    }
                    else if (valor < minimo)
                    {
                        minimo = valor;
                    }
                    index++;
                }
                else
                {
                    Console.WriteLine("Error.");
                }
            }
            Console.WriteLine($"El numero mas grande es : {maximo} ");
            Console.WriteLine($"El numero mas chico: {minimo}");
            Console.WriteLine($"El numero promedio: {acumulador / index}");
            Console.ReadKey();
        }
    }
}
