using WinFormsTPV.Services;
using WinFormsTPV.Views;

namespace WinFormsTPV
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>        

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            DbController db = new DbController();
            db.CrearDb();
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