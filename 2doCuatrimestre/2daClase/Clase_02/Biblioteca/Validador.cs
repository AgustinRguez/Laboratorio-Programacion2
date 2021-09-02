using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Validador
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool Validar(int valor, int min, int max)
        {
            bool boleano = false;
            if(valor >= min && valor <= max)
            {
                boleano = true;
            }
            return boleano;
        }
        
    }
}
