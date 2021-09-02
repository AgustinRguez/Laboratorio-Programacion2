using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
namespace EjercicioVeintinueve
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(2, "utn"); // la lista es solo de dos elementos si cambia a 3 se agrega el ultimo
            Jugador j1 = new Jugador(123, "nom1", 5, 20);
            Jugador j2 = new Jugador(485, "nom2", 3, 5);
            Jugador j3 = new Jugador(123, "nom3", 7, 3);
            Jugador j4 = new Jugador(789, "nom4", 3, 5);

            if (equipo + j1)

                Console.WriteLine(j1.Mostrar());

            else
                Console.WriteLine("NO SE AGREGO " + j1.Mostrar());


            if (equipo + j2)

                Console.WriteLine(j2.Mostrar());

            else
                Console.WriteLine("NO SE AGREGO " + j2.Mostrar());


            if (equipo + j3)
                Console.WriteLine(j3.Mostrar());
            else
                Console.WriteLine("NO SE AGREGO " + j3.Mostrar());

            if (equipo + j4)

                Console.WriteLine(j4.Mostrar());

            else

                Console.WriteLine("NO SE AGREGO " + j4.Mostrar());


            Console.ReadKey();
        }
    }
}
