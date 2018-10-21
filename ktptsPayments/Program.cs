using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ktptsPayments
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
            //var lf = new LoginFlash();
            //lf.Show();
            Application.Run(new LoginFlash());
            //Application.Run(new MDIParentPyments());
        }
    }
}
