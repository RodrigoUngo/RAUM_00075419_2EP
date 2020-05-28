using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class EliminarDireccion : UserControl
    {
        public EliminarDireccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionDB.ExecuteNonQuery($"DELETE FROM ADDRESS WHERE idAddress = {Convert.ToInt32(textBox1.Text)}");
            MessageBox.Show("Se ha eliminado al producto con exito");
        }
    }
}