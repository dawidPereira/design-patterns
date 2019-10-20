﻿using System;

namespace DesignPatterns.FactoryMethod
{
    public class PolishStudent : Student
    {
        private PolishStudent()
        {

        }

        public override void Greetings()
        {
            Console.WriteLine("Dzień dobry");
        }

        public static Student Create()
        {
            var student = new PolishStudent();
            // Do some specific actions
            return student;
        }
    }
}
