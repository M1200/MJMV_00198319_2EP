using System;
using System.Windows.Forms;

namespace HUGO
{
    public partial class UsuarioComun : Form
    {
        private UserControl current = null;
        public UsuarioComun()
        {
            InitializeComponent();
            current = pedido1;
        }

       
        

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pedido_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Pedido();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 1);
        }

        private void AgregarDir_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new AgregarDirección();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 1);
        }

        private void ModificarEliminar_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new ModificarEliminar();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 1);
        }

        private void Historial_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new HistorialPedidos();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 1);
        }

        private void RegresarMenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }
    }
}
