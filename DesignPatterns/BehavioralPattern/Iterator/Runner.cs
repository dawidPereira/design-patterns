using System;

namespace DesignPatterns.BehavioralPattern.Iterator
{
    public class Runner
    {
        public string Name { get; set; }

        public Runner(string name) => Name = name;

        public void Greetings(int place) => Console.WriteLine(
            $"I'm {Name} and I took {place + 1} place in this race!");
    }
}
