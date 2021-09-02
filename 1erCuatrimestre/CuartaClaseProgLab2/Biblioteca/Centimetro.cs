using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Centimetro
    {
        #region Atributos
        public double cantidadDeCentimetros;
        #endregion

        #region Constructores
        public Centimetro()
        {
            this.cantidadDeCentimetros = 0;
        }
        public Centimetro(double cantidad)
        {
            this.cantidadDeCentimetros = cantidad;
        }

        #endregion

        #region Metodos
        public static Centimetro operator +(Centimetro centimetroUno, Metro metroUno)
        {
            Centimetro retornarCentimetro = new Centimetro();
            retornarCentimetro.cantidadDeCentimetros = (centimetroUno.cantidadDeCentimetros + (metroUno.cantidadDeMetros * 100));
            return retornarCentimetro;
        }
        public static explicit operator double(Centimetro centimetroUno) //ya es doble, explicita perdida de datos, si casteo de double a entero pierdo datos
        {
            return centimetroUno.cantidadDeCentimetros;
        }
        public static implicit operator int(Centimetro centimetroUno) //implicita no hay perdida de datos si casteas de entero a double paso de una memoria mas chica a grande y entra
        {
            return (int)centimetroUno.cantidadDeCentimetros;
        }
        public static bool operator ==(Centimetro centimetroUno, Centimetro centimetroDos)
        {
            return centimetroUno.cantidadDeCentimetros == centimetroDos.cantidadDeCentimetros;
        }
        public static bool operator !=(Centimetro centimetroUno, Centimetro centimetroDos)
        {
            return !(centimetroUno == centimetroDos); //ya esta definido en el ==, seria redundante poner el cantidad de centimetros
        }
        #endregion
    }
}
