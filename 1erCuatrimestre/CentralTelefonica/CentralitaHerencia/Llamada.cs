using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public enum TipoLlamada
        {
            Local,Provincial,Todas
        }

        public Llamada(float duracionParam, string nroDestinoParam, string nroOrigenParam)
        {
            this.duracion = duracionParam;
            this.nroDestino = nroDestinoParam;
            this.nroOrigen = nroDestinoParam;
        }

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        public static int OrdenarPorDuracion(Llamada llamadaUno, Llamada llamadaDos)
        {
            int returnAux = 0;
            if(llamadaUno.duracion < llamadaDos.duracion)
            {
                returnAux = -1;
            }
            else if(llamadaUno.duracion < llamadaDos.duracion)
            {
                returnAux = 1;
            }
            return returnAux;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion: " + this.duracion);
            sb.AppendLine("Nro Destino: " + this.nroDestino);
            sb.AppendLine("Nro Origen: " + this.nroOrigen);
            
            return sb.ToString();
        }
    }
}
