using WinFormsTPV.Views;

namespace WinFormsTPV.Controllers
{
    internal class NavigationController : INavigationController
    {
        public void LoginTerminal()
        {
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                TerminalVentas tpv = new TerminalVentas(login.Usuario);
                tpv.ShowDialog();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
