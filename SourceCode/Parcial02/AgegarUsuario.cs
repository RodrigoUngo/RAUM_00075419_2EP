using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class AgegarUsuario : UserControl
    {
        public AgegarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool verify = true; 
                String type = "";
                var tab = ConnectionDB.ExecuteQuery("SELECT username FROM APPUSER"); 
                var usernames = new List<String>(); 
                foreach (DataRow dr in tab.Rows) 
                { 
                    usernames.Add(dr[0].ToString()); 
                }
                
                foreach (String bar in usernames) 
                { 
                    if (bar.Equals(textBox1.Text)) 
                    { 
                        MessageBox.Show("El usuario ya esta registrado"); 
                        verify = false; 
                    } 
                }
                
                if (comboBox1.SelectedIndex == 0) 
                    type = "false";
                else 
                { 
                    type = "true"; 
                }
                
                if (verify) 
                { 
                    ConnectionDB.ExecuteNonQuery("INSERT INTO APPUSER(fullname, username, password, userType)" + 
                                               $"VALUES('{textBox2.Text}', '{textBox1.Text}', '{textBox1.Text}', {type});"); 
                    MessageBox.Show("Usuario ingresado exitosamente."); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error");
                throw;
            }
            
        }

        private void AgegarUsuario_Load(object sender, EventArgs e)
        {
            var tipos = new List<String>();
            tipos.Add("Usuario normal"); tipos.Add("Administrador");
            comboBox1.DataSource = tipos;
        }
    }
}