using System.Collections.Generic;

namespace GCUShows
{
    public class Show {
        /// <summary>
        ///  Declaration of instance variables.
        /// </summary>
        private string title;
        private Dictionary<int, Booking> bookings;

        /// <summary>
        ///  Read/Write encapsulation for title.
        /// </summary>
        public string Title {
            get { return title; }
            set { title = value; }
        }

        /// <summary>
        ///  Constructor for Show.
        /// </summary>
        /// <param name="title">The title of the show.</param>
        public Show(string title) {
            this.title = title;
            this.bookings = new Dictionary<int, Booking>();
        }

        /// <summary>
        ///  Adds a booking to the bookings dictionary.
        /// </summary>
        /// <param name="booking">The booking to be added.</param>
        public void AddBooking(Booking booking) {
            bookings.Add(booking.BookingID, booking);
        }

        /// <summary>
        ///  Removes a booking from the bookings dictionary.
        /// </summary>
        /// <param name="bookingid">The booking to be removed.</param>
        public void removeBooking(int bookingid) {
            bookings.Remove(bookingid);
        }

        /// <summary>
        ///  Calculates the total takings of the show by looping through the dictionary and adding up the costs of each booking.
        /// </summary>
        public decimal Takings() { 
            decimal totalCost = 0;
            for(int i = 1; i <= bookings.Count; i++) {
                Booking booking = bookings[i];
                totalCost = totalCost + booking.TotalCost();
            }
            return totalCost;
        }
    }
}
