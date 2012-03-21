using MessagePOC.MessageBus.Configuration;

namespace MessagePOC.MessageBus.Server.Configuration
{
    public class ServerBusRegistry : BusRegistry
    {
        protected override string QueueName
        {
            get { return "process_server"; }
        }
    }
}