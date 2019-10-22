using System;

namespace DesignPatterns.CreationalPattern.Factory.Entity.Teacher
{
    public class EnglishTeacher : Teacher
    {
        private EnglishTeacher()
        {

        }

        public override void Greetings()
        {
            Console.WriteLine("Hello, I'm teacher form England.");
        }

        public static Teacher Create()
        {
            var teacher = new EnglishTeacher();
            // Do some specific actions
            return teacher;
        }
    }
}
