using System.Buffers.Text;
using DesignPatterns.BehavioralPattern.Command.Mediator;
using DesignPatterns.StructuralPattern.Common.Enum;

namespace DesignPatterns.BehavioralPattern.Command
{
    public abstract class AttackCommand : ICommand<AttackCommand>
    {
        protected AttackCommand(MonsterBehavior monsterBehavior)
        {
            MonsterBehavior = monsterBehavior;
        }

        protected MonsterBehavior MonsterBehavior{ get; set; }
    }
}