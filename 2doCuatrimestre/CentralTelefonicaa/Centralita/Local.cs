using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local : Llamada
    {
        protected float costo;
        
        public Local(Llamada llamada, float costo) 
            :this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {
            
        }
        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
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
            float valorLlamada = base.duracion * this.costo;
            return valorLlamada;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {base.Duracion} NroDestino: {base.NroDestino} NroOrigen: {base.NroOrigen} Costo de Llamada: {CostoLlamada}");
            return sb.ToString(); 
        }
        public override bool Equals(object obj)
        {
            if(obj is Local)
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
