using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
namespace EjercicioVeinte
{
    class Program
    {
        static void Main(string[] args)
        {
            Euro euroUno = new Euro(10,1.8);
            Dolar dolarUno = new Dolar(10);
            Peso pesoUno = new Peso(1,66);

            Dolar sumaDeDolares;
            sumaDeDolares = dolarUno + euroUno;
            Console.WriteLine("Cantidad total de dolares convirtiendo los euros a cotizacion $1.8: " +sumaDeDolares.getCantidad());
            sumaDeDolares = dolarUno + pesoUno;
            Console.WriteLine("Cantidad total de dolares convirtiendo los pesos a cotizacion $66: " + sumaDeDolares.getCantidad());
            Console.WriteLine("-------------------------------------------------------");

            Euro sumaDeEuros;
            sumaDeEuros = euroUno + dolarUno;
            Console.WriteLine("Cantidad total de euros convirtiendo los dolares a cotizacion $1.8: " + sumaDeEuros.getCantidad());
            sumaDeEuros = euroUno + pesoUno;
            Console.WriteLine("Cantidad total de euros convirtiendo los pesos a cotizacion $66: " + sumaDeEuros.getCantidad());
            Console.WriteLine("-------------------------------------------------------");

            Peso sumaDePesos;
            sumaDePesos = pesoUno + dolarUno;
            Console.WriteLine("Cantidad total de euros convirtiendo los dolares a cotizacion $1.8: " + sumaDePesos.getCantidad());
            sumaDePesos = pesoUno + euroUno;
            Console.WriteLine("Cantidad total de euros convirtiendo los pesos a cotizacion $66: " + sumaDePesos.getCantidad());
            Console.WriteLine("-------------------------------------------------------");
            Console.ReadKey();
            //falta comparaciones
        }
    }
}
