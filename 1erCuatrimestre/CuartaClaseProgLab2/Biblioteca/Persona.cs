using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        #region Atributos

        public string apellido;
        public string nombre;
        public int dni;
        private static int cantidadPersonas;

        #endregion
       
        #region Constructores
        static Persona()
        {
           Persona.cantidadPersonas = 0;
        }
        public Persona() //de instancia
        {
            this.apellido = "sin apellido";
            this.nombre = "sin nombre";
            this.dni = -1;
            Persona.cantidadPersonas++;

        }
        public Persona(string apellido):this() //sobrecarga de constructores o invocar
        {
            this.apellido = apellido;
        }
        public Persona(string apellido, int dni): this(apellido)
        {
            this.dni = dni;
        }
        public Persona(string apellido, int dni, string nombre): this(apellido,dni) //ambito
        {
            this.nombre = nombre;
        }
        #endregion

        public static int MostrarPersona()
        {
            return Persona.cantidadPersonas;
        }
    }

}
