namespace DesignPatterns.BehavioralPattern.Observer
{
    public interface IObservable<out T>
    {
        void Subscribe(IObserver<T> subscriber);

        void Unsubscribe(IObserver<T> subscriber);
    }
}
