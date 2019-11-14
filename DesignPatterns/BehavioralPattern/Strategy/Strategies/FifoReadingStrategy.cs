using System;
using System.Collections.Generic;

namespace DesignPatterns.BehavioralPattern.Strategy.Strategies
{
    public class FifoReadingStrategy : IReadingStrategy
    {
        public void Read(IEnumerable<string> readingList)
        {
            foreach (var item in readingList)
            {
                Console.WriteLine(item);
            }
        }
    }
}