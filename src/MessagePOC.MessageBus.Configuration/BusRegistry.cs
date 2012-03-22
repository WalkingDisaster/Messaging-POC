using MassTransit;
using MassTransit.Saga;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace MessagePOC.MessageBus.Configuration
{
    public abstract class BusRegistry : Registry
    {
        protected BusRegistry()
        {
            For<IServiceBus>().Use(CreateBus);

            Scan(x =>
                     {
                         x.AssembliesFromApplicationBaseDirectory(y => y.FullName.StartsWith("MessagePOC"));
                         x.AddAllTypesOf<IConsumer>();
                     });
        }

        protected abstract string QueueName { get; }

        private IServiceBus CreateBus(IContext context)
        {
            return ServiceBusFactory.New(sbc =>
                                             {
                                                 sbc.UseRabbitMq();
                                                 sbc.ReceiveFrom("rabbitmq://localhost/" + QueueName);
                                                 sbc.UseRabbitMqRouting();
                                                 sbc.Subscribe(c => c.LoadFrom(context.GetInstance<IContainer>()));
                                             });
        }
    }
}