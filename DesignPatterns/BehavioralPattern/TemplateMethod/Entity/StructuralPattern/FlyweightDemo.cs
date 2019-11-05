using System;
using System.Diagnostics;
using DesignPatterns.StructuralPattern.Bridge;
using DesignPatterns.StructuralPattern.Common.Entity;
using DesignPatterns.StructuralPattern.Common.Enum;
using DesignPatterns.StructuralPattern.Flyweight;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.StructuralPattern
{
    public class FlyweightDemo : Demo
    {
        private Monster _monster;
        private int _monsterCount;
        private readonly Random _random = new Random();
        private readonly MonsterFlyweightFactory _monsterFactory = new MonsterFlyweightFactory();

        protected override void ProcessDemo()
        {
            WithoutFlyweight(out var withoutFlyweightTime);
            WithFlyweight(out var withFlyweightTime);

            Console.WriteLine(withoutFlyweightTime);
            Console.WriteLine(withFlyweightTime);
        }

        private void WithoutFlyweight(out long withoutFlyweightTime)
        {
            var stopWatch = new Stopwatch();
            _monsterCount = 0;
            stopWatch.Start();

            for (var i = 0; i < 10000; i++)
            {
                var monsterClass = (MonsterClass)_random.Next(10);

                _monster = _random.Next(2) > 1
                    ? new Monster(new FireBehavior(), monsterClass) : new Monster(new WaterBehavior(), monsterClass);

                Console.WriteLine($"Monster class: {_monster.MonsterClass.ToString()}.");

                if (_monster != null)
                {
                    _monsterCount++;
                }
            }

            stopWatch.Stop();

            withoutFlyweightTime = stopWatch.ElapsedMilliseconds;
        }

        private void WithFlyweight(out long withFlyweightTime)
        {
            var stopWatch = new Stopwatch();
            _monsterCount = 0;
            stopWatch.Start();

            for (var i = 0; i < 10000; i++)
            {
                var monsterClass = (MonsterClass)_random.Next(10);
                var monsterBehavior = (MonsterBehavior)_random.Next(2);

                _monster = _monsterFactory.GetMonster(monsterClass, monsterBehavior);

                Console.WriteLine($"Monster class: {_monster.MonsterClass.ToString()}.");


                if (_monster != null)
                {
                    _monsterCount++;
                }
            }

            stopWatch.Stop();

            withFlyweightTime = stopWatch.ElapsedMilliseconds;
        }
    }
}