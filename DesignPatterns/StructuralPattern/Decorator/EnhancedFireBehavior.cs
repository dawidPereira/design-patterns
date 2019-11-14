using System;
using DesignPatterns.StructuralPattern.Bridge;

namespace DesignPatterns.StructuralPattern.Decorator
{
    public class EnhancedFireBehavior : BehaviorDecorator
    {
        public EnhancedFireBehavior(IBehavior behavior) : base (behavior)
        {
        }

        public override void PrimarySkill()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enhanced power !");
            base.PrimarySkill();
            Console.ForegroundColor = ConsoleColor.White;

        }

        public override void Defense()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enhanced power !");
            base.PrimarySkill();
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
