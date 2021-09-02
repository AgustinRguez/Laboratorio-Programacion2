using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private string nombre;
        List<Jugador> jugadores;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidadParam, string nombreParam): this()
        {
            this.cantidadDeJugadores = cantidadParam;
            this.nombre = nombreParam;
        }
        public static bool operator +(Equipo equipoParam, Jugador jugadorParam)
        {
            if( equipoParam.jugadores.Count < equipoParam.cantidadDeJugadores )
            {
                foreach (Jugador item in equipoParam.jugadores)
                {
                    if(item == jugadorParam) // se usa sobrecarga de jugador si son el mismo que retorne false
                    {
                        return false;
                    }
                }
                equipoParam.jugadores.Add(jugadorParam);
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
