using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF
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
            Application.Run(new Login());
            //Application.Run(new FormDrink());
            //Application.Run(new FormFood());
            //Application.Run(new FormBranch());
            //Application.Run(new FormEmployee());
            //Application.Run(new FormMain());
            //Application.Run(new FormRevenue());

        }
    }
}
