using DesignPatterns.StructuralPattern.Bridge;
using DesignPatterns.StructuralPattern.Common.Enum;

namespace DesignPatterns.StructuralPattern.Common.Entity
{
    public class Monster : IMonster
    {
        private readonly IBehavior _behavior;

        public readonly MonsterClass MonsterClass;

        public Monster(IBehavior behavior, MonsterClass monsterClass = MonsterClass.Warrior)
        {
            _behavior = behavior;
            MonsterClass = monsterClass;
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