using System.Linq;
using Magnum.Extensions;
using MassTransit;
using Ohio.Counties.Franklin.MessageBus.Configuration;
using Ohio.Counties.Franklin.MessageBus.Contracts;

namespace Ohio.Counties.Franklin.MessageBus.Server
{
    internal class Program
    {
        private static void Main()
        {
            var container = StructureMapBootstrapper.Bootstrap();
            var bus = container.GetInstance<IServiceBus>();
//
//            var iConsumer = container.Model.AllInstances.Where(t => t.PluginType.Implements<IConsumer>()).ToList();
//            var consumer = container.Model.PluginTypes.Where(t => t.PluginType.Implements(typeof (Consumes<>))).ToList();
//            var everything = container.Model.PluginTypes.Where(t => t.PluginType.Implements(typeof (object))).ToList();
//            var hooo = container
//                .Model
//                .PluginTypes
//                .Where(x => x.PluginType.Implements<IConsumer>())
//                .Select(i => i.PluginType)
//                .Concat(container.Model.InstancesOf<IConsumer>().Select(x => x.ConcreteType))
//                .Distinct()
//                .ToList();
//
//            bus.Publish(new TextChanged("Hi"));
//            bus.Publish(new TextChanged("Hi again"));
//            bus.Publish(new TextChanged("Hi the third"));
//            bus.Publish(new TextChanged("what's up!?"));
        }
    }
}