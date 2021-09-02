using System;
using Biblioteca;
namespace Clase_03_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudianteUno = new Estudiante("goku", "555", "goku");
            Estudiante estudianteDos = new Estudiante("Ligth", "555", "Yagami");
            Estudiante estudianteTres = new Estudiante("Seiya", "555", "Seiya");
            estudianteUno.SetNotaPrimerParcial(4);
            estudianteUno.SetNotaSegundoParcial(4);
            estudianteDos.SetNotaPrimerParcial(5);
            estudianteDos.SetNotaSegundoParcial(9);
            estudianteTres.SetNotaPrimerParcial(2);
            estudianteTres.SetNotaSegundoParcial(3);
            Console.WriteLine("1er Estudiante: " + estudianteUno.Mostrar());
            Console.WriteLine("2do Estudiante: " + estudianteDos.Mostrar());
            Console.WriteLine("3er Estudiante: " + estudianteTres.Mostrar());
            Console.ReadKey();
        }
    }
}
