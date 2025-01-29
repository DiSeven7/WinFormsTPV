using WinFormsTPV.Controllers;
using WinFormsTPV.Models;

namespace WinFormsTPV.Views
{
    public partial class Login : Form
    {
        private DbController dbController = new DbController();

        public Usuario Usuario { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            var usuario = dbController.IniciarSesion(tbUsuario.Text, tbContraseña.Text);
            if (usuario != null)
            {
                if (!usuario.Activo)
                {
                    lblErrorLogin.Text = "Usuario deshabilitado";
                    lblErrorLogin.Visible = true;
                }
                else
                {
                    Usuario = usuario;
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                lblErrorLogin.Text = "Usuario o contraseña incorrectos";
                lblErrorLogin.Visible = true;
            }
        }

        private void inputsFormulario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAcceder.PerformClick();
            }
        }
    }
}
