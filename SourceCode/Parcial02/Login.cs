using System;
using System.Data;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class Login : UserControl
    {
        private UserControl current = null;
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String user = "", password = "", confirm = "";
                var tab = ConnectionDB.ExecuteQuery($"SELECT username FROM APPUSER where username = '{textBox1.Text}'");
                 foreach (DataRow dr in tab.Rows)
                 {
                  user = dr[0].ToString();
                 } 
                 if (user.Equals("")) 
                     MessageBox.Show("El usuario no existe");
                 else 
                 {
                     var tab2 = ConnectionDB.ExecuteQuery($"SELECT password FROM APPUSER where username = '{textBox1.Text}'"); 
                     foreach (DataRow dr in tab2.Rows) 
                     { 
                         password = dr[0].ToString(); 
                     }

                     if (password.Equals(textBox2.Text))
                     {
                         var tab3 = ConnectionDB.ExecuteQuery(
                             $"SELECT userType FROM APPUSER where username = '{textBox1.Text}'");
                         foreach (DataRow dr in tab3.Rows)
                         {
                             confirm = dr[0].ToString();
                         }

                         if (confirm.Equals("True"))
                         {
                             label1.Visible = false;
                             label3.Visible = false;
                             textBox1.Visible = false;
                             textBox2.Visible = false;
                             button1.Visible = false;
                             button2.Visible = false;
                             current = new Admin();
                             tableLayoutPanel1.Controls.Add(current, 0, 0);
                             tableLayoutPanel1.SetColumnSpan(current, 2);
                             tableLayoutPanel1.SetRowSpan(current, 4);
                         }
                         else
                         {
                             label1.Visible = false;
                             label3.Visible = false;
                             textBox1.Visible = false;
                             textBox2.Visible = false;
                             button1.Visible = false;
                             button2.Visible = false;
                             current = new Normal();
                             tableLayoutPanel1.Controls.Add(current, 0, 0);
                             tableLayoutPanel1.SetColumnSpan(current, 2);
                             tableLayoutPanel1.SetRowSpan(current, 4);
                         }
                     }
                     else
                         throw new WrongPasswordException("Contraseña equivocada");
                 }
            }
            catch (WrongPasswordException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            current = new ModificarContrasena();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 2);
            tableLayoutPanel1.SetRowSpan(current, 4);
        }
    }
}