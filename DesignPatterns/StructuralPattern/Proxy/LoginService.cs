using System;

namespace DesignPatterns.StructuralPattern.Proxy
{
    public class LoginService : ILoginService
    {
        public void LogIn()
        {
            Console.WriteLine("LogIn service is running.");
        }
    }
}