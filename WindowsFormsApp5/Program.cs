using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the SplashScreen and then the MainForm
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.FormClosed += (sender, args) => Application.Exit();
            Application.Run(splashScreen);
        }
    }
}
