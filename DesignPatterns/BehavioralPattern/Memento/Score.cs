namespace DesignPatterns.BehavioralPattern.Memento
{
    public class Score
    {
        public int Points { get; protected set; }

        public int KillingSpree { get; set; }

        public int LooseSpree { get; set; }

        public ScoreMemento SaveMemento()
        {
            return new ScoreMemento(this);
        }

        public void RestoreMemento(ScoreMemento memento)
        {
            Points = memento.Points;
            KillingSpree = memento.KillingSpree;
            LooseSpree = memento.LooseSpree;
        }

        public void AddPoints()
        {
            if (KillingSpree >= 3) Points += KillingSpree;
            else Points++;
            KillingSpree++;
        }

        public void RemovePoints()
        {
            if (LooseSpree >= 3) Points -= KillingSpree;
            else Points--;
            LooseSpree--;
        }
    }
}
