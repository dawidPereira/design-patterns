using System;

namespace DesignPatterns.CreationalPattern.Factory.Entity.Student
{
    public abstract class Student
    {
        public virtual void Greetings()
        {
            Console.WriteLine("Greetings from basic student");
        }
    }
}
