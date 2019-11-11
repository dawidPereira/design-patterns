using System;

namespace DesignPatterns.BehavioralPattern.Mediator
{
    public class ControlRoom : Colleague
    {
        public ControlRoom(Mediator mediator) : base(mediator)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine("Control room sends message: " + message);
            base.Send(message);
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Control room gets message: " + message);
        }
    }
}