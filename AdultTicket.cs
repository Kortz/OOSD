
namespace GCUShows
{
    class AdultTicket : ITicket {
        /// <summary>
        ///  Declaration of instance variables.
        public static decimal BASE_COST = 10.0m;
        private string showName;
        private decimal bookingFee;

        /// <summary>
        ///  Constructor for AdultTicket.
        /// </summary>
        /// <param name="bookingfee">The booking fee to be applied.</param>
        /// <param name="showname">The show for which the ticket is for.</param>
        public AdultTicket(string showname, decimal bookingfee) {
            this.showName = showname;
            this.bookingFee = bookingfee;
        }

        /// <summary>
        ///  Calculates the cost of the ticket.
        /// </summary>
        public decimal Cost {
            get { return (AdultTicket.BASE_COST + bookingFee); }
        }

        /// <summary>
        ///  Prints how many tickets are booked, for what show and what the cost comes to.
        /// </summary>
        public string Print() {
            return string.Format("Adult ticket for {0} - {1:c}\n", showName, Cost);
        }
    }
}
