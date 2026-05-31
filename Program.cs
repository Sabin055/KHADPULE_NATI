using System.Data;
using System.Windows.Forms;
namespace KHADPULE_NATI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new MainForm());
            //Application.Run(new MemberForm());
            Application.Run(new LoginForm());
        }
    }
}