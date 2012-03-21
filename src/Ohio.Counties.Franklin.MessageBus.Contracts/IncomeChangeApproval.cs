using System;

namespace Ohio.Counties.Franklin.MessageBus.Contracts
{
    public class IncomeChangeApproval : Message
    {
        public IncomeChangeApproval(Guid correlationId, string approvedBy)
            : base(correlationId, approvedBy)
        {
        }
    }
}