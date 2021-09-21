using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rectangulo : Figura
    {
        private double bas;
        private double altura;

        public Rectangulo(double bas, double altura)
        {
            this.bas = bas;
            this.altura = altura;
        }
        public override string Dibujar()
        {
            return "Dibujando rectangulo";
        }
        public override double CalcularPerimetro()
        {
            return bas + altura * 2;
        }

        public override double CalcularSuperficie()
        {
            return bas * altura;
        }
    }
}
