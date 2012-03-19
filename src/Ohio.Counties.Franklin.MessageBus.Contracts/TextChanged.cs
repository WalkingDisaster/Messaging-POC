namespace Ohio.Counties.Franklin.MessageBus.Contracts
{
    public class TextChanged
    {
        public TextChanged(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
