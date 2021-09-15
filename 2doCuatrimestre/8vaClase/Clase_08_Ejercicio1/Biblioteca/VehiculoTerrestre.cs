using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class VehiculoTerrestre
    {
        public enum Colores
        {
            Rojo, Blanco, Azul, Gris, Negro
        }
        public short cantidadRuedas;
        public short cantidadPuertas;
        Colores color;
        public short cantidadMarchas;
        
        public VehiculoTerrestre(short cantidadRuedas,short cantidadPuertas,Colores color,short cantidadMarchas)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
            this.cantidadMarchas = cantidadMarchas;
            
        }
    }
}
