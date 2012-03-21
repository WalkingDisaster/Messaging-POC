using MassTransit;
using Ohio.Counties.Franklin.MessageBus.Contracts;

namespace Ohio.Counties.Franklin.MessageBus.Client2.Consumers
{
    public class HandleNameChanged : Consumes<NameChanged>.All
    {
        public void Consume(NameChanged message)
        {
            PeopleForm.ChangeName(message);
        }
    }
}