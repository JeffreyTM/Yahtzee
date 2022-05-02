using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }
    }
}

/*namespace MultiFormApps1
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //************************************************
            PasswordForm login = new PasswordForm();
            login.ShowDialog(); //Open Login form as dialog box.
            //Processing of Main stops until Login form in closed

            if (login.DialogResult == DialogResult.OK)
                Application.Run(new FinancialPlanner());
            //**************************************************

           // Application.Run(new FinancialPlanner()); //Normally, this line would run.
            //However, we replaced it with the lines between the commented asterisks
        }
    }
}
*/