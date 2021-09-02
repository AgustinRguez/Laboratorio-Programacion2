using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class FacturaC : Factura
    {
        public FacturaC() : base("Natalia Natalia", "1111")
        {

        }
        public FacturaC(string nombreCliente, string numeroDeCuit ) : base(nombreCliente, numeroDeCuit)
        {
          
        }
        public override int NumeroDeFactura 
        {
            get { return this.numeroDeFactura; }
            set { this.numeroDeFactura = value; }
        }
        public override string RetonarDatosCompletos()
        {
            return this.RetonarDatosCompletos();
        }
        public override string NumeroDeCuit()
        {
            return base.numeroDeCuit;
        }
        public override string RetornarNumeroDeCuit()
        {
            return "Factura C Cuit: " + this.numeroDeCuit;//
        }
        public override string NombreYCuit
        {
            get
            {
                return $"Nombre :  + {base.nombreDeCliente}  Dni: {base.numeroDeCuit}";
            }
            set
            {

            }
        }
        public override string RetornarNombreYCuit()
        {
            return this.NombreYCuit;
        }
    }
}
