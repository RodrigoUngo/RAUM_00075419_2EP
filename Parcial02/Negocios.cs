using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class Negocios : UserControl
    {
        private UserControl current = null;
        public Negocios()
        {
            InitializeComponent();
            current = agregarNegocio1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new AgregarNegocio();
            tableLayoutPanel1.Controls.Add(current, 0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new EliminarNegocio();
            tableLayoutPanel1.Controls.Add(current, 0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
        }
    }
}