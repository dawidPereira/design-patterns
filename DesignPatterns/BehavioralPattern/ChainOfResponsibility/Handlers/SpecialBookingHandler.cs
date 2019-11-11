using System;

namespace DesignPatterns.BehavioralPattern.ChainOfResponsibility.Handlers
{
    public class SpecialBookingHandler : Handler<Booking>
    {
        public override void Handle(Booking booking)
        {
            if (booking.BookingType == BookingType.Special)
            {
                Console.WriteLine($"{GetType()} handled {booking.BookingType.ToString()} booking.");
                booking.BookingType = BookingType.Group;
            }

            base.Handle(booking);
        }
    }
}