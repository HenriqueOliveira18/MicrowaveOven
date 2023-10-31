using System;
using System.Windows.Forms;


namespace Wayne.MicrowaveOven
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Manager manager = new Manager();
            Application.Run(manager);
        }
    }
}