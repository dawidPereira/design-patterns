using System;
using System.Diagnostics;
using DesignPatterns.CreationalPattern.Interface;
using DesignPatterns.CreationalPattern.Singleton;
using DesignPatterns.StructuralPattern.Adapter;
using DesignPatterns.StructuralPattern.Bridge;
using DesignPatterns.StructuralPattern.Common.Entity;
using DesignPatterns.StructuralPattern.Common.Enum;
using DesignPatterns.StructuralPattern.Decorator;
using DesignPatterns.StructuralPattern.Facade;
using DesignPatterns.StructuralPattern.Flyweight;
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

            var random = new Random();

            var stopWatchOne = new Stopwatch();
            var stopWatchTwo = new Stopwatch();
            var monsterFactory = new MonsterFlyweightFactory();
            Monster monster;

            stopWatchOne.Start();

            for (var i = 0; i < 100000; i++)
            {
                var monsterClass = (MonsterClass) random.Next(10);

                monster = random.Next(2) > 1 
                    ? new Monster(new FireBehavior(), monsterClass) : new Monster(new WaterBehavior(), monsterClass);

                Console.WriteLine(monster.ToString());
            }

            stopWatchOne.Stop();
            stopWatchTwo.Start();
            
            for (var i = 0; i < 100000; i++)
            {
                var monsterClass = (MonsterClass)random.Next(10);
                var monsterBehavior = (MonsterBehavior) random.Next(2);

                monster = monsterFactory.GetMonster(monsterClass, monsterBehavior);

                Console.WriteLine(monster.ToString());
            }

            stopWatchTwo.Stop();

            Console.WriteLine(stopWatchOne.ElapsedMilliseconds);
            Console.WriteLine(stopWatchTwo.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }
}
