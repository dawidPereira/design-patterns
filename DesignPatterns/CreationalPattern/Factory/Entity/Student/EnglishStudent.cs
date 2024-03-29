﻿using System;

namespace DesignPatterns.CreationalPattern.Factory.Entity.Student
{
    public class EnglishStudent : Student
    {
        private EnglishStudent()
        {

        }

        public override void Greetings()
        {
            Console.WriteLine("Hello, I'm student form England.");
        }

        public static Student Create()
        {
            var student = new EnglishStudent();
            // Do some specific actions
            return student;
        }
    }
}
