namespace Ohio.Counties.Franklin.MessageBus.Contracts
{
    public class IncomeChangeRejection : Message
    {
         public IncomeChangeRejection(string rejectedBy)
             : base(rejectedBy)
         {
         }
    }
}