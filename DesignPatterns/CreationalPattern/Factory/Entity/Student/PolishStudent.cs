﻿using System;

namespace DesignPatterns.CreationalPattern.Factory.Entity.Student
{
    public class PolishStudent : Student
    {
        private PolishStudent()
        {

        }

        public override void Greetings()
        {
            Console.WriteLine("Dzień dobry, jestem studentem z Polski.");
        }

        public static Student Create()
        {
            var student = new PolishStudent();
            // Do some specific actions
            return student;
        }
    }
}
