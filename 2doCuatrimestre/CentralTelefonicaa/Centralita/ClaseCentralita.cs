using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class ClaseCentralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public ClaseCentralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }
        public ClaseCentralita(string nombreEmpresa): this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }
        }
        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float recaudacionLocal=0;
            float recaudacionProvincial=0;
            
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
                    return recaudacionLocal + recaudacionProvincial;        
            }
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon social: {razonSocial} \nGanancia Total: {GananciasPorTotal} \nGanancias Locales: {GananciasPorLocal} \nGanancias Provinciales: {GananciasPorProvincial} ");
            foreach (Llamada item in this.Llamadas) // la propiedad que recibe la lista
            {
                sb.AppendLine("Detalles de llamadas: " + item.ToString());

            }
            return sb.ToString();
        }
        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            Llamadas.Add(nuevaLlamada);
        }
        public static bool operator ==(ClaseCentralita c, Llamada llamada)
        {
            bool retornoAux = false;
            foreach (Llamada item in c.Llamadas)
            {
                if (item == llamada)
                {
                    retornoAux = true;
                }
            }
            return retornoAux;
        }
        public static bool operator !=(ClaseCentralita c, Llamada llamada)
        {
            return (!(c == llamada));
        }
        public static ClaseCentralita operator +(ClaseCentralita c, Llamada llamada)
        {
            if(!(c == llamada))
            {
                c.AgregarLlamada(llamada);
            }
            return c;
        }
    }
}
