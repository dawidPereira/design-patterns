using System;

namespace DesignPatterns.StructuralPattern.Proxy
{
    public class LoginService : ILoginService
    {
        public void LogIn()
        {
            Console.Write("LogIn service is running.");
        }
    }
}