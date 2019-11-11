namespace DesignPatterns.BehavioralPattern.ChainOfResponsibility.Handlers
{
    public interface IHandler<T>
    {
        void SetNext(IHandler<T> handler);

        void Handle(T request);
    }
}
