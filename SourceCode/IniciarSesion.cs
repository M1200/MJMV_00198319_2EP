using System.Windows.Forms;
using System;

namespace HUGO
{
    public partial class IniciarSesion : UserControl
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void Continuar_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals("")|| textBox2.Text.Equals(""))
            {
                MessageBox.Show("Error, Los campos no pueden estar en blanco");
            }
        }
    }
}