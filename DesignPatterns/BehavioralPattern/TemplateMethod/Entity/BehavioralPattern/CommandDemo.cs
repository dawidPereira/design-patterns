using DesignPatterns.BehavioralPattern.Command;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.BehavioralPattern
{
    using Mediator = Command.Mediator.Mediator;

    public class CommandDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var mediator = new Mediator();
            var command = new FireAttackCommand();

            mediator.Handle(command);
        }
    }
}