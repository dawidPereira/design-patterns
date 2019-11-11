using System;
using System.Collections.Generic;
using DesignPatterns.BehavioralPattern.Strategy.Strategies;

namespace DesignPatterns.BehavioralPattern.Strategy
{
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