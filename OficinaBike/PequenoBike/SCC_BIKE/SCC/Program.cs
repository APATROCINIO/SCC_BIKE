using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using SCC_BIKE.View;

namespace SCC_BIKE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmSplash splash = new frmSplash();
            

            if (splash.ShowDialog() == DialogResult.OK)
            {
                frmLogin logar = new frmLogin();

                if (logar.ShowDialog() == DialogResult.OK)
                {
                     Application.Run(new MDIPrincipal());
                }
            }

        }
    }
}
