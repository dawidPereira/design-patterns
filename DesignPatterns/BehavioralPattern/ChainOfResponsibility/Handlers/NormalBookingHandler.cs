using System;

namespace DesignPatterns.BehavioralPattern.ChainOfResponsibility.Handlers
{
    public class NormalBookingHandler : Handler<Booking>
    {
        public override void Handle(Booking booking)
        {
            if(booking.BookingType == BookingType.Normal)
            {
                Console.WriteLine($"{GetType()} handled {booking.BookingType.ToString()} booking.");
            }

            base.Handle(booking);
        }
    }
}