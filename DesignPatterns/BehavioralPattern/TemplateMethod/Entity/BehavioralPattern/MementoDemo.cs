using System;
using DesignPatterns.BehavioralPattern.Memento;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.BehavioralPattern
{
    public class MementoDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var score = new Score();
            var scoreMemory = new ScoreMemory();

            for (var i = 0; i < 3; i++)
            {
                scoreMemory.Backup(score);
                score.AddPoints();
            }

            Console.WriteLine($"Before Undo() | Points: {score.Points}, KillingSpree: {score.KillingSpree}, | LooseSpree: {score.LooseSpree}.");
            scoreMemory.Undo(score);
            Console.WriteLine($"After Undo() | Points: {score.Points}, KillingSpree: {score.KillingSpree}, | LooseSpree: {score.LooseSpree}.");

        }
    }
}