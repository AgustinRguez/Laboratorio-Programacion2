using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int cantidadPartidosJugados;
        private float promedioDeGoles;
        private int totalGoles;

        private Jugador()
        {
            this.cantidadPartidosJugados = 0;
            this.promedioDeGoles = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dniParam, string nombreParam) : this()
        {
            this.dni = dniParam;
            this.nombre = nombreParam;
        }
        public Jugador(int dniParam, string nombreParam, int totalGolesParam, int cantidadPartidosParam) : this(dniParam, nombreParam)
        {
            this.totalGoles = totalGolesParam;
            this.cantidadPartidosJugados = cantidadPartidosParam;
        }
        public float GetPromedioGoles()
        {
            return promedioDeGoles = cantidadPartidosJugados / totalGoles;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dni: " + this.dni.ToString());
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("partidos jugador: " + this.cantidadPartidosJugados.ToString());
            sb.AppendLine("Promedio goles: " + this.GetPromedioGoles().ToString());
            sb.AppendLine("total goles: " + this.totalGoles.ToString());
            return sb.ToString();
        }
        public static bool operator ==(Jugador jugadorUno, Jugador jugadorDos)
        {
            if(jugadorUno.dni == jugadorDos.dni)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Jugador jugadorUno, Jugador jugadorDos)
        {
            return !(jugadorUno == jugadorDos);
        }
    }
}
