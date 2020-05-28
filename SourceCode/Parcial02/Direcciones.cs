using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class Direcciones : UserControl
    {
        private UserControl current = null;
        public Direcciones()
        {
            InitializeComponent();
            current = agregarDireccion1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new AgregarDireccion();
            tableLayoutPanel1.Controls.Add(current, 0,1);
            tableLayoutPanel1.SetColumnSpan(current,4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new ModificarDireccion();
            tableLayoutPanel1.Controls.Add(current, 0,1);
            tableLayoutPanel1.SetColumnSpan(current,4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new EliminarDireccion();
            tableLayoutPanel1.Controls.Add(current, 0,1);
            tableLayoutPanel1.SetColumnSpan(current,4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new VerDirecciones();
            tableLayoutPanel1.Controls.Add(current, 0,1);
            tableLayoutPanel1.SetColumnSpan(current,4);
        }
    }
}