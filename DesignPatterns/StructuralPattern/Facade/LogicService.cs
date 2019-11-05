using System;

namespace DesignPatterns.StructuralPattern.Facade
{
    public class LogicService
    {
        public void StartProcess()
        {
            Console.WriteLine("Starting process.");
        }

        public void ConfirmProcess()
        {
            Console.WriteLine("Confirming process.");
        }

        public void EndProcess()
        {
            Console.WriteLine("Ending process.");
        }
    }
}
