using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
namespace VentaDeProductoOctavaClase
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto productoNuevo = new Producto(EImpuesto.veintiuno);
            productoNuevo.Nombre = "Agustin"; //set se usa ya que asigno
            MessageBox.Show(productoNuevo.Nombre); // muestro
            MessageBox.Show(productoNuevo.Impuesto.ToString()); // muestro
            productoNuevo.PrecioBruto = 200;
            MessageBox.Show(productoNuevo.PrecioFinal.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Producto pepa = new Producto(EImpuesto.diez);
            Producto oreo = new Producto(EImpuesto.veintiuno);
            Gondola gondolaNueva = new Gondola();
            EImpuesto miEnumerado;
            
            pepa.Nombre = "pepa";
            oreo.Nombre = "oreo";
            pepa.PrecioBruto = 200;
            oreo.PrecioBruto = 100;

            gondolaNueva[0] = pepa;
            gondolaNueva[1] = oreo;
            gondolaNueva[100] = pepa;

            MessageBox.Show(gondolaNueva[0].Nombre.ToString());
            MessageBox.Show(gondolaNueva[1].Nombre.ToString());

            MessageBox.Show("Precio final de pepa: " + pepa["Precio Final"].ToString());
            MessageBox.Show("Precio final de oreo: " + oreo["Precio Final"].ToString());

            miEnumerado = EImpuesto.sinImpuesto;
            switch (miEnumerado)
            {
                case EImpuesto.veintiuno:
                    break;
                case EImpuesto.diez:
                    break;
                case EImpuesto.sinImpuesto:
                    break;
            }
        }
    }
}