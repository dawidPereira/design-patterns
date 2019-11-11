using DesignPatterns.BehavioralPattern.Command;
using DesignPatterns.BehavioralPattern.Command.Mediator;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.BehavioralPattern
{
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