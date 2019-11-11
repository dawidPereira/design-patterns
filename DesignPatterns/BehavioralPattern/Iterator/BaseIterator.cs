namespace DesignPatterns.BehavioralPattern.Iterator
{
    public class BaseIterator<T> : IIterator<T>
    {
        private readonly ICustomCollection<T> _collection;
        public int Current { get; private set; }

        public BaseIterator(ICustomCollection<T> collection)
        {
            _collection = collection;
        }

        public T First()
        {
            Current = 0;
            return _collection[Current];
        }

        public T Next()
        {
            Current++;
            return !IsDone ? _collection[Current] : default;
        }

        public T CurrentItem => _collection[Current];

        public bool IsDone => Current >= _collection.Count(); 
    }
}