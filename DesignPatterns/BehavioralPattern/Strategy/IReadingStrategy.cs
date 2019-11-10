using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.BehavioralPattern.Strategy
{
    public interface IReadingStrategy
    {
        void Read(ICollection<string> readingList);
    }

    public class FifoReadingStrategy : IReadingStrategy
    {
        public void Read(ICollection<string> readingList)
        {
            foreach (var item in readingList)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class LifoReadingStrategy : IReadingStrategy
    {
        public void Read(ICollection<string> readingList)
        {
            var reversedReadingList = readingList.Reverse();

            foreach (var item in reversedReadingList)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Reader
    {
        private IReadingStrategy _readingStrategy;

        public Reader(IReadingStrategy readingStrategy)
        {
            _readingStrategy = readingStrategy;
        }

        public void SetStrategy(IReadingStrategy readingStrategy)
        {
            _readingStrategy = readingStrategy;
        }

        public void Read(ICollection<string> readingList)
        {
            if (readingList.Count == 0)
            {
                Console.WriteLine("Can't read empty list.");
                return;
            }

            _readingStrategy.Read(readingList);

            Console.WriteLine("Done!");
        }
    }
}
