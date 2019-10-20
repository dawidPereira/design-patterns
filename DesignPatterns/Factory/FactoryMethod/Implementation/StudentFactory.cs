using DesignPatterns.Factory.FactoryMethod.Interface;
using DesignPatterns.FactoryMethod;

namespace DesignPatterns.Factory.FactoryMethod.Implementation
{
    public class StudentFactory : IStudentFactory
    {
        public Student Create(SchoolMemberType studentType)
        {
            Student student = null;
            switch (studentType)
            {
                case SchoolMemberType.PolishStudent:
                    student = PolishStudent.Create();
                    break;

                case SchoolMemberType.EnglishStudent:
                    student = EnglishStudent.Create();
                    break;
            }

            return student;
        }
    }
}
