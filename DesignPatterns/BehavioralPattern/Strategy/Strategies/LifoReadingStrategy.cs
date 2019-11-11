using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.BehavioralPattern.Strategy.Strategies
{
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
}