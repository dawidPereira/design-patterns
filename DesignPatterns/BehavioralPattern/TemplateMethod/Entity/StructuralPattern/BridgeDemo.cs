using DesignPatterns.StructuralPattern.Bridge;
using DesignPatterns.StructuralPattern.Common.Entity;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.StructuralPattern
{
    public class BridgeDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var waterMonster = new Monster(new WaterBehavior());
            var fireMonster = new Monster(new FireBehavior());

            waterMonster.Attack();
            waterMonster.Defense();
            fireMonster.Attack();
            fireMonster.Defense();
        }
    }
}