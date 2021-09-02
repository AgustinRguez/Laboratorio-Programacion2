using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeptimaClaseProgLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // LIST

            /* List<string> personas = new List<string>();
             personas.Add("jose");
             personas.Add("lolo");
             personas.Add("lala");
             personas.Add("agus");
             foreach (string item in personas)
             {
                 Console.WriteLine(item);
             }
             personas.Remove("agus");
             foreach (string item in personas)
             {
                 Console.WriteLine(item);
             }
             Console.ReadKey();*/

            //QUEUE COLA

            /*Queue<string> personas = new Queue<string>();
            personas.Enqueue("lalal");
            personas.Enqueue("lelel");
            personas.Enqueue("lolol");
            Console.WriteLine(personas.Dequeue());
            Console.WriteLine(personas.Dequeue());
            Console.WriteLine(personas.Dequeue());
            Console.ReadKey();*/

            // Dictionary

            /* Dictionary<string, int> diccionario = new Dictionary<string, int>();
             diccionario.Add("lalala", 11);
             diccionario.Add("yo", 1);
             diccionario.Add("yoni", 400);
             diccionario.Remove("lalala");

             foreach (KeyValuePair<string,int> item in diccionario)
             {
                 Console.WriteLine(diccionario["yo"]);
                 Console.WriteLine(diccionario["yoni"]);
             }
             Console.ReadKey();*/

            //STACK PILA

            /* Stack<string> stack = new Stack<string>();
             stack.Push("alumno40");
             stack.Push("alumno32");
             stack.Push("alumno20");
             //stack.Pop();
             //stack.Peek();
             Console.WriteLine(stack.Peek());
             Console.WriteLine(stack.Peek());
             Console.WriteLine(stack.Peek()); 
             Console.ReadKey();*/

            // EL 26 CON LIST

            List<int> listaNumeros = new List<int>();
            Random numerosRan = new Random();
            for(int i=0; i < 20; i++)
            {
                listaNumeros.Add(numerosRan.Next(-10, 100));       
            }
            foreach (int item in listaNumeros) // muestra
            {
                if (item != 0)
                {
                    Console.WriteLine(item);
                }
                
            }

            //Ordenada
            Console.WriteLine("Ordenar");
            listaNumeros.Sort(Program.Ordenar);
            foreach (int item in listaNumeros)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            // EL 26 CON COLA
            //FALTA ESTO Y CON PILA


        }
        public static int Ordenar(int num1, int num2)
        {
            
            if (num1 > num2)
            {
                return -1;
            }
            else if(num2>num1)
            {
                return 1;
            }
            return 0;
        }
        
    }
}
