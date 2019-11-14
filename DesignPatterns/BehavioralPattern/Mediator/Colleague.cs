namespace DesignPatterns.BehavioralPattern.Mediator
{
    public abstract class Colleague
    {
        private readonly Mediator _mediator;

        protected Colleague(Mediator mediator) => _mediator = mediator;

        public abstract void Notify(string message);

        public virtual void Send(string message) => _mediator.SendMessage(message, this);
    }
}