using System;
using DesignPatterns.Builder;
using DesignPatterns.Builder.Interface;
using DesignPatterns.FactoryMethod;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection().Configure();
            var burritoDirector = serviceProvider.GetService<IBurritoDirector>();

            burritoDirector.BuildBurritoWithMeat(3, "Chicken", BurritoBuilderTypes.BurritoBuilder);
            burritoDirector.BuildVegeBurrito(1);

            var polishStudent = PolishStudent.Create();
            var englishStudent = EnglishStudent.Create();

            polishStudent.Greetings();
            englishStudent.Greetings();


            Console.ReadKey();
        }
    }
}
