using DesignPatterns.CreationalPattern.Factory.AbstractFactory.Interface;
using DesignPatterns.CreationalPattern.Factory.Entity.Student;
using DesignPatterns.CreationalPattern.Factory.Entity.Teacher;

namespace DesignPatterns.CreationalPattern.Factory.AbstractFactory.Implementation
{
    public class PolishSchoolMemberFactory : ISchoolMemberFactory
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
