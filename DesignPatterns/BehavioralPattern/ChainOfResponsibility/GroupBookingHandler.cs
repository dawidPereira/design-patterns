using System;

namespace DesignPatterns.BehavioralPattern.ChainOfResponsibility
{
    public class GroupBookingHandler : Handler
    {
        public override void Handle(object request)
        {
            var booking = request as Booking;

            if (booking?.BookingType == BookingType.Group)
            {
                Console.WriteLine($"{GetType()} handled {booking.BookingType.ToString()} booking.");
                return;
            }

            base.Handle(request);
        }
    }
}