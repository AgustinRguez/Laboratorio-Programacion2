using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        private string nombre;
        private double precioBruto;
        private EImpuesto Eimpuesto;
        private List<Proveedor> listaProveedores; //un producto puedo tener muchos proveedores
        
        
        public Producto(EImpuesto impuestoPorcentaje)
        {
            this.Eimpuesto = impuestoPorcentaje;
            this.listaProveedores = new List<Proveedor>();
        }
        public String Nombre //propiedad
        {
            get 
            { 
                return this.nombre; 
            }
            set 
            { 
                this.nombre = value; 
            }
        }
        public double PrecioBruto //propiedad
        {//nadie va a poder ver el precio bruto solo se asignara y no se retornara
            set
            {
                this.precioBruto = value;
            }
        }
        public EImpuesto Impuesto //propiedad
        {
            get
            {
                return this.Eimpuesto;
            }
        }
        public double PrecioFinal
        {
            get
            {
                return (this.CalcularPrecioFinal());
            }
        }
        private double CalcularPrecioFinal()
        {
            double porcentajeImpuesto = 0;
            switch (this.Eimpuesto)
            {
                case EImpuesto.veintiuno:
                    porcentajeImpuesto = 21;
                    break;
                case EImpuesto.diez:
                    porcentajeImpuesto = 10;
                    break;
                case EImpuesto.sinImpuesto:
                    porcentajeImpuesto = 0;
                    break;
            }
            return this.precioBruto + (this.precioBruto * (porcentajeImpuesto/100));
        }
        public double this[string clave]
        {
            get
            {
                switch (clave)
                {
                    case "Precio Final":
                        return this.CalcularPrecioFinal();
                    case "Precio Bruto":
                        return this.precioBruto;
                    case "Impuesto":
                        return (double)this.Eimpuesto;
                    default:
                        return 0;
                }
            }
        }
        public double enumToDouble()
        {
            double porcentajeImpuesto = 0;
            switch (this.Eimpuesto)
            {
                case EImpuesto.veintiuno:
                    porcentajeImpuesto = 21;
                    break;
                case EImpuesto.diez:
                    porcentajeImpuesto = 10;
                    break;
                case EImpuesto.sinImpuesto:
                    porcentajeImpuesto = 0;
                    break;
            }
            return porcentajeImpuesto;
        }
    }
}
