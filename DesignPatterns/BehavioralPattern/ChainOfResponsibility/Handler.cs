namespace DesignPatterns.BehavioralPattern.ChainOfResponsibility
{
    public abstract class Handler : IHandler
    { 
        protected IHandler NextHandler;

        public virtual void Handle(object request) => NextHandler?.Handle(request);

        public void SetNext(IHandler handler)
        {
            NextHandler = handler;
        }
    }
}