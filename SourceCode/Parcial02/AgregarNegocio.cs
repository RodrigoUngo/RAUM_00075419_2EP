using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class AgregarNegocio : UserControl
    {
        public AgregarNegocio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool verify = true; 
                String type = "";
                var tab = ConnectionDB.ExecuteQuery("SELECT name FROM BUSINESS"); 
                var names = new List<String>(); 
                foreach (DataRow dr in tab.Rows) 
                { 
                    names.Add(dr[0].ToString()); 
                }
                
                foreach (String bar in names) 
                { 
                    if (bar.Equals(textBox1.Text)) 
                    { 
                        MessageBox.Show("El negocio ya esta registrado"); 
                        verify = false; 
                    } 
                }
                
                if (verify) 
                { 
                    ConnectionDB.ExecuteNonQuery("INSERT INTO BUSINESS(name, description)" +
                                                 $"VALUES ('{textBox1.Text}', '{textBox2.Text}');");
                    MessageBox.Show("Negocio ingresado exitosamente."); 
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