using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class Admin : UserControl
    {
        private UserControl current = null;

        public Admin()
        {
            InitializeComponent();
            current = usuarios1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Usuarios();
            tableLayoutPanel1.Controls.Add(current, 0,1);
            tableLayoutPanel1.SetColumnSpan(current,4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Negocios();
            tableLayoutPanel1.Controls.Add(current, 0,1);
            tableLayoutPanel1.SetColumnSpan(current,4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Productos();
            tableLayoutPanel1.Controls.Add(current, 0,1);
            tableLayoutPanel1.SetColumnSpan(current,4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Ordenes();
            tableLayoutPanel1.Controls.Add(current, 0,1);
            tableLayoutPanel1.SetColumnSpan(current,4);
        }
    }
}