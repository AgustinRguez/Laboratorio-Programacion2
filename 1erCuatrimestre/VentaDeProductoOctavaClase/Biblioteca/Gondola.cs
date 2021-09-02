using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Gondola
    {
        private List<Producto> listaProductos;

        public Gondola()
        {
            this.listaProductos = new List<Producto>();
        }
        public Gondola(List<Producto> listaProductosParam)
        {
            this.listaProductos = listaProductosParam;
        }

        public Producto this[int i] // indexador que devuelve un producto
        {
            get
            {
                return this.listaProductos[i];
            }
            set
            {
                this.listaProductos.Add(value);
            }
        }
    }
}
