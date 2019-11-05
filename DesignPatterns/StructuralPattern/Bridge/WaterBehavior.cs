using System;

namespace DesignPatterns.StructuralPattern.Bridge
{
    public class WaterBehavior : IBehavior
    {
        public void PrimarySkill()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Throw water bubble !");
        }

        public void Defense()
        {
            Console.WriteLine("Self heal !");
        }
    }
}