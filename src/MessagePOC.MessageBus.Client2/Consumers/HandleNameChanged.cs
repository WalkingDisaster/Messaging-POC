using MassTransit;
using MessagePOC.MessageBus.Contracts;

namespace MessagePOC.MessageBus.Client2.Consumers
{
    public class HandleNameChanged : Consumes<NameChanged>.All
    {
        public void Consume(NameChanged message)
        {
            PeopleForm.ChangeName(message);
        }
    }
}