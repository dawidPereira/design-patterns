using System;
using DesignPatterns.StructuralPattern.Common.Entity;

namespace DesignPatterns.StructuralPattern.Adapter
{
    public class MonsterAdapter : IMonster, IHumanoid
    {
        private readonly Random _random = new Random();
        private readonly WaterMonster _waterMonster;

        public MonsterAdapter(WaterMonster waterMonster)
        {
            _waterMonster = waterMonster;
        }
        public void Move()
        {
            _waterMonster.Swim();
        }

        public void Talk()
        {
            var sentenceNumber = _random.Next(5);
            OceanVoices.OceanVoice.TryGetValue(sentenceNumber, out var sentence);
            Console.WriteLine(sentence);
        }

        public void Attack()
        {
            _waterMonster.Bite();
        }

        public void Defense()
        {
            _waterMonster.AbsorbDamage();
        }
    }
}