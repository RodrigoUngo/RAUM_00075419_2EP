using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class EliminarNegocio : UserControl
    {
        public EliminarNegocio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionDB.ExecuteNonQuery($"DELETE FROM BUSINESS WHERE name = '{textBox1.Text}'");
            MessageBox.Show("Se ha eliminado al negocio con exito");
        }
    }
}