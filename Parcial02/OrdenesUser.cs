using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class OrdenesUser : UserControl
    {
        private UserControl current = null;
        public OrdenesUser()
        {
            InitializeComponent();
            current = ordenar1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Ordenar();
            tableLayoutPanel1.Controls.Add(current, 0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new EliminarOrden();
            tableLayoutPanel1.Controls.Add(current, 0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
        }
    }
}