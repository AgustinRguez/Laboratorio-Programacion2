using System;
using System.Text;
namespace Biblioteca
{
    public class Estudiante
    {
        private String apellido;
        private String legajo;
        private String nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }
        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }
        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }
        private float CalcularPromedio()
        {
            return (float)(notaPrimerParcial + notaSegundoParcial) /2;
        }
        public double CalcularNotaFinal()
        {
            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
                return random.Next(6, 11);
            else
                return -1;
        }
        public String Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            double notaFinal = CalcularNotaFinal();
            sb.AppendLine("Nombre: " + this.nombre + " Apellido: " + this.apellido + " Legajo: " + this.legajo);
            sb.AppendLine("1ra Nota: " + this.notaPrimerParcial + " 2da Nota: " + this.notaSegundoParcial); 
            sb.AppendLine("Promedio: " + this.CalcularPromedio());
            if(notaFinal != -1)
            {
                sb.AppendLine("Nota final: " + notaFinal);
            }
            else
            {
                sb.AppendLine("Alumno Desaprobado");
            }
            return sb.ToString();
        }
    }
}
