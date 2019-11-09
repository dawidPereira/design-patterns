using System;

namespace DesignPatterns.BehavioralPattern.ChainOfResponsibility
{
    public class SpecialBookingHandler : Handler
    {
        public override void Handle(object request)
        {
            var booking = request as Booking;

            if (booking?.BookingType == BookingType.Special)
            {
                Console.WriteLine($"{GetType()} handled {booking.BookingType.ToString()} booking.");
                return;
            }

            base.Handle(request);
        }
    }
}