using ChainOfResponsability.Business.PaymentProcessors;
using ChainOfResponsability.Models;

namespace ChainOfResponsability.Business.Payments
{
    public class PayPalHandler : PaymentHandler
    {
        private PayPalPaymentProcessor payPalPaymentProcessor { get; } = new PayPalPaymentProcessor();
        public override void Handle(Order order)
        {
            if (order.SelectedPayments.Any(x => x.PaymentProvider == PaymentProvider.Paypal))
            {
                payPalPaymentProcessor.Finalize(order);
            }

            base.Handle(order);
        }
    }
}
