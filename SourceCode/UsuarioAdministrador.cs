using System;
using System.Windows.Forms;

namespace HUGO
{
    public partial class UsuarioAdministrador : Form
    {
        private UserControl current = null;
        public UsuarioAdministrador()
        {
            InitializeComponent();
            current = registro1;
        }


        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registro_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Registro();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 1);
        }

        private void EliminarUsuario_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new EliminarUsuario();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 1);
        }

        private void AnadirNegocio_Click(object sender, EventArgs e)
        {

            tableLayoutPanel1.Controls.Remove(current);
            current = new AñadirNegocio();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 1);
        }

        private void EliminarNegocio_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new EliminarNegocio();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 1);
        }

        private void AnadirProducto_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new AñadirProducto();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 1);
        }

        private void EliminarProducto_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new EliminarProducto();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 1);
        }

        private void VerOrdenes_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new HistorialPedidos();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 1);
        }
    }
}
