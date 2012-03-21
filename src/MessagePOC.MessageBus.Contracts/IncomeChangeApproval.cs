using System;

namespace MessagePOC.MessageBus.Contracts
{
    public class IncomeChangeApproval : Message
    {
        public IncomeChangeApproval(Guid correlationId, string approvedBy)
            : base(correlationId, approvedBy)
        {
        }
    }
}