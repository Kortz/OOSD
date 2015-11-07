using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GCUShows;


namespace GCUShowsGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Show show;
        ObservableCollection<Booking> bookings;

        public MainWindow()
        {
            InitializeComponent();
            show = new Show("Les Miserables");
            bookings = new ObservableCollection<Booking>();
            DataContext = show;
            lstBookings.ItemsSource = bookings;
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            try {
                Booking booking = new Booking(show);

                decimal fee = 0.0M;
                if (cmbType.Text == "Credit Card")
                    fee = 1.0M;

                int adult = Convert.ToInt32(txtAdult.Text);
                booking.AddTickets(adult, TicketType.Adult, fee);
                int child = Convert.ToInt32(txtChild.Text);
                booking.AddTickets(child, TicketType.Child, fee);
                int family = Convert.ToInt32(txtFamily.Text);
                booking.AddTickets(family, TicketType.Family, fee);

                bookings.Add(booking);

                txtAdult.Text = "0";
                txtChild.Text = "0";
                txtFamily.Text = "0";
                txtTakings.Text = "Takings: " + show.Takings();

                MessageBox.Show(booking.PrintTickets());
            }
            catch(FormatException) {
                MessageBox.Show("Invalid number of tickets!");
                Console.WriteLine("Invalid number of tickets!");
            }
            catch(BookingException ex) {
                MessageBox.Show("Limit of tickets exceded!");
                Console.WriteLine("Limit of tickets exceded!");
                show.removeBooking(ex.Id); 
            }   
        }
    }
}
