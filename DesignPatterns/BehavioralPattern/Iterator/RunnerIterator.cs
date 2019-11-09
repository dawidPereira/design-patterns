namespace DesignPatterns.BehavioralPattern.Iterator
{
    public class RunnerIterator : IRunnerIterator
    {
        private readonly RunnerCollection _runnerCollection;
        public int Current { get; private set; }

        public RunnerIterator(RunnerCollection runnerCollection)
        {
            _runnerCollection = runnerCollection;
        }

        public Runner First()
        {
            Current = 0;
            return _runnerCollection[Current] as Runner;
        }

        public Runner Next()
        {
            Current++;

            if (!IsDone)
            {
                return _runnerCollection[Current] as Runner;
            }

            return null;
        }

        public Runner CurrentRunner => _runnerCollection[Current] as Runner;

        public bool IsDone => Current >= _runnerCollection.Count; 
    }
}