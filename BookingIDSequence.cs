
namespace GCUShows
{
    public class BookingIDSequence
    {
        private int nextIDNumber;

        public BookingIDSequence()
        {
            nextIDNumber = 1;
        }

        public int NextID
        {
            get
            {
                return nextIDNumber++;
            }

        }

        public void Reset()
        {
            nextIDNumber = 1;
        }

        private static BookingIDSequence instance = null;

        public static BookingIDSequence Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookingIDSequence();
                }
                return instance;
            }
        }
    }
}
