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
    public partial class UsuarioComun : Form
    {
        public UsuarioComun()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
