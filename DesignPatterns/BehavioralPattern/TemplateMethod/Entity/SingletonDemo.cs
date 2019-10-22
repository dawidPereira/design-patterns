using System;
using DesignPatterns.CreationalPattern.Singleton;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity
{
    public class SingletonDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var firstSimpleConfiguration = SimpleConfiguration.GetInstance();
            var lastSimpleConfiguration = SimpleConfiguration.GetInstance();

            Console.WriteLine(firstSimpleConfiguration == lastSimpleConfiguration);
        }
    }
}
