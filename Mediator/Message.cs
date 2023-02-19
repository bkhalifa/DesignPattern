namespace Mediator
{
    public class Message
    {
        public IColleague Sender { get; }
        public string Content { get; }

        public Message(IColleague sender, string content)
        {
            Sender = sender;
            Content = content;
        }
    }
}