using System;

namespace Biblioteca
{
    public class Automovil : VehiculoTerrestre
    {
        public int cantidadPasajeros;
        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros) 
            :base(cantidadRuedas,cantidadPuertas,color,cantidadMarchas)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}
