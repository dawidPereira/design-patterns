using DesignPatterns.CreationalPattern.Factory.AbstractFactory.Interface;
using DesignPatterns.CreationalPattern.Factory.Entity.Student;
using DesignPatterns.CreationalPattern.Factory.Entity.Teacher;

namespace DesignPatterns.CreationalPattern.Factory.AbstractFactory.Implementation
{
    public class EnglishSchoolMemberFactory : ISchoolMemberFactory
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
