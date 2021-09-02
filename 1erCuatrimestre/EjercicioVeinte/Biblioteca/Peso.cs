using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Peso
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion
        #region Constructores
        static Peso()
        {
            Peso.cotizRespectoDolar = 66;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Peso.cotizRespectoDolar = cotizRespectoDolar;
        }
        #endregion
        #region Metodos
        public double getCantidad()
        {
            return this.cantidad;
        }
        public static double getCotizacion()
        {
            return Peso.cotizRespectoDolar;
        }
        public static explicit operator Dolar(Peso pesoUno)
        {
            Dolar dolarUno = new Dolar(pesoUno.cantidad / Dolar.getCotizacion());
            return dolarUno;
        }
        public static explicit operator Euro(Peso pesoUno)
        {
            return (Euro)(Dolar)pesoUno;
        }
        public static Peso operator +(Peso pesoUno, Euro euroUno)
        {
            Peso retornarPesos = new Peso(pesoUno.cantidad + ((Peso)euroUno).cantidad);
            return retornarPesos;
        }
        public static Peso operator +(Peso pesoUno, Dolar dolarUno)
        {
            Peso retornarPesos = new Peso(pesoUno.cantidad + ((Peso)dolarUno).cantidad);
            return retornarPesos;
        }
        public static Peso operator -(Peso pesoUno, Euro euroUno)
        {
            Peso retornarPesos = new Peso(pesoUno.cantidad - ((Peso)euroUno).cantidad);
            return retornarPesos;
        }
        public static Peso operator -(Peso pesoUno, Dolar dolarUno) 
        {
            Peso retornarPesos = new Peso(pesoUno.cantidad - ((Peso)dolarUno).cantidad);
            return retornarPesos;
        }
        public static bool operator ==(Peso pesoUno, Dolar dolarUno)
        {
            return pesoUno == ((Peso)dolarUno);
        }
        public static bool operator !=(Peso pesoUno, Dolar dolarUno)
        {
            return !(pesoUno == ((Peso)dolarUno));
        }
        public static bool operator ==(Peso pesoUno, Euro euroUno)
        {
            return pesoUno == ((Peso)euroUno);
        }
        public static bool operator !=(Peso pesoUno, Euro euroUno)
        {
            return !(pesoUno == ((Peso)euroUno));
        }
        #endregion
    }
}
