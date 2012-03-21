using System;
using Magnum;

namespace MessagePOC.MessageBus.Contracts
{
    public class NameChanged : Message
    {
        public string OldName { get; private set; }
        public string NewName { get; private set; }

        public NameChanged(string oldName, string newName, string changedBy)
            : base(changedBy)
        {
            OldName = oldName;
            NewName = newName;
        }

        public override string ToString()
        {
            return string.Format("{0}: Name changed from \"{1}\" to \"{2}\" by {3}", ChangedOn, OldName, NewName, ChangedBy);
        }
    }
}