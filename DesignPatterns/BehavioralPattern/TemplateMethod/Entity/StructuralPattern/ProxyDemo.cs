using DesignPatterns.StructuralPattern.Proxy;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.StructuralPattern
{
    public class ProxyDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var logInProxy = new LoginProxy(new LoginService());

            for (int i = 0; i <= 3; i++)
            {
                logInProxy.LogIn();
            }
        }
    }
}