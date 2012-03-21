using System;
using System.Windows.Forms;
using MessagePOC.MessageBus.Configuration;

namespace MessagePOC.MessageBus.Client1
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
