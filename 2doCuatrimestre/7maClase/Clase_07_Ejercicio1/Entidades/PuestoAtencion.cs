using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Entidades
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,Caja2
        }
        private static int numeroActual;
        private Puesto puesto;

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public bool Atender(Cliente cli)
        {
            if(!(cli is null))
            {
                Thread.Sleep(2000);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int NumeroActual
        {
            get
            {
                PuestoAtencion.numeroActual ++;
                return numeroActual;
            }
        }
    }
}
