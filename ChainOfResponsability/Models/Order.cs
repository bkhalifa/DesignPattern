namespace ChainOfResponsability.Models
{
    public class Order
    {
        public Dictionary<Item, int> LineItems { get; } = new Dictionary<Item, int>();
        public IList<Payment> SelectedPayments { get; } = new List<Payment>();
        public IList<Payment> FinalizedPayments { get; } = new List<Payment>();
        public decimal AmountDue => LineItems.Sum(item => item.Key.Price * item.Value) - FinalizedPayments.Sum(payment => payment.Amount);
        public ShippingStatus ShippingStatus { get; set; } = ShippingStatus.WaitingForPayment;
    }
    public enum ShippingStatus
    {
        WaitingForPayment,
        ReadyForShippment,
        Shipped
    }
    public enum PaymentProvider
    {
        Paypal,
        CreditCard,
        Invoice
    }
    public class Payment
    {
        public decimal Amount { get; set; }
        public PaymentProvider PaymentProvider { get; set; }
    }
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Item(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
