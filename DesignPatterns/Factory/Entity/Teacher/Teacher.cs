using System;

namespace DesignPatterns.Factory.Entity.Teacher
{
    public class Teacher
    {
        public virtual void Greetings()
        {
            Console.WriteLine("Greetings from basic teacher.");
        }
    }
}
