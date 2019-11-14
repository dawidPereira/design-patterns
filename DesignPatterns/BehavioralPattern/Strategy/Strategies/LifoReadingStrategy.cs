using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace DesignPatterns.BehavioralPattern.Strategy.Strategies
{
    public class LifoReadingStrategy : IReadingStrategy
    {
        public void Read(IEnumerable<string> readingList)
        {
            var reversedReadingList = readingList.Reverse();

            foreach (var item in reversedReadingList)
            {
                WriteLine(item);
            }
        }
    }
}