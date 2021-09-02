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

namespace EjemClaseAbstractaLabProg2
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FacturaA facA = new FacturaA("lala","20-39664582-4");
            FacturaB facB = new FacturaB("lele", "20-35891472-4");
            FacturaC facC = new FacturaC("lolo", "20-34245894-4");

            MessageBox.Show("Factura A: " + facA.RetornarDatosClientes());
            MessageBox.Show("Factura B: " + facB.RetornarDatosClientes());
            //MessageBox.Show("Factura C: " + facC.RetornarDatosClientes());
            MessageBox.Show(facA.RetornarNumeroDeCuit());
            MessageBox.Show("Factura B: " + facB.RetornarNumeroDeCuit());
            MessageBox.Show(facC.RetornarNumeroDeCuit());
            
            //Factura factura = new Factura(); no se puede, para parcial (?
        }
    }
}
