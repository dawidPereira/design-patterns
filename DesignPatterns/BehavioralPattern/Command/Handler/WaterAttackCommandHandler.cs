using System;

namespace DesignPatterns.BehavioralPattern.Command.Handler
{
    public class WaterAttackCommandHandler : ICommandHandler
    {
        public void Handle<T>(T command)
        {
            Console.WriteLine("Waterball from WaterAttackCommandHandler.");
        }
    }
}