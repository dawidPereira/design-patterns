using System;

namespace DesignPatterns.BehavioralPattern.MediatorAndCommand.Command
{
    public class WaterAttackCommandHandler : ICommandHandler
    {
        public void Handle()
        {
            Console.WriteLine("Waterball from WaterAttackCommandHandler.");
        }
    }
}