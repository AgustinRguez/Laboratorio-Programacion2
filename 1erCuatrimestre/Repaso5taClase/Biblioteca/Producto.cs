using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        #region Atributos
        private string codigoDeBarra; // se nombrara en la conversion explicita
        private string marca;
        private float precio;
        #endregion
        #region Constructores
        public Producto(string codigoDeBarraParam, string marcaParam, float precioParam)
        {
            this.codigoDeBarra = codigoDeBarraParam;
            this.marca = marcaParam;
            this.precio = precioParam;
        }
        #endregion
        #region Metodos
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static string mostrarProducto(Producto productoAMostrar)
        {
            int i = 0;
            StringBuilder sb = new StringBuilder();
            if (!(productoAMostrar is null))
            {
                for(i = 0; i<2;i++) 
                {
                    sb.AppendLine("Codigo de barra: " + productoAMostrar.GetMarca());
                    sb.AppendLine("Marca: " + productoAMostrar.codigoDeBarra);
                    sb.AppendLine("Precio: " + productoAMostrar.GetPrecio());
                    i++;
                }
            }
            return sb.ToString();

        }
        //Explícito. Realizará la conversión de un objeto Producto a string. Sólo retornará el atributo codigoDeBarras del producto.
        public static explicit operator string(Producto productoUno)
        {
            return productoUno.codigoDeBarra;
        }
        //Igualdad (Producto, Producto). Retornará true, si las marcas y códigos de barras son iguales, false, caso contrario.
        public static bool operator ==(Producto productoUno, Producto productoDos)
        {
            if ((!(productoUno is null)) && (!(productoDos is null)))
            {
                if (productoUno.marca == productoDos.marca && productoUno.codigoDeBarra == productoDos.codigoDeBarra)
                {
                    return true;
                }
            }
                 return false;
        }
        public static bool operator !=(Producto productoUno, Producto productoDos)
        {
            return !(productoUno == productoDos);
        }
        //Igualdad (Producto, string). Retornará true, si la marca del producto coincide con la cadena pasada por parámetro, o false
        public static bool operator ==(Producto productoUno, string marcaProducto)
        {
            if (productoUno.marca == marcaProducto)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Producto productoUno, string marcaProducto)
        {
            return !(productoUno.marca == marcaProducto);
        }
        #endregion
    }
}
