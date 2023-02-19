namespace DP.Logic.Observer
{
    public class TicketChange
    {
        public int Amount { get; private set; }
        public int ArtistId { get; private set; }

        public TicketChange(int amount, int artistId)
        {
            Amount = amount;
            ArtistId = artistId;
        }
    }

  
}
