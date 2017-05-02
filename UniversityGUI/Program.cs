using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityGUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new View(new Model(@"books.csv", @"tickets.csv", @"formulars.csv")));
            }
            catch (WrongIDException e)
            {
                string msg = e.Message + " (wrong id = " + e.WrongID.ToString() + ")";
                Application.Run(new WarningForm(msg));
            }
        }
    }
}
