using DesignPatterns.Factory.Entity.Teacher;
using DesignPatterns.FactoryMethod;

namespace DesignPatterns.Factory.AbstractFactory.Interface
{
    public interface IShoolMemberFactory
    {
        Student CreateStudent();
        Teacher CreateTeacher();
    }
}
