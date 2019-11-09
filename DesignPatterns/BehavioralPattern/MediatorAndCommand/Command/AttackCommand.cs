using DesignPatterns.BehavioralPattern.MediatorAndCommand.Mediator;
using DesignPatterns.StructuralPattern.Common.Enum;

namespace DesignPatterns.BehavioralPattern.MediatorAndCommand.Command
{
    public class AttackCommand : ICommand
    {
        private IMediator _mediator;

        public AttackCommand(MonsterBehavior monsterBehavior)
        {
            MonsterBehavior = monsterBehavior;
        }

        public MonsterBehavior MonsterBehavior{ get; set; }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}