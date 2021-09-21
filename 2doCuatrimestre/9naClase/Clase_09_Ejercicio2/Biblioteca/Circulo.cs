using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
   
    public sealed class Circulo : Figura
    {
        public double radio;

        public Circulo(double radio)
        {
            this.radio = radio;     
        }
        public override string Dibujar()
        {
            return "Dibujando circulo";
        }
        public override double CalcularPerimetro()
        {
            return Math.PI * radio * 2;
        }

        public override double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
