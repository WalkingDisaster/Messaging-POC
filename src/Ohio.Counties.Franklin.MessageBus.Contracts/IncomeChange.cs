using System;

namespace Ohio.Counties.Franklin.MessageBus.Contracts
{
    public class IncomeChange : Message
    {
        public string Name { get; set; }
        public decimal Income { get; set; }

        public IncomeChange(Guid correlationId, string name, decimal income, string changedBy)
            : base(correlationId, changedBy)
        {
            Name = name;
            Income = income;
        }
    }
}