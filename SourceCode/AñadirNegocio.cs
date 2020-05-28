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
    public partial class AñadirNegocio : UserControl
    {
        public AñadirNegocio()
        {
            InitializeComponent();
        }

        private void AgregarB(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Equals(""))
            {
                MessageBox.Show("Error! tiene que llenar todos los campos");
            }
            else
            {
                try
                {
                    ConectionDb.ExecuteNonQuery($"INSERT INTO BUSINESS VALUES(" +
                                                $"'{textBox1.Text}', '{textBox2.Text}')");
                    MessageBox.Show("Se ha registrado el Negocio");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha sucedido un error");
                }
            }
        }
    }
}
