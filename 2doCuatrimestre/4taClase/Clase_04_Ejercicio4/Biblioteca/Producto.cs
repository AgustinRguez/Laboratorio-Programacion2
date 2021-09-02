using System;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static string Mostrar(Producto producto)
        {
            return $"Codigo: {producto.codigoDeBarra} Marca: {producto.marca} Precio: {string.Format("{0:N2}",producto.precio)}";
        }
        public static explicit operator string(Producto producto)
        {
            return $"{producto.codigoDeBarra}";
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            if(!(p1 is null || p2 is null))
            {
                if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p1, string marca)
        {
            if(p1.marca == marca)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1.marca == marca);
        }
    }
}
