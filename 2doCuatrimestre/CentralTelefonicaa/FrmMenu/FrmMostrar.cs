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
    public partial class FrmMostrar : Form
    {
        Llamada.TipoLlamada llamada;
        ClaseCentralita c;
        public FrmMostrar(ClaseCentralita c) 
        {
            this.c = c;
            InitializeComponent();
            CenterToScreen();
        }
        public Llamada.TipoLlamada TipoLlamada
        {
            set
            {
                this.llamada = value;
            }
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Ganancia Total:" + c.GananciasPorTotal);
            sb.AppendLine("Ganancia Provincial:" + c.GananciasPorProvincial);
            sb.AppendLine("Ganancia Local:" + c.GananciasPorLocal);

            foreach (Llamada aux in c.Llamadas)
            {

                if (aux is Local && llamada == Llamada.TipoLlamada.Local)
                {
                    sb.AppendLine("\nDetalle de Llamada: " + aux.ToString());
                }
                if (aux is Provincial && llamada == Llamada.TipoLlamada.Provincial)
                {
                    sb.AppendLine("\nDetalle de Llamada: " + aux.ToString());
                }
                if (llamada == Llamada.TipoLlamada.Todas)
                {
                    sb.AppendLine("\nDetalle de Llamada: " + aux.ToString());
                }


            }
            richTextBox1.Text = sb.ToString();
        }
    }
}
