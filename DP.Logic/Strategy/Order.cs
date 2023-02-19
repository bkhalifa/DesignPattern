namespace DP.Logic.Strategy
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public double Amount { get; set; }

        public Order(int id, string customer, double amount)
        {
            Id = id;
            Customer = customer;
            amount = amount;
        }
    }
}