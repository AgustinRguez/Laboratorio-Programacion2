using System;
using Entidades;
namespace Clase_07_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente(1,"YO");
            Cliente c2 = new Cliente(2,"SUPER YO");
            Cliente c3 = new Cliente(3,"ULTRA BALL (?");
            Negocio n1 = new Negocio("LALA");
            if (n1 + c1)
            {
                Console.WriteLine("Se agrego c1");
            }
            if (!(n1 + c1))
            {
                Console.WriteLine("c1 ya esta");
            }
            if (n1 + c2)
            {
                Console.WriteLine("Se agrego c2");
            }
            if (n1 + c3)
            {
                Console.WriteLine("Se agrego c3");
            }
            Console.WriteLine("Clientes pendientes: {0}", n1.ClientePendiente);
            while (~n1)
            {
                Console.WriteLine("Clientes pendientes: {0}", n1.ClientePendiente);
            }
        }
    }
}
