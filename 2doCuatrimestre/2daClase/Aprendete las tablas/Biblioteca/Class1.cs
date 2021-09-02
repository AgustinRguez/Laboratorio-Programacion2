using System;
using System.Text;
namespace Biblioteca
{
    public class Class1
    {
        public static string Tabla(int numero)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tabla de multiplicar del 2: ");
            sb.AppendLine(numero +"x" + "1" + "=" + numero * 1);
            sb.AppendLine(numero + "x" + "2" + "=" + numero * 2);
            sb.AppendLine(numero + "x" + "3" + "=" + numero * 3);
            sb.AppendLine(numero + "x" + "4" + "=" + numero * 4);
            sb.AppendLine(numero + "x" + "5" + "=" + numero * 5);
            sb.AppendLine(numero + "x" + "6" + "=" + numero * 6);
            sb.AppendLine(numero + "x" + "7" + "=" + numero * 7);
            sb.AppendLine(numero + "x" + "8" + "=" + numero * 8);
            sb.AppendLine(numero + "x" + "9" + "=" + numero * 9);
            return sb.ToString();
        }
    }
}
