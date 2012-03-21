using MessagePOC.MessageBus.Configuration;

namespace MessagePOC.MessageBus.Client3.Configuration
{
    public class ClientBusRegistry : BusRegistry
    {
        protected override string QueueName
        {
            get { return "client_three"; }
        }
    }
}