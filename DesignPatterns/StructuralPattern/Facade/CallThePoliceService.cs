using System;

namespace DesignPatterns.StructuralPattern.Facade
{
    public class CallThePoliceService
    {
        public void CallThePolice()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Unauthorized! Facebook police is coming!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
