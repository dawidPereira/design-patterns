using System;
using DesignPatterns.CreationalPattern.Builder;
using DesignPatterns.CreationalPattern.Builder.Interface;
using DesignPatterns.CreationalPattern.Factory;
using DesignPatterns.CreationalPattern.Factory.AbstractFactory;
using DesignPatterns.CreationalPattern.Factory.FactoryMethod.Implementation;
using DesignPatterns.CreationalPattern.Prototype;
using DesignPatterns.CreationalPattern.Singleton;
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

            Console.WriteLine();


            var studentFactory = new StudentFactory();
            var polishStudent = studentFactory.Create(SchoolMemberLanguage.PolishStudent);
            var englishStudent = studentFactory.Create(SchoolMemberLanguage.EnglishStudent);

            polishStudent.Greetings();
            englishStudent.Greetings();

            var schoolMemberFactory = SchoolMemberFactoryExtension.GetSchoolMemberFactory(SchoolMemberLanguage.PolishStudent, serviceProvider);
            var abstractFactoryStudent = schoolMemberFactory.CreateStudent();

            abstractFactoryStudent.Greetings();

            Console.WriteLine();
            var monster = new Monster(1, 23, "Easy Monster");
            var shallowCopyMonster = monster.ShallowCopy();
            shallowCopyMonster.MonsterType.TypeName = "Easy Shallow Monster";
            shallowCopyMonster.Level = 2;
            var deepCopyMonster = monster.DeepCopy();
            deepCopyMonster.MonsterType.TypeName = "Easy Deep Monster";
            deepCopyMonster.Level = 3;


            Console.WriteLine(shallowCopyMonster.ToString());
            Console.WriteLine(deepCopyMonster.ToString());
            Console.WriteLine("Back to original monster.");
            monster.MonsterType.TypeName = "Easy Original Monster";
            monster.Level = 1;

            Console.WriteLine(shallowCopyMonster.ToString());
            Console.WriteLine(deepCopyMonster.ToString());

            Console.WriteLine();

            var firstSimpleConfiguration = SimpleConfiguration.GetInstance();
            var lastSimpleConfiguration = SimpleConfiguration.GetInstance();

            Console.WriteLine(firstSimpleConfiguration == lastSimpleConfiguration);


            Console.ReadKey();
        }
    }
}
