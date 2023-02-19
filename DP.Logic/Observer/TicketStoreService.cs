namespace DP.Logic.Observer
{
    public class TicketStoreService : ITicketChangeListener
    {
        public void ReceiveTicketChangeNotification(TicketChange ticketChange)
        {
            //update local datastore

            Console.WriteLine($"{nameof(TicketStoreService)} notified" +
                $"of ticket change : artist {ticketChange.ArtistId}, amount " +
                $"{ticketChange.Amount}");
        }
    }
}
