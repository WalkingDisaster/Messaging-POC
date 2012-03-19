using System;
using MassTransit;
using Ohio.Counties.Franklin.MessageBus.Contracts;

namespace Ohio.Counties.Franklin.MessageBus.Server.Consumers
{
    public class ShowMeTheHi : Consumes<TextChanged>.Selected
    {
        public void Consume(TextChanged message)
        {
            Console.WriteLine("Message with a \"Hi\": {0}", message.Name);
        }

        public bool Accept(TextChanged message)
        {
            return (message.Name.Contains("Hi"));
        }
    }
}