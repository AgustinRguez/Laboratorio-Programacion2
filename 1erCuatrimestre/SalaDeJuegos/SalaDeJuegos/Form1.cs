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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal() //constructor
        {
            InitializeComponent();
        
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("Estoy On Pa");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdivinaNumero frmAdivinaNumero = new FrmAdivinaNumero();
            frmAdivinaNumero.ShowDialog();
            //this.txtNombre.Text
            //this.Close();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Estas seguro Pa?", "Titulo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }

    }
}
