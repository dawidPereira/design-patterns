using System;
using DesignPatterns.CreationalPattern.Interface;
using DesignPatterns.CreationalPattern.Singleton;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ServiceProviderInstance.GetInstance().GetServiceProvider();
            var creationalPatter = serviceProvider.GetService<ICreationalPattern>();

            creationalPatter.ShowDemo();

            Console.ReadKey();
        }
    }
}
