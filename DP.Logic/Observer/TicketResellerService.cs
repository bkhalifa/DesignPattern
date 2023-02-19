namespace DP.Logic.Observer
{
    /// <summary>
    /// concret observer
    /// </summary>
    public class TicketResellerService : ITicketChangeListener
    {
        public void ReceiveTicketChangeNotification(TicketChange ticketChange)
        {
           // update local datasource

            Console.WriteLine($"{nameof(TicketResellerService)} notified" + 
                $"of ticket change : artist {ticketChange.ArtistId}"+
                $"{ticketChange.Amount}");
        }
    }
}
