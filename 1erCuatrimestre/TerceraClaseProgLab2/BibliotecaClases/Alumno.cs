using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    class Alumno
    {
        private byte notaUna;
        private byte notaDos;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void CalcularFinal()
        {
            Random notaRandom = new Random();
            this.notaFinal = -1;

            

        }
        public void Estudiar(byte notaUna, byte notaDos)
        {

        }
        public string Mostrar()
        {
            return Console.ReadLine();
        }
    }
}
