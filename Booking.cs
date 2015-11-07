using System.Collections.Generic;

namespace GCUShows
{
    public class Booking {
        /// <summary>
        ///  Declaration of instance variables.
        /// </summary>
        private const int LIMIT = 6;
        Show show;
        private int bookingID;
        public List<ITicket> tickets;

        /// <summary>
        ///  Read/Write encapsulation fo bookingID.
        /// </summary>
        public int BookingID {
            get { return bookingID; }
            set { bookingID = value; }
        }

        /// <summary>
        ///  Constructor for Booking, creates a booking with a unique bookingID, adds the booking to the specified show and creates a new list of tickets for the booking.
        /// </summary>
        /// <param name="show">The show the booking is created for.</param>
        public Booking(Show show) {
            this.BookingID = BookingIDSequence.Instance.NextID;
            this.show = show;
            show.AddBooking(this);
            this.tickets = new List<ITicket>();
        }

        /// <summary>
        ///  Adds the tickets specified to the tickets List, if the number of tickets exceeds the booking.LIMIT value then an exception is thrown.
        /// </summary>
        /// <param name="fee">The booking fee.</param>
        /// <param name="number">The number of tickets to be booked.</param>
        /// <param name="type">The type of ticket to be added.</param>
        public void AddTickets(int number, TicketType type, decimal fee) {
            if (tickets.Count < Booking.LIMIT) {
                if (type == TicketType.Adult) {
                    for (int i = 0; i < number; i++) {
                        AdultTicket newTicket = new AdultTicket(show.Title, fee);
                        tickets.Add(newTicket);
                    }
                }

                else if (type == TicketType.Child) {
                    for (int i = 0; i < number; i++) {
                        ChildTicket newTicket = new ChildTicket(show.Title);
                        tickets.Add(newTicket);
                    }
                }
                else if (type == TicketType.Family) {
                    for (int i = 0; i < number; i++) {
                        FamilyTicket newTicket = new FamilyTicket(show.Title, fee);
                        tickets.Add(newTicket);
                    }
                }
            }
            else {
                throw new BookingException(this.BookingID);
            }
        }
        /// <summary>
        /// Prints the booking and total cost of booking + the info for each ticket in the tickets List.
        /// </summary>
        public string PrintTickets() {
            string ticketInfo = "Booking " + bookingID.ToString() + "\n";
            foreach (ITicket ticket in tickets) {
                ticketInfo += ticket.Print();
            }
            return ticketInfo;
        }

        /// <summary>
        ///  Calculates the total cost of all the tickets in the tickets List.
        /// </summary>
        /// <returns>decimal totalCost</returns>
        public decimal TotalCost() {
            decimal totalCost = 0;
            foreach (ITicket ticket in tickets) {
                totalCost = totalCost + ticket.Cost;
            }
            return totalCost;
        }

        /// <summary>
        ///  Returns a string containing which booking it is as well as the total cost.
        /// </summary>
        public override string ToString() {
            return string.Format("{0}: Total Cost={1:c}", bookingID, TotalCost());
        }
    }
}
