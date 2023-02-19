using ChainOfResponsability.Business.PaymentProcessors;
using ChainOfResponsability.Models;

namespace ChainOfResponsability.Business.Payments
{
    public class PayPalHandler2 : IReceiver<Order>
    {
        private PayPalPaymentProcessor payPalPaymentProcessor { get; } = new PayPalPaymentProcessor();
        public void Handle(Order order)
        {
            if (order.SelectedPayments.Any(x => x.PaymentProvider == PaymentProvider.Paypal))
            {
                payPalPaymentProcessor.Finalize(order);
            }
        }
    }
}
