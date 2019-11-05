using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatterns.StructuralPattern.Bridge;
using DesignPatterns.StructuralPattern.Common.Entity;
using DesignPatterns.StructuralPattern.Common.Enum;

namespace DesignPatterns.StructuralPattern.Flyweight
{
    public class MonsterFlyweightFactory
    {
        private readonly List<Tuple<Monster, int>> _flyweights = new List<Tuple<Monster, int>>();

        public Monster GetMonster(MonsterClass monsterClass, MonsterBehavior monsterBehavior)
        {
            var key = GetKey(monsterClass, monsterBehavior);

            if (_flyweights.All(x => x.Item2 != key))
            {
                Console.WriteLine("MonsterFlyweightFactory: Can't find a monster, creating new one.");
                Monster monster;

                switch (monsterBehavior)
                {
                    case MonsterBehavior.Fire:
                    monster = new Monster(new FireBehavior(), monsterClass);
                        break;

                    default:
                        monster = new Monster(new WaterBehavior(), monsterClass);
                        break;
                }

                _flyweights.Add(new Tuple<Monster, int>(monster, key));
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
            }

            return _flyweights.FirstOrDefault(t => t.Item2 == key)?.Item1;
        }

        private static int GetKey(MonsterClass monsterClass, MonsterBehavior monsterBehavior)
        {
            unchecked
            {
                var hash = 13;
                hash = (hash * 7) + monsterClass.GetHashCode();
                hash = (hash * 7) + (monsterBehavior.GetHashCode());
                return hash;
            }
        }

    }
}
