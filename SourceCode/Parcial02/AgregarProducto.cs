using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class AgregarProducto : UserControl
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            var business = ConnectionDB.ExecuteQuery("SELECT name FROM BUSINESS");
            var businessComboBox = new List<String>();
            foreach (DataRow dr in business.Rows)
            {
                businessComboBox.Add(dr[0].ToString());
            }

            comboBox1.DataSource = businessComboBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool verify = true; 
                String type = "";
                var tab = ConnectionDB.ExecuteQuery("SELECT name FROM PRODUCT"); 
                var names = new List<String>(); 
                foreach (DataRow dr in tab.Rows) 
                { 
                    names.Add(dr[0].ToString()); 
                }
                
                foreach (String bar in names) 
                { 
                    if (bar.Equals(textBox1.Text)) 
                    { 
                        MessageBox.Show("El producto ya esta registrado"); 
                        verify = false; 
                    } 
                }
                
                var tabl = ConnectionDB.ExecuteQuery("SELECT idbusiness FROM BUSINESS"); 
                var ids = new List<int>(); 
                foreach (DataRow dr in tabl.Rows) 
                { 
                    ids.Add(Convert.ToInt32(dr[0].ToString())); 
                }

                int number = ids[comboBox1.SelectedIndex];

                if (verify) 
                { 
                    ConnectionDB.ExecuteNonQuery("INSERT INTO PRODUCT(idBusiness, name)" +
                    $"VALUES({number}, '{textBox1.Text}');");
                    MessageBox.Show("Producto ingresado exitosamente."); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error");
                throw;
            }
        }
    }
}