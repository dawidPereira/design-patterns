using DesignPatterns.StructuralPattern.Adapter;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.StructuralPattern
{
    public class AdapterDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var waterMonster = new WaterMonsterAdapter(new WaterMonster());

            waterMonster.Talk();
            waterMonster.Move();
            waterMonster.Attack();
            waterMonster.Talk();
            waterMonster.Defense();
            waterMonster.Talk();
        }
    }
}
