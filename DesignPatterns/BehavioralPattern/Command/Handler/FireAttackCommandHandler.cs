using System;

namespace DesignPatterns.BehavioralPattern.Command.Handler
{
    public class FireAttackCommandHandler : ICommandHandler
    {
        public void Handle<T>(T command)
        {
            Console.WriteLine("Fireball from FireAttackCommandHandler.");
        }
    }
}