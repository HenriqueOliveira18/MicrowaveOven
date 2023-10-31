using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Wayne.MicrowaveOven
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

            Manager manager = new Manager();
            Application.Run(manager);
        }
    }
}