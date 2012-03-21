namespace MessagePOC.MessageBus.Contracts
{
    public class IncomeChangeRejection : Message
    {
         public IncomeChangeRejection(string rejectedBy)
             : base(rejectedBy)
         {
         }
    }
}