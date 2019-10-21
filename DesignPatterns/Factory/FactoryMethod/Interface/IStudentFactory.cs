using DesignPatterns.FactoryMethod;

namespace DesignPatterns.Factory.FactoryMethod.Interface
{
    public interface IStudentFactory
    {
        Student Create(SchoolMemberLanguage studentLanguage);
    }
}
