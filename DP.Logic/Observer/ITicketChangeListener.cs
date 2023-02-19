namespace DP.Logic.Observer
{
    /// <summary>
    /// observer
    /// </summary>
    public interface ITicketChangeListener
    {
      void ReceiveTicketChangeNotification(TicketChange ticketChange);
    }
}
