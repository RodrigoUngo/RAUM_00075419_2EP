using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class Productos : UserControl
    {
        private UserControl current = null;
        public Productos()
        {
            InitializeComponent();
            current = agregarProducto1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new AgregarProducto();
            tableLayoutPanel1.Controls.Add(current, 0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new EliminarProducto();
            tableLayoutPanel1.Controls.Add(current, 0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
        }
    }
}