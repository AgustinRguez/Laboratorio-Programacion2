using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion):this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return productos;
        }
        public static string MostrarEstante(Estante e)
        {
            //return $"{e.productos} {e.ubicacionEstante}";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ubicacion: {e.ubicacionEstante}");
            for (int i = 0; i < e.productos.Length; i++)
            {
                if(!(e.productos[i] is null)) // no se usa != xq no se compara Estante con producto y esta sobrecargado
                {
                    sb.AppendLine(Producto.Mostrar(e.productos[i]));
                }
            }
            return sb.ToString();
        }
        public static bool operator ==(Estante e1, Producto p1)
        {
            for (int i = 0; i < e1.productos.Length; i++)
            {
                if (e1.productos[i] == p1)
                    return true;
            }
            /*if (e1.productos.Contains(p1))
            {
                return true;
            }
            else
            {
                return false;
            }*/
            return false;
        }
        public static bool operator !=(Estante e1, Producto p1)
        {
            return !(e1 == p1);
        }

        public static bool operator +(Estante e1, Producto p1)
        {
            if(e1 != p1) // ver si no esta el prod en el estante reutilizando el !=
            {
                for (int i = 0; i < e1.productos.Length; i++)
                {
                    if(e1.productos[i] is null) // verifica si en la posicion de i hay espacio para almacenar 
                    {
                        e1.productos[i] = p1;
                        return true;
                    }
                }
            }
            return false;
        }
        public static Estante operator -(Estante e1, Producto p1)
        {
            if (e1 == p1) // ver si esta
            {
                for (int i = 0; i < e1.productos.Length; i++)
                {
                    if(e1.productos[i] == p1)
                    e1.productos[i] = null;
                    break;
                }
            }
            return e1;
        }
    }
}
