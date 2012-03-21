using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MassTransit;
using Ohio.Counties.Franklin.MessageBus.Configuration;

namespace Ohio.Counties.Franklin.MessageBus.Client2
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
            var bus = container.GetInstance<IServiceBus>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PeopleForm());
        }
    }
}
