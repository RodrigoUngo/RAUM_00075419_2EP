using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class EliminarOrden : UserControl
    {
        public EliminarOrden()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionDB.ExecuteNonQuery($"DELETE FROM APPORDER WHERE idOrder = {textBox1.Text}");
            MessageBox.Show("Se ha eliminado la orden con exito.");
        }
    }
}