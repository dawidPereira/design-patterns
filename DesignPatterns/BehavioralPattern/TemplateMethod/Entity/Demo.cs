using System;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity
{
    public abstract class Demo
    {
        protected readonly IServiceProvider ServiceProviderInstance;

        protected Demo()
        {
            ServiceProviderInstance = CreationalPattern.Singleton.ServiceProviderInstance.GetServiceProvider();

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
