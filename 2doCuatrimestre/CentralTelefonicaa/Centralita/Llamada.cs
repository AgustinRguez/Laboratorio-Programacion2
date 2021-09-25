using System;
using System.Collections.Generic;
using System.Text;

namespace Centralita
{
    public abstract class Llamada
    {
        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino,
            string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        public abstract float CostoLlamada { get; }
        public float Duracion
        {
            get
            {
                return duracion;
            }            
        }
        public string NroDestino
        {
            get
            {
                return nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return nroOrigen;
            }
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int returnAux = 0;
            if(llamada1 is not null && llamada2 is not null)
            {
                if(llamada1.duracion < llamada2.duracion)
                {
                    returnAux = -1;
                }
                else if (llamada1.duracion > llamada2.duracion)
                {
                    returnAux = 1;
                }
            }
            return returnAux;
        }
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {Duracion} NroDestino: {NroDestino} NroOrigen: {NroOrigen}");
            return sb.ToString();
        }
        public static bool operator ==(Llamada llamada1,Llamada llamada2)
        {
            if (llamada1.Equals(llamada2) && llamada1.nroDestino == llamada2.nroDestino &&
                llamada1.nroOrigen == llamada2.nroOrigen)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return (!(llamada1 == llamada2));
        }
    }
}
