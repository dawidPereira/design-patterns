namespace DesignPatterns.BehavioralPattern.Visitor
{
    public interface IVisitor<in T>
    {
        void Visit(T visited);
    }
}