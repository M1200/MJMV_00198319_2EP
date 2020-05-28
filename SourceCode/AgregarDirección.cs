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
    public partial class AgregarDirección : UserControl
    {
        public AgregarDirección()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") )
            {
                MessageBox.Show("Error! tiene que llenar todos los campos");
            }
            else
            {
                try
                {
                    ConectionDb.ExecuteNonQuery($"INSERT INTO ADDRESS VALUES(" +
                                                $"'{textBox1.Text}')");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha sucedido un error");
                }
            }
        }
    }
}
