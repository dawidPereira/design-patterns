using DesignPatterns.CreationalPattern.Factory.Entity.Student;
using DesignPatterns.CreationalPattern.Factory.Entity.Teacher;

namespace DesignPatterns.CreationalPattern.Factory.AbstractFactory.Interface
{
    public interface ISchoolMemberFactory
    {
        Student CreateStudent();
        Teacher CreateTeacher();
    }
}
