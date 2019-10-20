namespace DesignPatterns.FactoryMethod.Interface
{
    public interface IStudentFactory
    {
        Student Create(StudentType studentType);
    }
}
