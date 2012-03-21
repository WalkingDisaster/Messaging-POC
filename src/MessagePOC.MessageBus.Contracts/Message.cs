using System;
using Magnum;

namespace MessagePOC.MessageBus.Contracts
{
    public abstract class Message
    {
        public Guid CorrelationId { get; private set; }
        public string ChangedBy { get; private set; }
        public DateTime ChangedOn { get; private set; }

        protected Message(Guid correlationId, string changedBy)
        {
            CorrelationId = correlationId;
            ChangedBy = changedBy;
            ChangedOn = DateTime.UtcNow;
        }

        protected Message(string changedBy)
            : this(CombGuid.Generate(), changedBy)
        {
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}, ID = {2}, Changed By: {3}", ChangedOn, this.GetType().Name, CorrelationId, ChangedBy);
        }
    }
}