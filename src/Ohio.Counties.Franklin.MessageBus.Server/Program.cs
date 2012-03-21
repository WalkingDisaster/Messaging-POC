using System.Linq;
using Magnum.Extensions;
using MassTransit;
using MassTransit.Saga;
using Ohio.Counties.Franklin.MessageBus.Configuration;
using Ohio.Counties.Franklin.MessageBus.Contracts;
using Ohio.Counties.Franklin.MessageBus.Contracts.Sagas;

namespace Ohio.Counties.Franklin.MessageBus.Server
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