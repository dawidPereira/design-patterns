using System;

namespace DesignPatterns.Factory.Entity.Teacher
{
    public class PolishTeacher : Teacher
    {
        private PolishTeacher()
        {

        }

        public override void Greetings()
        {
            Console.WriteLine("Hello, I'm teacher form England.");
        }

        public static Teacher Create()
        {
            var teacher = new PolishTeacher();
            // Do some specific actions
            return teacher;
        }
    }
}
