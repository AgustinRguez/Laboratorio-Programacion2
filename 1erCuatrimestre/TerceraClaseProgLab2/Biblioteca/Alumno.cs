using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Alumno
    {
        private byte notaUno;
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
            if(this.notaUno >= 4 && this.notaDos >= 4)
            {
                this.notaFinal = notaRandom.Next(6, 10);
            }

        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            //Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
            this.notaUno = notaUno;
            this.notaDos = notaDos;
        }
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Nombre: " + nombre);
            stringBuilder.AppendLine("Apellido: " + apellido);
            stringBuilder.AppendLine("Legajo: " + legajo);
            stringBuilder.AppendLine("Nota1: " + notaUno);
            stringBuilder.AppendLine("Nota2: " + notaDos);
            if(notaFinal != -1)
            {
                stringBuilder.AppendLine("Nota final: " + notaFinal);
            }
            else
            {
                stringBuilder.AppendLine("Alumno Desaprobado.");
            }
            return stringBuilder.ToString();
        }

    }
}
