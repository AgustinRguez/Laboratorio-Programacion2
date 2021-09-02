using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum FranjaHoraria
        {
            Franja_1, Franja_2, Franja_3 
        };
        protected FranjaHoraria franjaHoraria;

        public Provincial(FranjaHoraria miFranja, Llamada llamada)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(string origen, FranjaHoraria miFranja, float duracion, string destino)
            : this(miFranja, new Llamada(duracion, destino, origen))
        {

        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion: " + base.duracion);
            sb.AppendLine("Nro Destino" + base.nroDestino);
            sb.AppendLine("Nro Origen" + base.nroOrigen);
            sb.AppendLine("Costo de llamada" + this.CostoLlamada);
            sb.AppendLine("Costo de llamada" + this.franjaHoraria);

            return sb.ToString();
        }
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        private float CalcularCosto()
        {
            float returnAux = -1;
            switch (this.franjaHoraria)
            {
                case FranjaHoraria.Franja_1 :
                    returnAux = base.duracion * (float)0.99;
                    break;

                case FranjaHoraria.Franja_2:
                    returnAux = base.duracion * (float)1.25;
                    break;

                case FranjaHoraria.Franja_3:
                    returnAux = base.duracion * (float)0.66;
                    break;
            }
            return returnAux;
        }

        
    }
}
