using DesignPatterns.CreationalPattern.Factory;
using DesignPatterns.CreationalPattern.Factory.AbstractFactory.Interface;
using SchoolMemberFactoryResolver =
    DesignPatterns.CreationalPattern.Factory.AbstractFactory.AbstractFactoryDependencyInjectionConfigurator.SchoolMemberFactoryResolver;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity
{
    public class AbstractFactoryDemo : Demo
    {
        private readonly ISchoolMemberFactory _polishSchoolMemberFactory;

        public AbstractFactoryDemo(SchoolMemberFactoryResolver schoolMemberFactoryResolver)
        {
            _polishSchoolMemberFactory = schoolMemberFactoryResolver(Language.Polish);
        }

        protected override void ProcessDemo()
        {
            var abstractFactoryStudent = _polishSchoolMemberFactory.CreateStudent();

            abstractFactoryStudent.Greetings();
        }
    }
}
