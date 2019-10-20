using DesignPatterns.Factory.FactoryMethod.Interface;
using DesignPatterns.FactoryMethod;

namespace DesignPatterns.Factory.FactoryMethod.Implementation
{
    public class StudentFactory : IStudentFactory
    {
        public Student Create(ShoolMemberType studentType)
        {
            Student student = null;
            switch (studentType)
            {
                case ShoolMemberType.PolishStudent:
                    student = PolishStudent.Create();
                    break;

                case ShoolMemberType.EnglishStudent:
                    student = EnglishStudent.Create();
                    break;
            }

            return student;
        }
    }
}
