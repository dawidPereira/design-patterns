using System;

namespace DesignPatterns.BehavioralPattern.ChainOfResponsibility
{
    public class NormalBookingHandler : Handler
    {
        public override void Handle(object request)
        {
            var booking = request as Booking;

            if(booking?.BookingType == BookingType.Normal)
            {
                Console.WriteLine($"{GetType()} handled {booking.BookingType.ToString()} booking.");
                return;
            }

            base.Handle(request);
        }
    }
}