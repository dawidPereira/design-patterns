namespace DesignPatterns.BehavioralPattern.Command.Handler
{
    public interface ICommandHandler
    {
        void Handle<T>(T command);
    }
}