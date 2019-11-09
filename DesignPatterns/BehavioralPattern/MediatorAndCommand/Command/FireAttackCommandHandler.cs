using System;

namespace DesignPatterns.BehavioralPattern.MediatorAndCommand.Command
{
    public class FireAttackCommandHandler : ICommandHandler
    {
        public void Handle()
        {
            Console.WriteLine("Fireball from FireAttackCommandHandler.");
        }
    }
}