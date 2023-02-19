using ChainOfResponsability.Models;

namespace ChainOfResponsability.PaymentProcessors
{
    public interface IPaymentProcessor
    {
        void Finalize(Order order);
    }
}
