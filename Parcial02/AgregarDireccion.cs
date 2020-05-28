using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class AgregarDireccion : UserControl
    {
        public AgregarDireccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool verify = true; 
                String type = "";
                var tab = ConnectionDB.ExecuteQuery("SELECT address FROM ADDRESS"); 
                var names = new List<String>(); 
                foreach (DataRow dr in tab.Rows) 
                { 
                    names.Add(dr[0].ToString()); 
                }
                
                foreach (String bar in names) 
                { 
                    if (bar.Equals(textBox1.Text)) 
                    { 
                        MessageBox.Show("La direccion ya esta registrada"); 
                        verify = false; 
                    } 
                }
                
                var tabl = ConnectionDB.ExecuteQuery($"SELECT idUser FROM APPUSER WHERE username = '{textBox2.Text}'"); 
                int id = 0; 
                foreach (DataRow dr in tabl.Rows) 
                { 
                    id = Convert.ToInt32(dr[0].ToString()); 
                }

                if (verify) 
                { 
                    ConnectionDB.ExecuteNonQuery("INSERT INTO ADDRESS(idUser, address)" +
                                                 $"VALUES({id}, '{textBox1.Text}');");
                    MessageBox.Show("Direccion ingresada exitosamente."); 
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