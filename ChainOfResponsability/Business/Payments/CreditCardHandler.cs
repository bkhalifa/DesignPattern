using ChainOfResponsability.Business.PaymentProcessors;
using ChainOfResponsability.Models;

namespace ChainOfResponsability.Business.Payments
{
    public class CreditCardHandler : PaymentHandler
    {
        public CreditCardProccessor creditCardProcessor { get; } = new CreditCardProccessor();
        public override void Handle(Order order)
        {
            if(order.SelectedPayments.Any(x => x.PaymentProvider == PaymentProvider.CreditCard))
            {
                creditCardProcessor.Finalize(order);
            }
            base.Handle(order);
        }
    }
}
