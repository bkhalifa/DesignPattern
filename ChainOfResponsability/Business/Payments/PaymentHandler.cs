using ChainOfResponsability.Models;

namespace ChainOfResponsability.Business.Payments
{
    public class PaymentHandler : IHandler<Order>
    {
        private IHandler<Order>? _next;
        public virtual void Handle(Order order)
        {
            if (order?.AmountDue > default(int))
            {
                throw new InsufficientExecutionStackException();
            }
            if (order?.AmountDue > 0)
            {
                _next?.Handle(order);
            }
            else
            {
                order!.ShippingStatus = ShippingStatus.ReadyForShippment;
            }
        }

        public IHandler<Order> SetNext(IHandler<Order> next)
        {
            _next = next;
            return _next;
        }
    }

    public class PaymentHandler2
    {
        private readonly IList<IReceiver<Order>> receivers;
        public PaymentHandler2(params IReceiver<Order>[] receivers)
        {
            this.receivers = receivers;
        }
        public void Handle(Order order)
        {
            foreach (var receiver in receivers)
            {
                if(order.AmountDue > 0)
                {
                    receiver.Handle(order);
                }
                else
                {
                    break;
                }
            }
          
            if(order.AmountDue > 0)
            {
                throw new InsufficientExecutionStackException();
            }
            else
            {
                order.ShippingStatus = ShippingStatus.ReadyForShippment;
            }
        }

        public void SetNext(IReceiver<Order> next)
        {
          receivers.Add(next);
        }
    }
    public interface IReceiver<T> where T : class
    {
        void Handle(T request);
    }
}
