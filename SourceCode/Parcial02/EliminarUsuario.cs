using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class EliminarUsuario : UserControl
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionDB.ExecuteNonQuery($"DELETE FROM APPUSER WHERE username = '{textBox1.Text}'");
            MessageBox.Show("Se ha eliminado al usuario con exito");
        }
    }
}