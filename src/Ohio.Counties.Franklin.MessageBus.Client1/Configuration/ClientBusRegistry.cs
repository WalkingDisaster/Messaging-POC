using Ohio.Counties.Franklin.MessageBus.Configuration;

namespace Ohio.Counties.Franklin.MessageBus.Client1.Configuration
{
    public class Client1BusRegrstry : BusRegistry
    {
        protected override string QueueName
        {
            get { return "client_one"; }
        }
    }
}