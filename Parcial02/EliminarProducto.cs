using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class EliminarProducto : UserControl
    {
        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionDB.ExecuteNonQuery($"DELETE FROM PRODUCT WHERE name = '{textBox1.Text}'");
            MessageBox.Show("Se ha eliminado al producto con exito");
        }
    }
}