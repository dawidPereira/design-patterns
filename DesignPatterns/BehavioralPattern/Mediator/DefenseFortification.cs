using System;

namespace DesignPatterns.BehavioralPattern.Mediator
{
    public class DefenseFortification : Colleague
    {
        public DefenseFortification(Mediator mediator) : base(mediator)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine("Defense fortification sends message: " + message);
            base.Send(message);
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Defense fortification gets message: " + message);
        }
    }
}