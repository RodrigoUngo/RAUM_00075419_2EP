using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class ModificarDireccion : UserControl
    {
        public ModificarDireccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionDB.ExecuteNonQuery($"UPDATE ADDRESS SET address = '{textBox2.Text}'" + 
                                         $"WHERE idAddress = {Convert.ToInt32(textBox1.Text)}");
            MessageBox.Show("Se ha modificado la dirección con exito");
        }
    }
}