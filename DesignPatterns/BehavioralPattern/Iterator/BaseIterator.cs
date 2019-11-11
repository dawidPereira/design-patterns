namespace DesignPatterns.BehavioralPattern.Iterator
{
    public class BaseIterator<T> : IIterator<T>
    {
        private readonly ICustomCollection<T> _collection;
        public int Index { get; private set; }

        public BaseIterator(ICustomCollection<T> collection)
        {
            _collection = collection;
        }

        public T First()
        {
            Index = 0;
            return _collection[Index];
        }

        public T Next()
        {
            Index++;
            return !IsDone ? _collection[Index] : default;
        }

        public T CurrentItem => _collection[Index];

        public bool IsDone => Index >= _collection.Count(); 
    }
}