using DesignPatterns.CreationalPattern.Factory.Entity.Student;
using DesignPatterns.CreationalPattern.Factory.FactoryMethod.Interface;

namespace DesignPatterns.CreationalPattern.Factory.FactoryMethod.Implementation
{
    public class StudentFactory : IStudentFactory
    {
        public Student Create(SchoolMemberLanguage studentLanguage)
        {
            switch (studentLanguage)
            {
                case SchoolMemberLanguage.PolishStudent:
                    return PolishStudent.Create();

                case SchoolMemberLanguage.EnglishStudent:
                    return EnglishStudent.Create();

                default:
                    return null;
            }

        }
    }
}
