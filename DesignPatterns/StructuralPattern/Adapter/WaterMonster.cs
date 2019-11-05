using System;

namespace DesignPatterns.StructuralPattern.Adapter
{
    public class WaterMonster
    {
        private readonly Random _random = new Random();

        public void Swim()
        {
            Console.WriteLine($"WaterMonster move for {_random.Next(5)} field.");
        }

        public void Bite()
        {
            Console.WriteLine($"WaterMonster deal {_random.Next(10)} damage points.");
        }

        public void AbsorbDamage()
        {
            Console.WriteLine($"WaterMonster absorb {_random.Next(10)} damage points.");
        }
    }
}