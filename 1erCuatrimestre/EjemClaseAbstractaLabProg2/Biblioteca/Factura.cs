using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Factura : Documento
    {
        protected string nombreCliente;
        protected float importeFinal;
        protected int numeroDeFactura;
        protected string numeroDeCuit;
        public Factura(string nombreCliente, string numeroDeCuit)
        {
            this.nombreCliente = nombreCliente;
            this.numeroDeCuit = numeroDeCuit;
        }
        public string NombreCliente
        {
            get
            {
                return this.nombreCliente;
            }
            set
            {
                this.nombreCliente = value;
            }
        }
        public float Importe
        {
            get
            {
                return this.importeFinal;
            }
            set
            {
                this.importeFinal = value;
            }
        }
        public abstract int NumeroDeFactura
        {
            get;
            //da error por ahora, estaria faltando implementarlas en las clases heredada
            set;
        }
        public abstract string RetonarDatosCompletos(); // no tienen implementacion
        public string RetornarDatosClientes()
        {
            return this.nombreCliente;
        }

        public abstract string NumeroDeCuit(); // no tienen implementacion
      
        public virtual string RetornarNumeroDeCuit() // metodo que tiene implementacion
        {
            return this.NumeroDeCuit();
        }
        
    }
}
