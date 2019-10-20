using System;

namespace DesignPatterns.FactoryMethod
{
    public class EnglishStudent : Student
    {
        private EnglishStudent()
        {

        }

        public override void Greetings()
        {
            Console.WriteLine("Hello");
        }

        public static Student Create()
        {
            var student = new EnglishStudent();
            // Do some specific actions
            return student;
        }
    }
}
