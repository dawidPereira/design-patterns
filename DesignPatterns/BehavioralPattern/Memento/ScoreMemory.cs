using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.BehavioralPattern.Memento
{
    public class ScoreMemory
    {
        private readonly List<ScoreMemento> _mementos = new List<ScoreMemento>();

        public void Backup(Score score)
        {
            Console.WriteLine("ScoreMemory: Saving state.");
            _mementos.Add(score.SaveMemento());
        }

        public void Undo (Score score)
        {
            if (_mementos.Count == 0) return;

            var memento = _mementos.Last();
            _mementos.Remove(memento);

            Console.WriteLine("ScoreMemory: Restoring state.");

            score.RestoreMemento(memento);
        }
    }
}