using System.Collections.Generic;

namespace DesignPatterns.BehavioralPattern.Observer
{
    public abstract class Observable<T> : IObservable<T>
    {
        private readonly HashSet<IObserver<T>> _subscribers = new HashSet<IObserver<T>>();

        public void Subscribe(IObserver<T> subscriber) => _subscribers.Add(subscriber);

        public void Unsubscribe(IObserver<T> subscriber) => _subscribers.Remove(subscriber);

        protected void Notify(T item)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Notify(item);
            }
        }
    }
}