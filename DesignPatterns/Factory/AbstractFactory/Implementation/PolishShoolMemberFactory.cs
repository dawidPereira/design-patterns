using DesignPatterns.Factory.AbstractFactory.Interface;
using DesignPatterns.Factory.Entity.Teacher;
using DesignPatterns.FactoryMethod;

namespace DesignPatterns.Factory.AbstractFactory.Implementation
{
    public class PolishShoolMemberFactory : IShoolMemberFactory
    {
        public Student CreateStudent()
        {
            return PolishStudent.Create();
        }

        public Teacher CreateTeacher()
        {
            return PolishTeacher.Create();
        }
    }
}
