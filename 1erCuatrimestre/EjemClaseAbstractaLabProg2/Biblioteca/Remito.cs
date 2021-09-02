using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Remito : Documento // puede ser sealed xq no tiene devolucion, puede ser destruido
    {
        public override string NombreYCuit
        { 
            get 
            { 
                return $"Nombre : {base.nombreDeCliente}  Dni: {base.numeroDeCuit}";
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
