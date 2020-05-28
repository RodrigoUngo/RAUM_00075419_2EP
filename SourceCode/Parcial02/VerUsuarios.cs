using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class VerUsuarios : UserControl
    {
        public VerUsuarios()
        {
            InitializeComponent();
        }

        private void VerUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                var dt = ConnectionDB.ExecuteQuery("SELECT * FROM APPUSER;");
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