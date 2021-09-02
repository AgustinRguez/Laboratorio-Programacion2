using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class FacturaB:Factura
    {
        public FacturaB(string nombreCliente, string numeroDeCuit) : base(nombreCliente, numeroDeCuit)
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
            return base.RetornarNumeroDeCuit();// esto es llamar a la funcionalidad del base, aparece por defecto

            // return this.numeroDeCuit; // si no se modifica se usa el base, sino, este.
            // return this.RetornarNumeroDeCuit(); Llamada ciclica, podria ser un overflow exception
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
