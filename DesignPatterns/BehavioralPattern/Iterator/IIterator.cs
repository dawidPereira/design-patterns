namespace DesignPatterns.BehavioralPattern.Iterator
{
    public interface IIterator<out T>
    {
        T First();

        T Next();

        T CurrentItem { get; }

        int Index { get; }

        bool IsDone { get; }
    }
}