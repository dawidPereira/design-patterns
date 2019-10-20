using DesignPatterns.FactoryMethod.Interface;

namespace DesignPatterns.FactoryMethod.Implementation
{
    public class StudentFactory : IStudentFactory
    {
        public Student Create(StudentType studentType)
        {
            Student student = null;
            switch (studentType)
            {
                case StudentType.PolishStudent:
                    student = PolishStudent.Create();
                    break;

                case StudentType.EnglishStudent:
                    student = EnglishStudent.Create();
                    break;
            }

            return student;
        }
    }
}
