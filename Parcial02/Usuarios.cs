using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class Usuarios : UserControl
    {
        private UserControl current = null;
        public Usuarios()
        {
            InitializeComponent();
            current = agegarUsuario1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new AgegarUsuario();
            tableLayoutPanel1.Controls.Add(current, 0,1);
            tableLayoutPanel1.SetColumnSpan(current,3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new EliminarUsuario();
            tableLayoutPanel1.Controls.Add(current, 0,1);
            tableLayoutPanel1.SetColumnSpan(current,3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new VerUsuarios();
            tableLayoutPanel1.Controls.Add(current, 0,1);
            tableLayoutPanel1.SetColumnSpan(current,3);
        }
    }
}