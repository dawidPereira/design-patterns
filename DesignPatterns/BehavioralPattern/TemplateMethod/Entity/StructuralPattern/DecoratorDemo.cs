using DesignPatterns.StructuralPattern.Bridge;
using DesignPatterns.StructuralPattern.Common.Entity;
using DesignPatterns.StructuralPattern.Decorator;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.StructuralPattern
{
    public class DecoratorDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var fireEnhancedMonster = new Monster(new EnhancedFireBehavior(new FireBehavior()));

            fireEnhancedMonster.Attack();
            fireEnhancedMonster.Defense();
        }
    }
}