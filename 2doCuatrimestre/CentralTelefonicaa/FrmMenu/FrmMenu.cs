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
    public partial class FrmMenu : Form
    {
        ClaseCentralita centralita;
        public FrmMenu()
        {
            centralita = new ClaseCentralita();
            InitializeComponent();
            CenterToScreen();
        }

        private void GenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(centralita);
            llamador.ShowDialog();
            this.centralita = llamador.GetFormLlamador;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralita);
            mostrar.TipoLlamada = Llamada.TipoLlamada.Todas;
            mostrar.ShowDialog();

        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralita);
            mostrar.TipoLlamada = Llamada.TipoLlamada.Local;
            mostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralita);
            mostrar.TipoLlamada = Llamada.TipoLlamada.Provincial;
            mostrar.ShowDialog();
        }
    }
}
