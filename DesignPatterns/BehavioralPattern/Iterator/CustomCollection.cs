using System.Collections;

namespace DesignPatterns.BehavioralPattern.Iterator
{
    public class CustomCollection<T> : ICustomCollection<T>
    {
        private readonly ArrayList _items = new ArrayList();

        public IIterator<T> CreateIterator()
        {
            return new BaseIterator<T>(this);
        }

        public int Count() => _items.Count; 

        public T this[int index]
        {
            get => (T) _items[index];
            set => _items.Add(value);
        }
    }
}