using MessagePOC.MessageBus.Configuration;

namespace MessagePOC.MessageBus.Client1.Configuration
{
    public class Client1BusRegrstry : BusRegistry
    {
        protected override string QueueName
        {
            get { return "client_one"; }
        }
    }
}