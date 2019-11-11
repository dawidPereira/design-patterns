using DesignPatterns.BehavioralPattern.Command.Handler;
using DesignPatterns.StructuralPattern.Common.Enum;

namespace DesignPatterns.BehavioralPattern.Command.Mediator
{
    public class Mediator : IMediator
    {
        public void Handle<T>(T command)
        {
            if (command.GetType() == typeof(FireAttackCommand))
            {
                new FireAttackCommandHandler().Handle(command);
                return;
            }

            if (command.GetType() != typeof(FireAttackCommand))
            {
                return;
            }

            new WaterAttackCommandHandler().Handle(command);
        }
    }
}