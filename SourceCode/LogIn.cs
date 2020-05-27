using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HUGO
{
    public partial class LogIn : Form
    {
        private UserControl current = null;

        public LogIn()
        {
            InitializeComponent();
            current = iniciarSesion1;
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new IniciarSesion();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 1);
        }
        private void Registro_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Registro();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 1);

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
