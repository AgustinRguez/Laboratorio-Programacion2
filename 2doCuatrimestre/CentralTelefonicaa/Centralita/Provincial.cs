using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }
        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen,miFranja,llamada.Duracion, llamada.NroDestino)
        {
            
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        /*public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }*/

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float returnAux = 0;
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    returnAux = duracion * (float)0.99;
                    break;
                case Franja.Franja_2:
                    returnAux = duracion * (float)1.25;
                    break;
                case Franja.Franja_3:
                    returnAux = duracion * (float)0.66;
                    break;
            }
            return returnAux;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {base.Duracion} NroDestino: {base.NroDestino} NroOrigen: {base.NroOrigen} Costo de Llamada: {this.CostoLlamada} Franja horaria: {this.franjaHoraria}");
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is Provincial)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
