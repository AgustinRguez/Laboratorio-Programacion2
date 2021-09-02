using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }


        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private void SetTinta(short tinta)
        {
            if(tinta >= 0 && tinta <= cantidadTintaMaxima)
            {
                this.tinta = tinta;
            }
        }
        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }
        public Boolean Pintar(short gasto, out string dibujo)
        {
            Boolean verificar = false;
            dibujo = "";
            SetTinta(gasto);
            if (this.tinta > 0)
            {
                for (int i = 0; i < gasto; i++)
                {
                    dibujo = dibujo.Insert(0,"*");
                    verificar = true;
                }
            }
            else
            {
                verificar = false;
            }

            return verificar;
        }
    }
}
