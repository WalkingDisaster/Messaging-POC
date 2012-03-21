using MassTransit;
using MassTransit.Saga;
using MessagePOC.MessageBus.Configuration;
using MessagePOC.MessageBus.Contracts.Sagas;

namespace MessagePOC.MessageBus.Server
{
    internal class Program
    {
        private static void Main()
        {
            var container = StructureMapBootstrapper.Bootstrap();
            var bus = container.GetInstance<IServiceBus>();
            bus.SubscribeSaga(container.GetInstance<ISagaRepository<ApprovalSaga>>());
        }
    }
}