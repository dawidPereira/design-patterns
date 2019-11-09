using System;

namespace DesignPatterns.BehavioralPattern.ChainOfResponsibility
{
    public interface IHandler
    {
        void SetNext(IHandler handler);

        void Handle(object request);
    }

    public abstract class Handler : IHandler
    { 
        protected IHandler nextHandler;

        public virtual void Handle(object request)
        {
            if (nextHandler != null)
            {
                nextHandler.Handle(request);
            }
            else
            {
                return;
            }
        }

        public void SetNext(IHandler handler)
        {
            nextHandler = handler;
        }
    }

    public class Booking
    {
        public BookingType BookingType { get; }

        public Booking(BookingType bookingType)
        {
            BookingType = bookingType;
        }
    }

    public enum BookingType
    {
        Normal,
        Group,
        Special
    }

    public class NormalBookingHandler : Handler
    {
        public override void Handle(object request)
        {
            var booking = request as Booking;

            if(booking.BookingType == BookingType.Normal)
            {
                Console.WriteLine($"{GetType()} handled {booking.BookingType.ToString()} booking.");
                return;
            }

            base.Handle(request);
        }
    }

    public class GroupBookingHandler : Handler
    {
        public override void Handle(object request)
        {
            var booking = request as Booking;

            if (booking.BookingType == BookingType.Group)
            {
                Console.WriteLine($"{GetType()} handled {booking.BookingType.ToString()} booking.");
                return;
            }

            base.Handle(request);
        }
    }

    public class SpecialBookingHandler : Handler
    {
        public override void Handle(object request)
        {
            var booking = request as Booking;

            if (booking.BookingType == BookingType.Special)
            {
                Console.WriteLine($"{GetType()} handled {booking.BookingType.ToString()} booking.");
                return;
            }

            base.Handle(request);
        }
    }
}
