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
    public partial class Registro : UserControl
    {
        public Registro()
        {
            InitializeComponent();
        }


        private void Agregar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Equals("") || textBox3.Text.Equals(""))
            {
                MessageBox.Show("Error! tiene que llenar todos los campos");
            }

            else
            {
                try
                {
                    ConectionDb.ExecuteNonQuery($"INSERT INTO APPUSER VALUES(" +
                                                $"'{textBox1.Text}', '{textBox2.Text}', " +
                                                $"'{textBox3.Text}')");

                    MessageBox.Show("Se ha creado la cuenta con exito");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error!");
                }

            }
        }
    }
}
