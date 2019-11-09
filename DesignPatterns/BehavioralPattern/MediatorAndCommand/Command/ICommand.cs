using DesignPatterns.BehavioralPattern.MediatorAndCommand.Mediator;

namespace DesignPatterns.BehavioralPattern.MediatorAndCommand.Command
{
    public interface ICommand
    {
        void SetMediator(IMediator mediator);
    }
}
