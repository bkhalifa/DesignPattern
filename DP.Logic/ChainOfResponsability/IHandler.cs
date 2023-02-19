namespace DP.Logic.ChainOfResponsability
{
    public interface IHandler<T> where T : class
    {
        IHandler<T> SetSuccessor(IHandler<T> successor);
        void Handle(T request);
    }

    public abstract class Handler<T> : IHandler<T> where T : class
    {
        private  IHandler<T>? Successor;
        public virtual void Handle(T request)
        {
           Successor?.Handle(request);
        }

        public IHandler<T> SetSuccessor(IHandler<T> successor)
        {
           Successor = successor;
            return Successor;
        }
    }
}
