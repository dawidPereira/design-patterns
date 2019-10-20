using System;

namespace DesignPatterns.FactoryMethod
{
    public abstract class Student
    {
        public virtual void Greetings()
        {
            Console.WriteLine("Greetings from basic student");
        }
    }
}
