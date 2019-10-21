using DesignPatterns.Factory.FactoryMethod.Interface;
using DesignPatterns.FactoryMethod;

namespace DesignPatterns.Factory.FactoryMethod.Implementation
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
