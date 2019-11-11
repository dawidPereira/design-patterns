using System;

namespace DesignPatterns.BehavioralPattern.ChainOfResponsibility.Handlers
{
    public class GroupBookingHandler : Handler<Booking>
    {
        public override void Handle(Booking booking)
        {
            if (booking.BookingType == BookingType.Group)
            {
                Console.WriteLine($"{GetType()} handled {booking.BookingType.ToString()} booking.");
            }

            base.Handle(booking);
        }
    }
}