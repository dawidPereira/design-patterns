namespace DesignPatterns.BehavioralPattern.ChainOfResponsibility
{
    public class Booking
    {
        public BookingType BookingType { get; set; }

        public Booking(BookingType bookingType)
        {
            BookingType = bookingType;
        }
    }
}