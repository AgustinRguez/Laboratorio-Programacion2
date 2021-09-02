using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class FacturaABaja : FacturaA 
        //tengo que hacerle un constructor con dos parametros sino da error esto es restriccion de herencia
    {
        public FacturaABaja(string nombreDeCliente, string numeroDeCuit): base(nombreDeCliente,numeroDeCuit)
        {

        }
        public override DateTime DameFechaFactura()
        {
            return base.DameFechaFactura();
        }
    }
}
