using DesignPatterns.StructuralPattern.Common.Enum;

namespace DesignPatterns.BehavioralPattern.Command
{
    public class WaterAttackCommand : AttackCommand
    {
        public WaterAttackCommand() : base(MonsterBehavior.Water)
        {
        }
    }
}