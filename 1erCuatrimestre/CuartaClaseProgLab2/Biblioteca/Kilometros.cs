using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Kilometros
    {
        public double cantidadKilometros;

        private Kilometros(double cantidadKm) 
        {
            this.cantidadKilometros = cantidadKm;
        }
        /// <summary>
        /// Recibe un numero y retorna un kilometro
        /// </summary>
        /// <param name="numero"></param>
        public static implicit operator Kilometros(int numero) //implicita no hay perdida de datos
        {
            Kilometros kilometroUno = new Kilometros(numero);
            return kilometroUno;
        }
    }
}
