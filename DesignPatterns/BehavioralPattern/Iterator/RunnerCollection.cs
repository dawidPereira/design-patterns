using System.Collections;

namespace DesignPatterns.BehavioralPattern.Iterator
{
    public class RunnerCollection : IRunnerCollection
    {
        private readonly ArrayList _items = new ArrayList();

        public RunnerIterator CreateIterator()
        {
            return new RunnerIterator(this);
        }

        public int Count => _items.Count; 

        public object this[int index]
        {
            get => _items[index];
            set => _items.Add(value);
        }
    }
}