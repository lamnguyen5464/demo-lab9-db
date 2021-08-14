using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPV102_CS486_Team13.Navigation;
using SPV102_CS486_Team13.Screen;

namespace SPV102_CS486_Team13
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
            Form form = new Form();
            NavigationHelper.getInstance().Init(form);
            NavigationHelper.getInstance().push(new MainScreen());
            Application.Run(NavigationHelper.getInstance().form);
        }
    }
}
