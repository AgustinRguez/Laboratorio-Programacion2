using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Documento
    {
        protected string nombreDeCliente;
        protected string numeroDeCuit;

        public abstract string RetornarNombreYCuit(); // no tienen implementacion
        
        public abstract string NombreYCuit // propiedad abstracta
        {
            get;
            set;
        }
        
    }
}
