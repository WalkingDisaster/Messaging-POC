using System;
using MassTransit;
using Ohio.Counties.Franklin.MessageBus.Contracts;

namespace Ohio.Counties.Franklin.MessageBus.Server.Consumers
{
    public class HandleEverything : Consumes<NameChanged>.All, Consumes<IncomeChangeRequest>.All, Consumes<IncomeChangeApproval>.All, Consumes<IncomeChangeRejection>.All
    {
        public void Consume(NameChanged message)
        {
            Log(message);
        }

        public void Consume(IncomeChangeRequest message)
        {
            Log(message);
        }

        public void Consume(IncomeChangeApproval message)
        {
            Log(message);
        }

        public void Consume(IncomeChangeRejection message)
        {
            Log(message);
        }

        private static void Log(Message message)
        {
            Console.WriteLine(message.ToString());
        }
    }
}