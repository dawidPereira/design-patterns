using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace DesignPatterns.BehavioralPattern.Memento
{
    public class ScoreMemory
    {
        private readonly List<ScoreMemento> _mementos = new List<ScoreMemento>();

        public void Backup(Score score)
        {
            WriteLine("ScoreMemory: Saving state.");
            _mementos.Add(score.SaveMemento());
        }

        public void Undo (Score score)
        {
            if (_mementos.Count == 0) return;

            var memento = _mementos.Last();
            
            _mementos.Remove(memento);

            WriteLine("ScoreMemory: Restoring state.");

            score.RestoreMemento(memento);
        }
    }
}