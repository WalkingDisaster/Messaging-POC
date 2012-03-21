using System;

namespace Ohio.Counties.Franklin.MessageBus.Contracts
{
    public class IncomeChangeRequest : Message
    {
        public string Name { get; set; }
        public decimal NewIncome { get; set; }

        public IncomeChangeRequest(string name, decimal newIncome, string changedBy)
            : base(changedBy) 
        {
            Name = name;
            NewIncome = newIncome;
        }

        public override string ToString()
        {
            return string.Format("{0}: Income change request for {1} to {2:c} by {3}", ChangedBy, Name, NewIncome, ChangedBy);
        }
    }
}