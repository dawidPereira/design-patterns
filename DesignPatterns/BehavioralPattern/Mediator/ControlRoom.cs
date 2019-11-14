using static System.Console;

namespace DesignPatterns.BehavioralPattern.Mediator
{
    public class ControlRoom : Colleague
    {
        public ControlRoom(Mediator mediator) : base(mediator)
        {
        }

        public override void Send(string message)
        {
            WriteLine("Control room sends message: " + message);
            base.Send(message);
        }

        public override void Notify(string message) => WriteLine("Control room gets message: " + message);
    }
}