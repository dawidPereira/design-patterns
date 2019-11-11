namespace DesignPatterns.BehavioralPattern.Command.Mediator
{
    public interface IMediator
    {
        void Handle<T>(T command);
    }
}
