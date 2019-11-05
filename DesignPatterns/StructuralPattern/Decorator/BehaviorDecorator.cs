using DesignPatterns.StructuralPattern.Bridge;

namespace DesignPatterns.StructuralPattern.Decorator
{
    public class BehaviorDecorator : IBehavior
    {
        private readonly IBehavior _behavior;

        public BehaviorDecorator(IBehavior behavior)
        {
            _behavior = behavior;
        }

        public virtual void PrimarySkill() => _behavior?.PrimarySkill();

        public virtual void Defense() => _behavior.Defense();
    }
}
