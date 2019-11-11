using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.BehavioralPattern.Mediator
{
    public class Mediator
    {
        private readonly HashSet<Colleague> _colleagues;

        public Mediator()
        {
            _colleagues = new HashSet<Colleague>();
        }

        public void SendMessage(string message, Colleague colleague)
        {
            var tempColleague = _colleagues.FirstOrDefault(x => x.Equals(colleague));

            if (tempColleague == null)
            {
                tempColleague = colleague;
                Attach(tempColleague);
            }

            foreach (var specificColleague in _colleagues
                .Where(specificColleague => 
                    !specificColleague.Equals(colleague)))
            {
                specificColleague.Notify(message);
            }
        }

        public void Attach(Colleague colleague)
        {
            _colleagues.Add(colleague);
        }

        public void Detach(Colleague colleague)
        {
            _colleagues.Remove(colleague);
        }
    }
}