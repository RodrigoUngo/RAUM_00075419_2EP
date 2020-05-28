using System;
using System.Windows.Forms;
using NpgsqlTypes;

namespace Parcial02
{
    public partial class Ordenar : UserControl
    {
        public Ordenar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionDB.ExecuteNonQuery("INSERT INTO APPORDER(createDate, idProduct, idAddress)" +
                            $"VALUES('{NpgsqlDateTime.Now}', {textBox1.Text}, {textBox2.Text});");
                MessageBox.Show("Se ha ingresado el pedido con exito.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error");
                throw;
            }
        }
    }
}