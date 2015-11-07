
namespace GCUShows
{
    public class FamilyTicket : ITicket {
        /// <summary>
        ///  Declaration of instance variables.
        /// </summary>
        private string showName;
        private decimal bookingFee;

        /// <summary>
        ///  Constructor for Family Ticket
        /// </summary>
        /// <param name="bookingfee">The booking fee to be applied.</param>
        /// <param name="showname">The show for which the ticket is for.</param>
        public FamilyTicket(string showName, decimal bookingFee) {
            this.showName = showName;
            this.bookingFee = bookingFee;
        }

        /// <summary>
        ///  Read encapsulation for Cost.
        /// </summary>
        public decimal Cost {
            get { return (AdultTicket.BASE_COST * 3 + this.bookingFee); }
        }

        /// <summary>
        /// Prints how many tickets are booked, for what show and what the cost comes to.
        /// </summary>
        public string Print() {
            return string.Format("Family ticket for {0} - {1:c}\n", showName, Cost);
        }
    }
}
