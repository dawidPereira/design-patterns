using System;
using DesignPatterns.CreationalPattern.Prototype;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.CreationalPattern
{
    public class PrototypeDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var monster = new Monster(1, 23, "Easy Monster");
            var shallowCopyMonster = monster.ShallowCopy();
            var deepCopyMonster = monster.DeepCopy();

            shallowCopyMonster.MonsterType.TypeName = "Easy Shallow Monster";
            shallowCopyMonster.Level = 2;

            deepCopyMonster.MonsterType.TypeName = "Easy Deep Monster";
            deepCopyMonster.Level = 3;

            Console.WriteLine(shallowCopyMonster.ToString());
            Console.WriteLine(deepCopyMonster.ToString());
            Console.WriteLine("Back to original monster.");

            monster.MonsterType.TypeName = "Easy Original Monster";
            monster.Level = 1;

            Console.WriteLine(shallowCopyMonster.ToString());
            Console.WriteLine(deepCopyMonster.ToString());
        }
    }
}
