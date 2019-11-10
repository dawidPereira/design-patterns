using System.Collections.Generic;
using DesignPatterns.BehavioralPattern.Strategy;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.BehavioralPattern
{
    public class StrategyDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var reader = new Reader(new FifoReadingStrategy());

            var readingList = new List<string>
            {
                "First",
                "Second",
                "Third"
            };

            reader.Read(new List<string>());
            reader.Read(readingList);
            reader.SetStrategy(new LifoReadingStrategy());
            reader.Read(readingList);
        }
    }
}