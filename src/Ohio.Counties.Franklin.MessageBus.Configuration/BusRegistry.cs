using MassTransit;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace Ohio.Counties.Franklin.MessageBus.Configuration
{
    public abstract class BusRegistry : Registry
    {
        protected abstract string QueueName { get; }

         protected BusRegistry()
         {
             For<IServiceBus>().Use(CreateBus);

             Scan(x =>
                  {
                      x.AssembliesFromApplicationBaseDirectory(y => y.FullName.StartsWith("Ohio"));
                      x.AddAllTypesOf<IConsumer>();
                  });
         }

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