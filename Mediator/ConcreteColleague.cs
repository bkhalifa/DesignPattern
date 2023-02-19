namespace Mediator
{
    public class ConcreteColleague : IColleague
    {
        private readonly IMessageWriter<Message> _messageWriter;
        public string Name { get; }

        public ConcreteColleague(IMessageWriter<Message> messageWriter, string name)
        {
            _messageWriter = messageWriter ?? throw new ArgumentNullException(nameof(messageWriter));
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public void ReceiveMessage(Message message)
        {
           _messageWriter.Write(message);
        }
    }
}
