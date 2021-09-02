using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaDeJuegos
{
    public partial class FrmAdivinaNumero : Form
    {
        Random numeroRan;
        int contador;
        int numeroAleatorio;
        
        public FrmAdivinaNumero()
        {
            InitializeComponent();        
        }

        private void FrmAdivinaNumero_Load(object sender, EventArgs e)
        {
            numeroRan = new Random();
            contador = 0;
        }

        private void btnGenerarRandom_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.txtNumeroIngresado.Text);
            
            int numeroParser = int.Parse(this.txtNumeroIngresado.Text);
            if(numeroParser == numeroAleatorio)
            {
                MessageBox.Show("logrado: " + contador + " intentos");
            }
            else
            {
                MessageBox.Show("Fallaste: " + contador + " intentos");  
            }
           
        }

        private void chkIntentos_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkIntentos.Checked)
            {
                this.contador++;
            }
            if (this.contador == 5)
            {
                this.Close();
            }
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.chkIntentos.Enabled = false;
            this.grpNivel.Enabled = false;
            int maximo = 1;
            foreach (Control item in grpNivel.Controls)
            {
                if(item is GroupBox && ((RadioButton)item).Checked)
                {
                    if(int.TryParse(((RadioButton)item).Text, out maximo))
                    {

                    }
                }
            }
            numeroAleatorio = numeroRan.Next(1, maximo);
            ((Button)sender).Visible = false;
            this.btnGenerarRandom.Visible = true;
        }
    }
}
