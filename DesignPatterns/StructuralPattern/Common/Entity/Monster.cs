using DesignPatterns.StructuralPattern.Bridge;

namespace DesignPatterns.StructuralPattern.Common.Entity
{
    public class Monster : IMonster
    {
        private readonly IBehavior _behavior;

        public Monster(IBehavior behavior)
        {
            _behavior = behavior;
        }

        public void Attack()
        {
            _behavior.PrimarySkill();
        }

        public void Defense()
        {
            _behavior.Defense();
        }
    }
}