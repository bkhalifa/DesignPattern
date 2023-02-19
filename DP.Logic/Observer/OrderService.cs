namespace DP.Logic.Observer
{
    public class OrderService : TicketChangeNotifier
    {
        public void CompleteTicketSale(int artistId, int amount)
        {
            Console.WriteLine($"{nameof(OrderService)}is changing the state");
            // notify observers

            Console.WriteLine($"{nameof(OrderService)} is notifying observers");

            Notify(new TicketChange(artistId, amount));
        }
    }
}
