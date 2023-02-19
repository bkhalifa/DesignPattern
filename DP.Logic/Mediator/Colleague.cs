namespace DP.Logic.Mediator
{
    public abstract class Colleague
    {
        public Mediator Mediator { get; }
        public Colleague(Mediator mediator)
        {
            Mediator = mediator;
        }

        public virtual void Send(string message)
        {
            this.Mediator.Send(message, this);
        }

        public abstract void HandleNotification(string message);    
      
    }
}
