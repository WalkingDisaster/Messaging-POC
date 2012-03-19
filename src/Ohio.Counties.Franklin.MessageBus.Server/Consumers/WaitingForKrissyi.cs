using System;
using MassTransit;
using Ohio.Counties.Franklin.MessageBus.Contracts;

namespace Ohio.Counties.Franklin.MessageBus.Server.Consumers
{
    public class WaitingForKrissy : Consumes<TextChanged>.Selected
    {
        public void Consume(TextChanged message)
        {
            Console.WriteLine("Message with a \"Krissy\": {0}", message.Name);
        }

        public bool Accept(TextChanged message)
        {
            return (message.Name.Contains("Krissy"));
        }
    }
}