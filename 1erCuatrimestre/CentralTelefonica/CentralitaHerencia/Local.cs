using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo)
            :base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen) 
            //llamo a la clase base y le paso los valores a traves del tipo de dato de la clase base
        {
            this.costo = costo;
        }
        public Local(string origen, float duracion, string destino,float costo)
            : this(new Llamada(duracion,destino,origen),costo) // se le pasa los nombres de este construc
        {

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
            float valorLlamada= base.duracion * this.costo;
            return valorLlamada;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion: " + base.duracion);
            sb.AppendLine("Nro Destino: " + base.nroDestino);
            sb.AppendLine("Nro Origen: " + base.nroOrigen);
            sb.AppendLine("Costo de llamada" + this.CostoLlamada);
            
            return sb.ToString();
        }
    }
}
