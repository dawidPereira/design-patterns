using System;
using DesignPatterns.Builder;
using DesignPatterns.Builder.Interface;
using DesignPatterns.Factory;
using DesignPatterns.Factory.AbstractFactory;
using DesignPatterns.Factory.FactoryMethod;
using DesignPatterns.Factory.FactoryMethod.Implementation;
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

            var studentFactory = new StudentFactory();
            var polishStudent = studentFactory.Create(SchoolMemberType.PolishStudent);
            var englishStudent = studentFactory.Create(SchoolMemberType.EnglishStudent);

            polishStudent.Greetings();
            englishStudent.Greetings();

            var schoolMemberFactory = SchoolMemberFactoryExtension.GetSchoolMemberFactory(SchoolMemberType.PolishStudent, serviceProvider);
            var abstractFactoryStudent = schoolMemberFactory.CreateStudent();

            abstractFactoryStudent.Greetings();

            Console.ReadKey();
        }
    }
}
