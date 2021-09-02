using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa): this()
        {
            this.razonSocial = nombreEmpresa;
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaLlamadas;
            }
        }
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        /// <summary>
        /// En el foreach hago la suma y asignacion a la variable, luego en el switch
        /// retorno dependiendo lo que seleccionen
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float recaudacionLocal = 0;
            float recaudacionProvincial = 0;
            foreach (Llamada item in Llamadas)
            {
                if(item is Local)
                {
                    recaudacionLocal += ((Local)item).CostoLlamada;
                }
                else if(item is Provincial)
                {
                    recaudacionProvincial += ((Provincial)item).CostoLlamada;

                }
            }
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    return recaudacionLocal;
                   
                case Llamada.TipoLlamada.Provincial:
                    return recaudacionProvincial;
                default:
                    return recaudacionProvincial + recaudacionLocal;
                   
            }
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Razon Social: " + this.razonSocial);
            sb.AppendLine("Ganancias por total: " + this.GananciasPorTotal);
            sb.AppendLine("Ganancias por local: " + this.GananciasPorLocal);
            foreach (Llamada item in this.Llamadas) // la propiedad que recibe la lista
            {
                sb.AppendLine("Detalles de llamadas: " + item.Mostrar());

            }
            return sb.ToString();
        }
        public void OrdenarLlamadas()
        {
            this.listaLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
