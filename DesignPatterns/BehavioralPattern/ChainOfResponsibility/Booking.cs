namespace DesignPatterns.BehavioralPattern.ChainOfResponsibility
{
    public class Booking
    {
        public BookingType BookingType { get; }

        public Booking(BookingType bookingType)
        {
            BookingType = bookingType;
        }
    }
}