using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Euro
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion
        #region Constructores
        static Euro()
        {
            Euro.cotizRespectoDolar = 1 / 1.08f;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizRespectoDolar): this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizRespectoDolar;
        }
        #endregion
        #region Metodos
        public double getCantidad()
        {
            return this.cantidad;
        }
        
        public static double getCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public static explicit operator Dolar(Euro euroUno)
        {
            Dolar dolarUno = new Dolar((euroUno.cantidad / Euro.getCotizacion()));
            return dolarUno;
        }
        public static explicit operator Peso(Euro euroUno)
        {
            return (Peso)((Dolar)euroUno);
        }
        public static Euro operator +(Euro euroUno, Peso pesoUno)
        {
            Euro retornarEuros = new Euro(euroUno.cantidad + ((Euro)pesoUno).cantidad);
            return retornarEuros;
        }
        public static Euro operator +(Euro euroUno, Dolar dolarUno)
        {
            Euro retornarEuros = new Euro(euroUno.cantidad + ((Euro)dolarUno).cantidad);
            return retornarEuros;
        }
        public static Euro operator -(Euro euroUno, Peso pesoUno)
        {
            Euro retornarEuros = new Euro(euroUno.cantidad - ((Euro)pesoUno).cantidad);
            return retornarEuros;
        }
        public static Euro operator -(Euro euroUno, Dolar dolarUno)
        {
            Euro retornarEuros = new Euro(euroUno.cantidad - ((Euro)dolarUno).cantidad);
            return retornarEuros;
        }
        public static bool operator ==(Euro euroUno, Euro euroDos)
        {
            return (euroUno.cantidad == euroDos.cantidad);
        }
        public static bool operator !=(Euro euroUno, Euro euroDos)
        {
            return !(euroUno.cantidad == euroDos.cantidad);
        }
        public static bool operator ==(Euro euroUno, Dolar dolarUno)
        {
            return euroUno == ((Euro)dolarUno);
        }
        public static bool operator !=(Euro euroUno, Dolar dolarUno)
        {
            return !(euroUno == (Euro)dolarUno);
        }
        public static bool operator ==(Euro euroUno, Peso pesoUno)
        {
            return euroUno == ((Euro)pesoUno);
        }
        public static bool operator !=(Euro euroUno, Peso pesoUno)
        {
            return !(euroUno == (Euro)pesoUno);
        }
        #endregion
    }
}
