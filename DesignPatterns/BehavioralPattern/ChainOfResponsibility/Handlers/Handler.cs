namespace DesignPatterns.BehavioralPattern.ChainOfResponsibility.Handlers
{
    public abstract class Handler<T> : IHandler<T>
    { 
        protected IHandler<T> NextHandler;

        public virtual void Handle(T request) => NextHandler?.Handle(request);

        public void SetNext(IHandler<T> handler) => NextHandler = handler;
    }
}