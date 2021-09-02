using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace EjercicioDiecisiete
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boliUno = new Boligrafo(ConsoleColor.Blue,5); 
            Boligrafo boliDos = new Boligrafo(ConsoleColor.Red, 50);
            string trazo;

            if(boliUno.Pintar(10,out trazo))
            {
                Console.ForegroundColor=boliUno.GetColor();
                Console.WriteLine(trazo);
            }
            if (boliDos.Pintar(20, out trazo))
            {
                Console.ForegroundColor = boliDos.GetColor();
                Console.WriteLine(trazo);
            }
            Console.ReadKey();
        }
    }
}
