using DesignPatterns.StructuralPattern.Common.Enum;

namespace DesignPatterns.BehavioralPattern.Command
{
    public class FireAttackCommand : AttackCommand
    {
        public FireAttackCommand() : base(MonsterBehavior.Fire)
        {
        }
    }
}