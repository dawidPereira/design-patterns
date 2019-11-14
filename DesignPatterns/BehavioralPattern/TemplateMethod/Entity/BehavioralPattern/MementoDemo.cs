using DesignPatterns.BehavioralPattern.Memento;
using static System.Console;

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

            WriteLine($"Before Undo() | Points: {score.Points}, KillingSpree: {score.KillingSpree}, | LooseSpree: {score.LooseSpree}.");
            scoreMemory.Undo(score);
            WriteLine($"After Undo() | Points: {score.Points}, KillingSpree: {score.KillingSpree}, | LooseSpree: {score.LooseSpree}.");

        }
    }
}