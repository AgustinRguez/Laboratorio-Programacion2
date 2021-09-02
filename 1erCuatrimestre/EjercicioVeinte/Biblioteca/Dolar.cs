using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Dolar
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion
        #region Constructores
        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizRespectoDolar;
        }
        #endregion
        #region Metodos
        public double getCantidad()
        {
            return this.cantidad;
        }
        public static double getCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public static explicit operator Euro(Dolar dolarUno)
        {
            Euro euroUno = new Euro((dolarUno.cantidad * Euro.getCotizacion()));
            return euroUno;
        }
        public static explicit operator Peso(Dolar dolarUno)
        {
            Peso pesoUno = new Peso((dolarUno.cantidad * Peso.getCotizacion()));
            return pesoUno;
        }
        public static Dolar operator +(Dolar dolarUno, Peso pesoUno)
        {
            Dolar retornarDolar = new Dolar(dolarUno.cantidad + ((Dolar)pesoUno).cantidad);
            return retornarDolar;
        }
        public static Dolar operator +(Dolar dolarUno, Euro euroUno)
        {
            Dolar retornarDolar = new Dolar(dolarUno.cantidad + ((Dolar)euroUno).cantidad);
            return retornarDolar;
        }
        public static Dolar operator -(Dolar dolarUno, Peso pesoUno)
        {
            Dolar retornarDolar = new Dolar(dolarUno.cantidad - ((Dolar)pesoUno).cantidad);
            return retornarDolar;
        }
        public static Dolar operator -(Dolar dolarUno, Euro euroUno)
        {
            Dolar retornarDolar = new Dolar(dolarUno.cantidad - ((Dolar)euroUno).cantidad);
            return retornarDolar;
        }
        public static bool operator ==(Dolar dolarUno, Peso pesoUno)
        {
            return dolarUno == ((Dolar)pesoUno);
        }
        public static bool operator !=(Dolar dolarUno, Peso pesoUno)
        {
            return !(dolarUno == (Dolar)pesoUno);
        }
        public static bool operator ==(Dolar dolarUno, Euro euroUno)
        {
            return dolarUno == ((Dolar)euroUno);
        }
        public static bool operator !=(Dolar dolarUno, Euro euroUno)
        {
            return !(dolarUno == (Dolar)euroUno);
        }
        #endregion
    }
}
