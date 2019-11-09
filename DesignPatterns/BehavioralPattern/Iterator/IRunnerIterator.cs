namespace DesignPatterns.BehavioralPattern.Iterator
{
    public interface IRunnerIterator
    {
        Runner First();
        Runner Next();
        Runner CurrentRunner { get; }
        bool IsDone { get; }
    }
}