using DesignPatterns.BehavioralPattern.MediatorAndCommand.Command;
using DesignPatterns.BehavioralPattern.MediatorAndCommand.Mediator;
using DesignPatterns.StructuralPattern.Common.Enum;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.BehavioralPattern
{
    public class MediatorAndCommandDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var command = new AttackCommand(MonsterBehavior.Fire);
            var mediator = new Mediator(command);
            mediator.Handle();
        }
    }
}