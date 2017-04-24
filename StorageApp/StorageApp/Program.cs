using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageApp
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
            Prijava formaPrijava = new Prijava();
            if (formaPrijava.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new PočetnoSučelje());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
