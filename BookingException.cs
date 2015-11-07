using System;

namespace GCUShows
{
    public class BookingException : Exception {
        private int id;

        /// <summary>
        ///  Read encapsulation for id
        /// </summary>
        public int Id { 
            get { return id;  } 
        }

        /// <summary>
        ///  Constructor for BookingException which sets the id of the exception.
        /// </summary>
        /// <param name="bookingid">The bookingID that caused the exception to trigger.</param>
        public BookingException(int bookingid) {
            this.id = bookingid;
        }
    }
}
