using ChainOfResponsability.Business.PaymentProcessors;
using ChainOfResponsability.Models;

namespace ChainOfResponsability.Business.Payments
{
    public class InvoiceHandler : PaymentHandler
    {
        private InvoicePaymentProcessor invoicePaymentProcessor = new InvoicePaymentProcessor();
        public override void Handle(Order order)
        {
            if (order.SelectedPayments.Any(x => x.PaymentProvider == PaymentProvider.Invoice))
            {
                invoicePaymentProcessor.Finalize(order);
            }
            base.Handle(order);
        }
    }
}
