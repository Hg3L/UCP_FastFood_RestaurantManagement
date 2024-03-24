using DTO;
using GUI.ViewForm;
using GUI.ViewForm.MainFormApp;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            ApplicationConfiguration.Initialize();

            //Test
            UserAccount x = new UserAccount();
            x.Name_Account = "Developer";
            //x.Type_Account = "Nhân viên";
            x.Type_Account = "Admin";

            //Application.Run(new frmMain(x));
            Application.Run(new frmStart());
            //Application.Run(new frmStatistic());
        }
    }
}