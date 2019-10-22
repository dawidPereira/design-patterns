using DesignPatterns.CreationalPattern.Factory.Entity.Student;

namespace DesignPatterns.CreationalPattern.Factory.FactoryMethod.Interface
{
    public interface IStudentFactory
    {
        Student Create(Language studentLanguage);
    }
}
