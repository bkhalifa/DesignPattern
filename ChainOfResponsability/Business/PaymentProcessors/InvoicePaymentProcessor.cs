using ChainOfResponsability.Models;
using ChainOfResponsability.PaymentProcessors;

namespace ChainOfResponsability.Business.PaymentProcessors
{
    public class InvoicePaymentProcessor : IPaymentProcessor
    {
        public void Finalize(Order order)
        {
            var payment = order.SelectedPayments.FirstOrDefault(x => x.PaymentProvider == PaymentProvider.Invoice);
            if (payment is null) return;

            order.SelectedPayments.Add(payment);
        }
    }
}
