using ChainOfResponsability.Models;
using ChainOfResponsability.PaymentProcessors;

namespace ChainOfResponsability.Business.PaymentProcessors
{
    public class CreditCardProccessor : IPaymentProcessor
    {
        public void Finalize(Order order)
        {
            var payment = order.SelectedPayments.FirstOrDefault(x => x.PaymentProvider == PaymentProvider.CreditCard);
            if (payment == null) return;
            order.SelectedPayments.Add(payment);
        }
    }
}
