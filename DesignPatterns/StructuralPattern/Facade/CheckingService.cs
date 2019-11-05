using System;

namespace DesignPatterns.StructuralPattern.Facade
{
    public class CheckingService
    {
        public void CheckUserName()
        {
            Console.WriteLine("User name checked");
        }

        public void CheckPassword()
        {
            Console.WriteLine("Password checked");
        }

        public void CheckStatus()
        {
            Console.WriteLine("Status checked");
        }
    }
}
