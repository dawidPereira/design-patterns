using System;
using DesignPatterns.CreationalPattern.Interface;
using DesignPatterns.CreationalPattern.Singleton;
using DesignPatterns.StructuralPattern.Adapter;
using DesignPatterns.StructuralPattern.Bridge;
using DesignPatterns.StructuralPattern.Decorator;
using DesignPatterns.StructuralPattern.Facade;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //var serviceProvider = ServiceProviderInstance.GetInstance().GetServiceProvider();
            //var creationalPatter = serviceProvider.GetService<ICreationalPattern>();

            //creationalPatter.ShowDemo();

            var normalBehavior = new FireBehavior();
            var enhancedBehavior = new EnhancedFireBehavior(normalBehavior);

            normalBehavior.PrimarySkill();
            enhancedBehavior.PrimarySkill();

            new LoginFacade().LogIn();

            Console.ReadKey();
        }
    }
}
