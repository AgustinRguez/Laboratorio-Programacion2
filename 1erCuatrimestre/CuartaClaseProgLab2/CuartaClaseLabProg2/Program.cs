using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace CuartaClaseLabProg2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SobreCarga 
            /*Console.WriteLine(Calculadora.Sumar(10, 20));
            Console.WriteLine(Calculadora.Sumar(10, 20, 30));
            Console.ReadKey(); //para nros */

            /*Persona personaUno = new Persona("Jesus");
            Persona personaDos = new Persona("Maria",666, "Perez");
            Console.WriteLine(Persona.MostrarPersona());*/ //manera statica de llamar con 'Persona'

            Metro metroUno = new Metro(10);
            Centimetro centimetroUno = new Centimetro(10);

            Metro sumaDeMetros;
            sumaDeMetros = metroUno+metroUno;

            Console.WriteLine(sumaDeMetros);//da 20
            int laSuma = (int)sumaDeMetros;
            Console.WriteLine(laSuma);//da 20
            
            //------------------------------------------------------------------------------------------------------------

            Centimetro sumaDeCentimetros = new Centimetro();

            sumaDeCentimetros = centimetroUno + sumaDeMetros; //con metroUno (valor 10) da 1010
            //sumaDeCentimetros = sumaDeMetros + centimetroUno; POSIBLE ERROR A TENER EN CUENTA
            Console.WriteLine(sumaDeCentimetros);

            centimetroUno.cantidadDeCentimetros = 20;
            sumaDeCentimetros.cantidadDeCentimetros = 20;
            if (centimetroUno == sumaDeCentimetros) 
            {
                Console.WriteLine("Son iguales");
            }
            if (centimetroUno != sumaDeCentimetros)
            {
                Console.WriteLine("Son distintos");
            }

            //Kilometros kUno = new Kilometros(6); constructor privado, no se puede acceder

            Kilometros unKilometro; //esto es para un constructor privado al cual no se le puede hacer new
            unKilometro = 100;

            //unKilometro =(Kilometros) 100; ESTO ES EXPLICITO
           

            Console.ReadKey();
        }
    }
}
