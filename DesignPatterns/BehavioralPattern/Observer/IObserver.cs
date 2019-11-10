namespace DesignPatterns.BehavioralPattern.Observer
{
    public interface IObserver<in T>
    {
        void Notify(T item);
    }
}