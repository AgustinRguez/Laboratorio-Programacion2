using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_06_Ejercicio3
{
    public partial class CalcularPalabras : Form
    {
        public CalcularPalabras()
        {   
            InitializeComponent();   
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> diccionario = ObtenerContadorPalabras();
            List<KeyValuePair<string, int>> podio = diccionario.ToList();
            podio.Sort(CompararCantidad);
            MostrarPodio(podio);
        }
        private void MostrarPodio(List<KeyValuePair<string, int>> podio)
        {
            StringBuilder sb = new StringBuilder();
            if(podio.Count == 0)
            {
                sb.AppendLine("No se ingresron palabras");
            }
            else
            {
                foreach (KeyValuePair<string, int> item in podio)
                {
                    sb.AppendLine($"Palabra: {item.Key} - Cantidad: {item.Value}");
                }
            }
            
            MessageBox.Show(sb.ToString(), "Podio");
        }
        private int CompararCantidad(KeyValuePair<string,int> primerElemento, KeyValuePair<string, int> segundoElemento)
        {
            return segundoElemento.Value - primerElemento.Value;
            
        }
        private Dictionary<string,int> ObtenerContadorPalabras()
        { 
            string texto = rchContenedorDeTexto.Text;
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries); //el split separa el string en x numeros depende el caracter separador
            foreach (string palabra in palabras)
            {
                if (diccionario.ContainsKey(palabra))
                {
                    diccionario[palabra]++;
                }
                else
                {
                    diccionario.Add(palabra, 1);
                }
            }
            return diccionario;
        }
    }
}
