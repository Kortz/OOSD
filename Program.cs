using System;
using GCUShows;

namespace GCUShowsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Show show1 = new Show("Les Miserables");
            Console.WriteLine("CREATED SHOW: {0}", show1.Title);
            
            Booking b1 = new Booking(show1);
            b1.AddTickets(1, TicketType.Adult, 0.0M);
            Console.WriteLine("BOOKING for 1 adult (no fee) - Cost {0:c}", b1.TotalCost());
            Console.WriteLine(b1.PrintTickets());

            Booking b2 = new Booking(show1);
            b2.AddTickets(1, TicketType.Adult, 1.0M);
            Console.WriteLine("BOOKING for 1 adult (with fee) - Cost {0:c}", b2.TotalCost());
            Console.WriteLine(b2.PrintTickets());

            Booking b3 = new Booking(show1);
            b3.AddTickets(2, TicketType.Adult, 1.0M);
            b3.AddTickets(2, TicketType.Child, 1.0M);
            Console.WriteLine("BOOKING for 2 adults + 2 children (with fee) - Cost {0:c}", b3.TotalCost());
            Console.WriteLine(b3.PrintTickets());

            Booking b4 = new Booking(show1);
            b4.AddTickets(1, TicketType.Family, 1.0M);
            Console.WriteLine("BOOKING for 1 family (with fee) - Cost {0:c}", b4.TotalCost());
            Console.WriteLine(b4.PrintTickets());

            Console.WriteLine("TOTAL TAKINGS: {0:c}", show1.Takings()); 

            Console.ReadLine();

        }
    }
}
