using Ohio.Counties.Franklin.MessageBus.Configuration;

namespace Ohio.Counties.Franklin.MessageBus.Client2.Configuration
{
    public class ClientBusRegistry : BusRegistry
    {
        protected override string QueueName
        {
            get { return "client_two"; }
        }
    }
}