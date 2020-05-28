using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class ModificarContrasena : UserControl
    {
        private UserControl current = null;
        public ModificarContrasena()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionDB.ExecuteNonQuery($"UPDATE APPUSER SET password = '{textBox2.Text}' WHERE username = '{textBox1.Text}'");
            MessageBox.Show("Se ha cambiado la contraseña correctamente");
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button1.Visible = false;
            current = new Login();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 2);
            tableLayoutPanel1.SetRowSpan(current, 4);
        }
    }
}