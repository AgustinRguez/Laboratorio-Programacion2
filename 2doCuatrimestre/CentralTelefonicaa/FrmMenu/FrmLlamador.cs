using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centralita;
namespace FrmPrincipal
{
    public partial class FrmLlamador : Form
    {
        ClaseCentralita c;
        public FrmLlamador(ClaseCentralita c)
        {
            this.c = c;
            InitializeComponent();
            CenterToScreen();
        }
        public ClaseCentralita GetFormLlamador
        {
            get
            {
                return this.c;
            }
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if(txtNroDestino.Text != string.Empty)
            {
                if(txtNroDestino.Text.Contains("Nro Destino") && txtNroDestino.Text != "Nro Destino")
                {
                    txtNroDestino.Text = txtNroDestino.Text.Replace("Nro Destino", "");
                }
                if (!txtNroDestino.Text.StartsWith("#"))
                {
                    cmbFranja.Enabled = false;
                }
                else
                {
                    cmbFranja.Enabled = true;
                }
            }
            else
            {
                txtNroDestino.Text = "Nro Destino";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "9";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "*";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "0";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "#";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Clear();
            txtNroOrigen.Clear();
            cmbFranja.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNroOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNroOrigen.Select(txtNroOrigen.Text.Length, 0);
        }

        private void txtNroOrigen_TextChanged(object sender, EventArgs e)
        {
            if(txtNroOrigen.Text != string.Empty)
            {
                if(txtNroOrigen.Text.Contains("Nro Origen") && txtNroOrigen.Text != "Nro Origen")
                {
                    txtNroOrigen.Text = txtNroOrigen.Text.Replace("Nro Origen", "");
                }
            }
            else
            {
                txtNroOrigen.Text = "Nro Origen";
            }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            // Carga
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random numeroRandom = new Random();
            Provincial.Franja franja;
            Llamada llamada;
            if (cmbFranja.Enabled)
            {
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franja);
                llamada = new Provincial(txtNroOrigen.Text, franja, numeroRandom.Next(1, 50), txtNroDestino.Text);
            }
            else
            {
                llamada = new Local(txtNroOrigen.Text, numeroRandom.Next(1, 50), txtNroDestino.Text, Convert.ToSingle(numeroRandom.NextDouble() * (0.5 - 5.6) + 0.5));
            }
            this.c += llamada;
        }
    }
}
