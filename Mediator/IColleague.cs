namespace Mediator
{
    public interface IColleague
    {
        string Name { get; }
        void ReceiveMessage(Message message);
    }
}
