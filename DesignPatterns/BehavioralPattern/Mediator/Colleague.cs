namespace DesignPatterns.BehavioralPattern.Mediator
{
    public abstract class Colleague
    {
        protected Mediator Mediator;

        protected Colleague(Mediator mediator)
        {
            Mediator = mediator;
        }

        public abstract void Notify(string message);

        public virtual void Send(string message)
        {
            Mediator.SendMessage(message, this);
        }
    }
}