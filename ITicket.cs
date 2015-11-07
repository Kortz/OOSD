
namespace GCUShows
{

    /// <summary>
    ///  Enum for what type of ticket it's going to be
    /// </summary>
    public enum TicketType {
        Adult, Child, Family
    }

    /// <summary>
    ///  The methods that must be provided through the interface
    /// </summary>
    public interface ITicket {
        decimal Cost { get; }
        string Print();    
    }
}
