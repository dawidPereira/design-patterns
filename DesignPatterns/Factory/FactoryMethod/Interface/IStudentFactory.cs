namespace DesignPatterns.FactoryMethod.Interface
{
    public interface IStudentFactory
    {
        Student Create(ShoolMemberType studentType);
    }
}
