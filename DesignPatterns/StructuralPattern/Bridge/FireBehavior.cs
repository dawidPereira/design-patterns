using System;

namespace DesignPatterns.StructuralPattern.Bridge
{
    public class FireBehavior : IBehavior
    {
        public void PrimarySkill()
        {
            Console.WriteLine("Throw fireball !");
        }

        public void Defense()
        {
            Console.WriteLine("Fire Shield !");
        }
    }
}