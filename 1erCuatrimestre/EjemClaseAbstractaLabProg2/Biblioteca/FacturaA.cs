using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class FacturaA : Factura
    {
        private float importeSinIVA;

        public FacturaA(string nombreCliente, string numeroDeCuit) : base(nombreCliente, numeroDeCuit)
        {

        }
        public float ImporteSinIVA
        {
            get
            {
                return this.importeSinIVA;
            }
            set
            {
                this.importeSinIVA = value;
            }
        }

        public override int NumeroDeFactura 
        {
            get { return this.numeroDeFactura; }
            set { this.numeroDeFactura = value; }
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

        public override string NumeroDeCuit()
        {
            return base.numeroDeCuit;
        }

        public override string RetonarDatosCompletos()
        {
            return this.RetonarDatosCompletos();
        }
        public override string RetornarNumeroDeCuit()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Factura A: " + base.RetornarNumeroDeCuit());
            return sb.ToString();
        }
        public virtual DateTime DameFechaFactura()
        {
            return DateTime.Now;
        }
        public override string RetornarNombreYCuit()
        {
            return this.NombreYCuit;
        }
    } 
}
