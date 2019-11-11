using DesignPatterns.BehavioralPattern.Mediator;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.BehavioralPattern
{
    using Mediator = Mediator.Mediator;

    public class MediatorDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var mediator = new Mediator();
            var controlRoom = new ControlRoom(mediator);
            var defenseFortification = new DefenseFortification(mediator);

            mediator.Attach(controlRoom);
            mediator.Attach(defenseFortification);

            controlRoom.Send("Full defense mode!");
            defenseFortification.Send("Defense mode activated!");
        }
    }
}
