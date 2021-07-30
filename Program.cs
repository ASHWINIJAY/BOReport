using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POScreen
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
            string c = ProccessLogin();
            if (c != null)
            {
                var LoginDtls = c.Split(',');
                Application.Run(new frmHome(LoginDtls[0],LoginDtls[1]));
            }
        }
        static string ProccessLogin()
        {
            using (var f = new frmLogin())
            {
                f.ShowDialog();

                return f.logintype+"," + f.loginname;
            }
        }
         
    }
}
