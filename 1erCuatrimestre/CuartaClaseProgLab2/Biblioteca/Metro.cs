using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Metro
    {
        #region Atributos
        public double cantidadDeMetros;
        #endregion

        #region Constructores
        public Metro()
        {
            this.cantidadDeMetros = 0;
        }
        public Metro(double cantidad)
        {
            this.cantidadDeMetros = cantidad;
        }

        #endregion

        #region Metodos
        public static Metro operator + (Metro metroUno, Metro metroDos)
        {
            Metro retornarMetro = new Metro();
            retornarMetro.cantidadDeMetros = metroUno.cantidadDeMetros + metroDos.cantidadDeMetros;
            return retornarMetro;
        }

        public static explicit operator double(Metro metroUno) //ya es doble, explicita perdida de datos
        {
            return metroUno.cantidadDeMetros; //objeto punto atributo
        }
        public static implicit operator int(Metro metroUno) //implicita no hay perdida de datos
        {
            return (int)metroUno.cantidadDeMetros;
        }
        #endregion
    }
}
