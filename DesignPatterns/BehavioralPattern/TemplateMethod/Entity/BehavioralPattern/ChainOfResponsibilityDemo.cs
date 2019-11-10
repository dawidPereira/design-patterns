using DesignPatterns.BehavioralPattern.ChainOfResponsibility;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.BehavioralPattern
{
    public class ChainOfResponsibilityDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var normalBookingHandler = new NormalBookingHandler();
            var groupBookingHandler = new GroupBookingHandler();
            var specialBookingHandler = new SpecialBookingHandler();

            normalBookingHandler.SetNext(groupBookingHandler);
            groupBookingHandler.SetNext(specialBookingHandler);

            var booking = new Booking(BookingType.Special);

            normalBookingHandler.Handle(booking);
        }
    }
}
