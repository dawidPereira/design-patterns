namespace DesignPatterns.BehavioralPattern.Iterator
{
    public interface ICustomCollection<out T>
    {
        IIterator<T> CreateIterator();

        T this[int current] { get; }

        int Count();

    }
}