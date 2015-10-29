using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bounced_Check_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var loginMenu = new Bounced_Check_Manager_UI_Layer.login();
            Application.Run(loginMenu);
            if (loginMenu.loggedIn)
            {
                Application.Run(new Bounced_Check_Manager_UI_Layer.mainMenu());
            }
        }
    }
}