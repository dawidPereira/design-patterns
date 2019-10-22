using System;
using DesignPatterns.CreationalPattern.Singleton;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity
{
    public abstract class Demo
    {
        protected readonly IServiceProvider ServiceProvider;

        protected Demo()
        {
            ServiceProvider = ServiceProviderInstance.GetInstance().GetServiceProvider();
        }

        public void ShowDemo(string demoName)
        {
            ShowStartDemoMessage(demoName);
            ProcessDemo();
            ShowEndDemoMessage(demoName);
        }

        protected virtual void ProcessDemo()
        {
            Console.WriteLine("Basic Demo Message.");
        }

        protected void ShowStartDemoMessage(string demoName)
        {
            Console.WriteLine($"Starting {demoName} Demo!");
            Console.WriteLine();
        }

        protected void ShowEndDemoMessage(string demoName)
        {
            Console.WriteLine();
            Console.WriteLine($"Ending {demoName} Demo!");
            ShowSeparator();
            Console.WriteLine();
        }

        private void ShowSeparator()
        {
            Console.WriteLine("==================================================");
        }
    }
}
