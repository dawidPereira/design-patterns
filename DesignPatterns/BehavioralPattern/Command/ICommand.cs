using DesignPatterns.BehavioralPattern.Command.Mediator;

namespace DesignPatterns.BehavioralPattern.Command
{
    public interface ICommand<T> where T : ICommand<T>
    {
    }
}
