using System;
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
        private void ActualizarCo_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new ActualizarContra();
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

        private void Continuar_Click(object sender, EventArgs e)
        {
            UsuarioComun usuario = new UsuarioComun();
            usuario.Show();
            this.Hide();
        }
    }
}
