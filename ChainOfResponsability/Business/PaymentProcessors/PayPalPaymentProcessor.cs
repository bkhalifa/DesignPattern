using ChainOfResponsability.Models;
using ChainOfResponsability.PaymentProcessors;

namespace ChainOfResponsability.Business.PaymentProcessors
{
    public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void Finalize(Order order)
        {
            var payment = order.SelectedPayments.FirstOrDefault(x =>x.PaymentProvider == PaymentProvider.Paypal);
            if (payment is null) return;

            order.FinalizedPayments.Add(payment);
        }
    }
}
