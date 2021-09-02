using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        
        public FormCalculadora()
        {
            InitializeComponent();
           
        }
        /// <summary>
        /// Limpia todos los botones txt box y lbl del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimerNumero.Text = "";
            txtSegundoNumero.Text = "";
            cmbSigno.Text = "";
            lblResultado.Text = "";
        }
        /// <summary>
        /// Cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Realiza las operaciones segun lo requiera el usuario dando el click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operar(txtPrimerNumero.Text, txtSegundoNumero.Text, cmbSigno.Text).ToString();
        }
        /// <summary>
        /// Metodo que realiza las operaciones entre dos numeros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private double Operar(string numero1, string numero2, string operador)
        {
            Numero numeroUno = new Numero(numero1);
            Numero numeroDos = new Numero(numero2);
            return Calculadora.Operar(numeroUno, numeroDos, operador);
        }
        /// <summary>
        /// Boton que convierte a binario por medio de un click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
        }
        /// <summary>
        /// Boton que convierte a decimal por medio de un click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
        }

   
    }
}
