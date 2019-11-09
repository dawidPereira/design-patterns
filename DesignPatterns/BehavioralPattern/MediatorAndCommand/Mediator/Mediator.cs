using DesignPatterns.BehavioralPattern.MediatorAndCommand.Command;
using DesignPatterns.StructuralPattern.Common.Enum;

namespace DesignPatterns.BehavioralPattern.MediatorAndCommand.Mediator
{
    public class Mediator : IMediator
    {
        private readonly AttackCommand _command;

        public Mediator(AttackCommand command)
        {
            _command = command;
            _command.SetMediator(this);
        }
        public void Handle()
        {
            switch (_command.MonsterBehavior)
            {
                case MonsterBehavior.Fire:
                    new FireAttackCommandHandler().Handle();
                    break;

                case MonsterBehavior.Water:
                    new WaterAttackCommandHandler().Handle();
                    break;
            }
        }
    }
}