using DesignPatterns.BehavioralPattern.Iterator;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.BehavioralPattern
{
    public class IteratorDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var runnerCollection = new RunnerCollection
            {
                [0] = new Runner("Johan"),
                [1] = new Runner("Eduardo"),
                [2] = new Runner("Luciel"),
                [3] = new Runner("Bard")
            };

            var runnerIterator = runnerCollection.CreateIterator();

            for (var runner = runnerIterator.First();
                !runnerIterator.IsDone;
                runner = runnerIterator.Next())
            {
                runner.Greetings(runnerIterator.Current);
            }
        }
    }
}