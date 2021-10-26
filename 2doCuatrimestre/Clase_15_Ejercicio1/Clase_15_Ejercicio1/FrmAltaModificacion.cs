using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_15_Ejercicio1
{
    public partial class FrmAltaModificacion : Form
    {
        private string tituloForm;
        private string textoTxtObjeto;
        private string textoBtnConfirmar;
        public FrmAltaModificacion(string tituloForm, string textoTxtObjeto, string textoBtnConfirmar)
        {
            InitializeComponent();
            this.tituloForm = tituloForm;
            this.textoTxtObjeto = textoTxtObjeto;
            this.textoBtnConfirmar = textoBtnConfirmar;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtObjeto.Text is not null)
            {
                MessageBox.Show("El texto no tiene que estar vacío", "Texto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
