using WinFormsTPV.Controllers;

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
            NavigationController navigation = new NavigationController();
            navigation.LoginTerminal();
        }
    }
}