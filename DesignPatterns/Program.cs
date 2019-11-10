using System;
using DesignPatterns.BehavioralPattern;
using DesignPatterns.CreationalPattern;
using DesignPatterns.CreationalPattern.Singleton;
using DesignPatterns.StructuralPattern;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ServiceProviderInstance.GetInstance().GetServiceProvider();
            var creationalPatter = serviceProvider.GetService<ICreationalPattern>();
            var structuralPatter = serviceProvider.GetService<IStructuralPattern>();
            var behavioralPattern = serviceProvider.GetService<IBehavioralPattern>();

            creationalPatter.ShowDemo();
            structuralPatter.ShowDemo();
            behavioralPattern.ShowDemo();

            Console.ReadKey();
        }
    }
}
