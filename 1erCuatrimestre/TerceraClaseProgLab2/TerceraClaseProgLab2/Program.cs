using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace TerceraClaseProgLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 16
            Alumno alumUno = new Alumno("Agus","lala",10);
            Alumno alumDos = new Alumno("Troy", "lala", 20);
            Alumno alumTres = new Alumno("Mclarure", "lala", 30);

            alumUno.Estudiar(5, 9);
            alumDos.Estudiar(2, 3);
            alumTres.Estudiar(6, 9);

            alumUno.CalcularFinal();
            alumDos.CalcularFinal();
            alumTres.CalcularFinal();

            Console.WriteLine(alumUno.Mostrar());
            Console.WriteLine(alumDos.Mostrar());
            Console.WriteLine(alumTres.Mostrar());
            Console.ReadKey();
        }
    }
}
