using MassTransit;
using MessagePOC.MessageBus.Contracts;

namespace MessagePOC.MessageBus.Client2.Consumers
{
    public class HandleIncomeChange : Consumes<IncomeChange>.All
    {
        public void Consume(IncomeChange message)
        {
            PeopleForm.ChangeIncome(message);
        }
    }
}