using System;
using DesignPatterns.CreationalPattern.Interface;
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

            //creationalPatter.ShowDemo();
            structuralPatter.ShowDemo();

            Console.ReadKey();
        }
    }
}
