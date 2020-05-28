using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class VerDirecciones : UserControl
    {
        public VerDirecciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = ConnectionDB.ExecuteQuery($"SELECT ad.idAddress, ad.address FROM ADDRESS ad WHERE idUser = {Convert.ToInt32(textBox1.Text)};");
                dataGridView1.DataSource = dt;
                MessageBox.Show("Datos obtenidos exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}