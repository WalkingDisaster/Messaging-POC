using Ohio.Counties.Franklin.MessageBus.Configuration;

namespace Ohio.Counties.Franklin.MessageBus.Server.Configuration
{
    public class ServerBusRegistry : BusRegistry
    {
        protected override string QueueName
        {
            get { return "process_server"; }
        }
    }
}