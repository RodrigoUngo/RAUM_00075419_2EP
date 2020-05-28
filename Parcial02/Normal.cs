using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class Normal : UserControl
    {
        private UserControl current = null;
        public Normal()
        {
            InitializeComponent();
            current = direcciones1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Direcciones();
            tableLayoutPanel1.Controls.Add(current, 0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new OrdenesUser();
            tableLayoutPanel1.Controls.Add(current, 0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
        }
    }
}