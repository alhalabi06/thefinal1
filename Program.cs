using final1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final1
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
            //Application.Run(new frmCountry());
            //Application.Run(new frmBloodType());
            //Application.Run(new frmEmergencyContact());
            //Application.Run(new frmPrice());
            //Application.Run(new frmUnits());
            //Application.Run(new frmTestType());
            //Application.Run(new frmUsers());
            /*Application.Run(new MDIBlood());*/
            Application.Run(new frmLogin());


        }
    }
}
