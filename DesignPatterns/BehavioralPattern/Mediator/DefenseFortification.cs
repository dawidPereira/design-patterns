using static System.Console;

namespace DesignPatterns.BehavioralPattern.Mediator
{
    public class DefenseFortification : Colleague
    {
        public DefenseFortification(Mediator mediator) : base(mediator)
        {
        }

        public override void Send(string message)
        {
            WriteLine("Defense fortification sends message: " + message);
            base.Send(message);
        }

        public override void Notify(string message) => WriteLine("Defense fortification gets message: " + message);
    }
}