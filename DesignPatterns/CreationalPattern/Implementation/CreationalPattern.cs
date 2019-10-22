using System;
using Microsoft.Extensions.DependencyInjection;
using DesignPatterns.CreationalPattern.Builder;
using DesignPatterns.CreationalPattern.Builder.Interface;
using DesignPatterns.CreationalPattern.Factory;
using DesignPatterns.CreationalPattern.Factory.AbstractFactory;
using DesignPatterns.CreationalPattern.Factory.AbstractFactory.Interface;
using DesignPatterns.CreationalPattern.Factory.FactoryMethod.Implementation;
using DesignPatterns.CreationalPattern.Interface;
using DesignPatterns.CreationalPattern.Prototype;
using DesignPatterns.CreationalPattern.Singleton;
using SchoolMemberFactoryResolver = 
    DesignPatterns.CreationalPattern.Factory.AbstractFactory.AbstractFactoryDependencyInjectionConfigurator.SchoolMemberFactoryResolver;

namespace DesignPatterns.CreationalPattern.Implementation
{
    public class CreationalPattern : ICreationalPattern
    {
        private readonly IServiceProvider _serviceProviderInstance;
        private readonly ISchoolMemberFactory _polishSchoolMemberFactory;

        private const string BurritoDemoName = "Burrito";
        private const string FactoryDemoName = "Factory";
        private const string AbstractFactoryDemoName = "AbstractFactory";
        private const string PrototypeDemoName = "Prototype";
        private const string SingletonDemoName = "Singleton";


        public CreationalPattern(SchoolMemberFactoryResolver schoolMemberFactoryResolver)
        {
            _serviceProviderInstance = ServiceProviderInstance.GetServiceProvider();
            _polishSchoolMemberFactory = schoolMemberFactoryResolver(Language.Polish);
        }

        public void ShowDemo()
        {
            BurritoDemo();
            FactoryDemo();
            AbstractFactoryDemo();
            PrototypeDemo();
            SingletonDemo();
        }

        private void BurritoDemo()
        {
            DemoMessageHelper.ShowStartDemoMessage(BurritoDemoName);

            var burritoDirector = _serviceProviderInstance.GetService<IBurritoDirector>();

            burritoDirector.BuildBurritoWithMeat(3, "Chicken", BurritoBuilderTypes.BurritoBuilder);
            burritoDirector.BuildVegeBurrito(1);

            DemoMessageHelper.ShowEndDemoMessage(BurritoDemoName);
        }

        private void FactoryDemo()
        {
            DemoMessageHelper.ShowStartDemoMessage(FactoryDemoName);

            var studentFactory = new StudentFactory();
            var polishStudent = studentFactory.Create(Language.Polish);
            var englishStudent = studentFactory.Create(Language.English);

            polishStudent.Greetings();
            englishStudent.Greetings();

            DemoMessageHelper.ShowEndDemoMessage(FactoryDemoName);
        }

        private void AbstractFactoryDemo()
        {
            DemoMessageHelper.ShowStartDemoMessage(AbstractFactoryDemoName);

            var schoolMemberFactory = SchoolMemberFactoryExtension.GetSchoolMemberFactory(
                Language.Polish, _serviceProviderInstance);
            var abstractFactoryStudent = schoolMemberFactory.CreateStudent();

            abstractFactoryStudent.Greetings();

            DemoMessageHelper.ShowEndDemoMessage(AbstractFactoryDemoName);
        }

        private void PrototypeDemo()
        {
            DemoMessageHelper.ShowStartDemoMessage(PrototypeDemoName);

            var monster = new Monster(1, 23, "Easy Monster");
            var shallowCopyMonster = monster.ShallowCopy();
            var deepCopyMonster = monster.DeepCopy();

            shallowCopyMonster.MonsterType.TypeName = "Easy Shallow Monster";
            shallowCopyMonster.Level = 2;

            deepCopyMonster.MonsterType.TypeName = "Easy Deep Monster";
            deepCopyMonster.Level = 3;

            Console.WriteLine(shallowCopyMonster.ToString());
            Console.WriteLine(deepCopyMonster.ToString());
            Console.WriteLine("Back to original monster.");

            monster.MonsterType.TypeName = "Easy Original Monster";
            monster.Level = 1;

            Console.WriteLine(shallowCopyMonster.ToString());
            Console.WriteLine(deepCopyMonster.ToString());

            DemoMessageHelper.ShowEndDemoMessage(PrototypeDemoName);
        }

        private void SingletonDemo()
        {
            DemoMessageHelper.ShowStartDemoMessage(SingletonDemoName);

            var firstSimpleConfiguration = SimpleConfiguration.GetInstance();
            var lastSimpleConfiguration = SimpleConfiguration.GetInstance();

            Console.WriteLine(firstSimpleConfiguration == lastSimpleConfiguration);

            DemoMessageHelper.ShowEndDemoMessage(SingletonDemoName);
        }

    }
}
