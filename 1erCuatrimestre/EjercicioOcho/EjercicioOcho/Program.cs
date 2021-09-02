using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioOcho
{
    class Program
    {
        static void Main(string[] args)
        {
            int empleados = 2;
            int valorHora;
            string nombre;
            int antiguedad;
            int cantidadDeHoras;
            int importeACobrar;
            float descuentos;
            int totalDescuento;
                for (int i = 0; i < empleados; i++)
                {
                    Console.WriteLine("Escriba el valor de hora: ");
                    int.TryParse(Console.ReadLine(), out valorHora);
                    Console.WriteLine("Escriba el nombre: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Escriba la antiguedad: ");
                    int.TryParse(Console.ReadLine(), out antiguedad);
                    Console.WriteLine("Escriba la cantidad de horas: ");
                    int.TryParse(Console.ReadLine(), out cantidadDeHoras);   
                         importeACobrar = (valorHora * cantidadDeHoras) + (antiguedad * 150);
                         descuentos = importeACobrar - (importeACobrar * 13) / 100;
                         totalDescuento = (importeACobrar * 13) / 100;
                Console.WriteLine("--------------------------------------------------------------------------------");

                Console.WriteLine("La Antiguedad (Se lo multiplica por $150 cada año): {0}", antiguedad);
                         Console.WriteLine("El valor de las horas: ${0}", valorHora);
                         Console.WriteLine("La cantidad de horas: {0}", cantidadDeHoras);

                Console.WriteLine("--------------------------------------------------------------------------------");

                         Console.WriteLine("importe a cobrar en bruto: ${0}", importeACobrar);
                         Console.WriteLine("El neto con descuento de 13% es de: ${0:#.#}", descuentos);
                         Console.WriteLine("La cantidad que se descuenta es: ${0}", totalDescuento);  
                         Console.ReadKey();
                Console.WriteLine("--------------------------------------------------------------------------------");

            }
        }
    }
}
