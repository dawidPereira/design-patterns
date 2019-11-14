using System.Collections.Generic;

namespace DesignPatterns.BehavioralPattern.Strategy.Strategies
{
    public interface IReadingStrategy
    {
        void Read(IEnumerable<string> readingList);
    }
}
