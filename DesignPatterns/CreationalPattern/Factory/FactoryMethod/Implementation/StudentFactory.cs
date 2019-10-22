using DesignPatterns.CreationalPattern.Factory.Entity.Student;
using DesignPatterns.CreationalPattern.Factory.FactoryMethod.Interface;

namespace DesignPatterns.CreationalPattern.Factory.FactoryMethod.Implementation
{
    public class StudentFactory : IStudentFactory
    {
        public Student Create(Language studentLanguage)
        {
            switch (studentLanguage)
            {
                case Language.Polish:
                    return PolishStudent.Create();

                case Language.English:
                    return EnglishStudent.Create();

                default:
                    return null;
            }

        }
    }
}
