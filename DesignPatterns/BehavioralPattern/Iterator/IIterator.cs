namespace DesignPatterns.BehavioralPattern.Iterator
{
    public interface IIterator<out T>
    {
        T First();

        T Next();

        T CurrentItem { get; }

        bool IsDone { get; }
    }
}