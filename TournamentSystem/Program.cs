using OfficeOpenXml;
using System;
using System.Windows.Forms;

namespace TournamentSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
         
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}