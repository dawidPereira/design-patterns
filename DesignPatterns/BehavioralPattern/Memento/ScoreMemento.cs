namespace DesignPatterns.BehavioralPattern.Memento
{
    public class ScoreMemento : Score
    {
        public ScoreMemento(Score score)
        {
            Points = score.Points;
            KillingSpree = score.KillingSpree;
            LooseSpree = score.LooseSpree;
        }
    }
}