using DesignPatterns.CreationalPattern.Factory;
using DesignPatterns.CreationalPattern.Factory.FactoryMethod.Implementation;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity
{
    public class FactoryDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var studentFactory = new StudentFactory();
            var polishStudent = studentFactory.Create(Language.Polish);
            var englishStudent = studentFactory.Create(Language.English);

            polishStudent.Greetings();
            englishStudent.Greetings();
        }
    }
}
