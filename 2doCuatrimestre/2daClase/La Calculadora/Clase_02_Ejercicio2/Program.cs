using System;
using Biblioteca;
namespace Clase_02_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion;
            float numeroUno=0;
            float numeroDos=0;
            float resultado = 0;
            Console.WriteLine("Ingrese el primer numero: ");
            numeroUno = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero ");
            numeroDos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la opcion/operador (+|-|*|/) para la cuenta: ");
            opcion = char.Parse(Console.ReadLine());
            switch (opcion)
            {
                case '+':
                    resultado = Calculadora.Calcular(numeroUno, numeroDos, '+');
                    Console.WriteLine("La suma es: " + resultado);
                    break;
                case '-':
                    resultado = Calculadora.Calcular(numeroUno, numeroDos, '-');
                    Console.WriteLine("La resta es: " + resultado);
                    break;
                case '*':
                    resultado = Calculadora.Calcular(numeroUno, numeroDos, '*');
                    Console.WriteLine("La multiplicacion es: " + resultado);
                    break;
                case '/':
                    if (numeroDos == 0)
                    {
                        Console.WriteLine("No se puede dividir por 0.");
                    }
                    else
                    {
                        resultado = Calculadora.Calcular(numeroUno, numeroDos, '/');
                        Console.WriteLine("La division es: " + resultado);
                    }
                    break;
            }
                Console.ReadKey();
        }
    }
}
