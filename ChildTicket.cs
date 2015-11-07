
namespace GCUShows
{
    public class ChildTicket : ITicket {
        /// <summary>
        ///  Declaration of instance variables.
        /// </summary>
        private string showName;

        /// <summary>
        ///  Read encapsulation for Cost.
        /// </summary>
        public decimal Cost {
            get { return AdultTicket.BASE_COST * 0.75M; }
        }

        /// <summary>
        ///  Constructor for ChildTicket.
        /// </summary>
        /// <param name="showName">The show for which the ticket is for.</param>
        public ChildTicket(string showName) {
            this.showName = showName;
        }

        /// <summary>
        /// Prints how many tickets are booked, for what show and what the cost comes to.
        /// </summary>
        public string Print() {
            return string.Format("Child ticket for {0} - {1:c}\n", showName, Cost);
        }
    }
}
