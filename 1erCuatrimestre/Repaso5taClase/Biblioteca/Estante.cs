using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estante
    {
        #region Atributos
        private int ubicacionEstante;
        private Producto[] productos;
        #endregion
        #region Constructores
        private Estante(int capacidad)
        {
            //El constructor de instancia privado será el único que inicializará el array.
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion): this (capacidad) // inicia al objeto e instancia al otro constructor
        {
            //La sobrecarga pública del constructor inicializará la ubicación del estante,
            //recibiendo como parámetro capacidad y ubicación.
            this.ubicacionEstante = ubicacion;
        }
        #endregion
        #region Metodos
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante estanteAMostrar)
        {
            //object.referenceEquals (para comparar objetos)
            int i = 0;
            StringBuilder sb = new StringBuilder();
            if (!(estanteAMostrar is null))
            {
                foreach (Producto auxProducto in estanteAMostrar.GetProductos())
                {
                    sb.AppendFormat("Producto {0}: {1}\n", i+1,Producto.mostrarProducto(auxProducto));
                    i++;
                }
            }
            return sb.ToString();
        }
        public static bool operator ==(Estante estanteUno, Producto productoUno)
        {
          foreach (Producto produAComparar in estanteUno.productos)
          {
              if((!(produAComparar is null))  && produAComparar == productoUno)
              return true;
          }
            return false;     
        }
        public static bool operator !=(Estante estanteUno, Producto productoUno)
        {
            return !(estanteUno == productoUno);
        }
        public static bool operator +(Estante estanteUno, Producto productoUno)
        {
            if (estanteUno != productoUno)
            {
                for (int i = 0; i < estanteUno.productos.Length; i++)
                {
                    if(estanteUno.productos[i] is null)
                    {
                        estanteUno.productos[i] = productoUno;
                        return true;
                    }
                }
            }
            return false;
        }
        public static Estante operator -(Estante estanteUno, Producto productoUno)
        {
            if((!(estanteUno is null))  && (!(productoUno is null)))
            {
                for (int i = 0; i < estanteUno.productos.Length; i++)
                {
                    if(!(estanteUno.productos[i] is null))
                    {
                        productoUno = null;
                        break;
                    }
                }
            }
            return estanteUno;
        }
        #endregion
    }
}
