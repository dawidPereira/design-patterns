using DesignPatterns.Factory.AbstractFactory.Interface;
using DesignPatterns.Factory.Entity.Teacher;
using DesignPatterns.FactoryMethod;

namespace DesignPatterns.Factory.AbstractFactory.Implementation
{
    public class EnglishShoolMemberFactory : IShoolMemberFactory
    {
        public Student CreateStudent()
        {
            return EnglishStudent.Create();
        }

        public Teacher CreateTeacher()
        {
            return EnglishTeacher.Create();
        }
    }
}
