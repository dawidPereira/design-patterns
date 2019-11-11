using DesignPatterns.BehavioralPattern.ChainOfResponsibility;
using DesignPatterns.BehavioralPattern.ChainOfResponsibility.Handlers;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.BehavioralPattern
{
    public class ChainOfResponsibilityDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var normalBookingHandler = new NormalBookingHandler();
            var groupBookingHandler = new GroupBookingHandler();
            var specialBookingHandler = new SpecialBookingHandler();

            specialBookingHandler.SetNext(groupBookingHandler);
            groupBookingHandler.SetNext(normalBookingHandler);

            var booking = new Booking(BookingType.Special);

            specialBookingHandler.Handle(booking);
        }
    }
}
