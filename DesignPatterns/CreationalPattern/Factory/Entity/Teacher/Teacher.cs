using System;

namespace DesignPatterns.CreationalPattern.Factory.Entity.Teacher
{
    public class Teacher
    {
        public virtual void Greetings()
        {
            Console.WriteLine("Greetings from basic teacher.");
        }
    }
}
