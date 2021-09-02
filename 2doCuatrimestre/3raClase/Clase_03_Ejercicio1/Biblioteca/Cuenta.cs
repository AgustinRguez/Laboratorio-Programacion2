using System;
using System.Text;
namespace Biblioteca
{
    public class Cuenta
    {
        private string razonSocial;
        private decimal cantidad;

        public Cuenta(string razonSocial, decimal cantidad)
        {
            this.razonSocial = razonSocial;
            this.cantidad = cantidad;
        }
        public string GetRazonSocial()
        {
            return razonSocial;
        }
        public decimal GetCantidad()
        {
            return cantidad;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Razon Social: " + GetRazonSocial());
            sb.AppendLine("Cantidad: " + GetCantidad());
            return sb.ToString();
        }
        public void Ingresar(decimal monto)
        {
            if (monto > 0)
            {
                this.cantidad += monto;
            }
            else
            {
                Console.WriteLine("ERROR. Ingresar un monto mayor a 0");
            }
            
        }
        public void Retirar(decimal monto)
        {
            if (monto > 0)
            {
                this.cantidad -= monto;
            }
            else
            {
                Console.WriteLine("ERROR. Ingresar un monto mayor a 0");
            }
        }
    }
}
