using System;

namespace DesignPatterns.StructuralPattern.Proxy
{
    public class LoginProxy : ILoginService
    {
        private int _attempt = 0;

        private readonly ILoginService _loginService;

        public LoginProxy(ILoginService loginService)
        {
            _loginService = loginService;
        }

        public void LogIn()
        {
            if (_attempt >= 3)
            {
                Console.WriteLine("Facebook police is coming for You!");
                return;
            }

            _loginService.LogIn();
            _attempt++;
            Console.WriteLine("Unauthorized!");
        }
    }
}