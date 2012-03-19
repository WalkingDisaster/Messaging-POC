using System;
using System.Windows.Forms;
using Ohio.Counties.Franklin.MessageBus.Configuration;

namespace Ohio.Counties.Franklin.MessageBus.Client1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = StructureMapBootstrapper.Bootstrap();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SystemOneForm());
        }
    }
}
