using System;

namespace MessagePOC.MessageBus.Contracts
{
    public class IncomeChangeRejection : Message
    {
         public IncomeChangeRejection(Guid correlationId, string rejectedBy)
             : base(correlationId, rejectedBy)
         {
         }
    }
}