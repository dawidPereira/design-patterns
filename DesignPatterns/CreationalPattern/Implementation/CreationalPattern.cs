using DesignPatterns.BehavioralPattern.TemplateMethod.Entity;
using DesignPatterns.CreationalPattern.Interface;
using SchoolMemberFactoryResolver = 
    DesignPatterns.CreationalPattern.Factory.AbstractFactory.AbstractFactoryDependencyInjectionConfigurator.SchoolMemberFactoryResolver;

namespace DesignPatterns.CreationalPattern.Implementation
{
    public class CreationalPattern : ICreationalPattern
    {
        private readonly BurritoDemo _burritoDemo;
        private readonly FactoryDemo _factoryDemo;
        private readonly PrototypeDemo _prototypeDemo;
        private readonly SingletonDemo _singletonDemo;
        private readonly AbstractFactoryDemo _abstractFactoryDemo;

        public CreationalPattern(SchoolMemberFactoryResolver schoolMemberFactoryResolver)
        {
            _burritoDemo = new BurritoDemo();
            _factoryDemo = new FactoryDemo();
            _prototypeDemo = new PrototypeDemo();
            _singletonDemo = new SingletonDemo();
            _abstractFactoryDemo = new AbstractFactoryDemo(schoolMemberFactoryResolver);
        }

        public void ShowDemo()
        {
            _burritoDemo.ShowDemo(DemoName.Burrito);
            _factoryDemo.ShowDemo(DemoName.Factory);
            _abstractFactoryDemo.ShowDemo(DemoName.AbstractFactory);
            _prototypeDemo.ShowDemo(DemoName.Prototype);
            _singletonDemo.ShowDemo(DemoName.Singleton);
        }
    }
}
