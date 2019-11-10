namespace DesignPatterns.BehavioralPattern.Observer
{
    public interface IObservable<T>
    {
        void Subscribe(IObserver<T> subscriber);

        void Unsubscribe(IObserver<T> subscriber);
    }
}
