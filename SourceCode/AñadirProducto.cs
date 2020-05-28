using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HUGO
{
    public partial class AñadirProducto : UserControl
    {
        public AñadirProducto()
        {
            InitializeComponent();
        }
        
        


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Error! tiene que llenar todos los campos");
            }
            else
            {
                try
                {
                    ConectionDb.ExecuteNonQuery($"INSERT INTO PRODUCTO VALUES(" +
                                                $"'{textBox1.Text}");
                    MessageBox.Show("Se ha registrado el usuario");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha sucedido un error");
                }
            }

            
        }

       private void AñadirProducto_Load(object sender, EventArgs e)
        {
            var business = ConectionDb.ExecuteQuery("SELECT name FROM BUSINESS");
            var businessCombo = new List<String>();

            foreach (DataRow dr in business.Rows)
            {
                businessCombo.Add(dr[0].ToString());
            }
            
        }
    }
}
