namespace DesignPatterns.BehavioralPattern.Mediator
{
    public interface IMediator
    {
        void SendMessage(string message, Colleague colleague);
    }
}