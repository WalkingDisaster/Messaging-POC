using MassTransit;
using Ohio.Counties.Franklin.MessageBus.Contracts;

namespace Ohio.Counties.Franklin.MessageBus.Client2.Consumers
{
    public class HandleIncomeChange : Consumes<IncomeChange>.All
    {
        public void Consume(IncomeChange message)
        {
            PeopleForm.ChangeIncome(message);
        }
    }
}