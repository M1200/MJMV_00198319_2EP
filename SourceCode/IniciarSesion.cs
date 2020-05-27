using System.Windows.Forms;

namespace HUGO
{
    public partial class IniciarSesion : UserControl
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void Continuar_Click(object sender, System.EventArgs e)
        {
            UsuarioComun usuarioComun = new UsuarioComun();
            usuarioComun.Show();
            this.Hide();
            
        }
    }
}