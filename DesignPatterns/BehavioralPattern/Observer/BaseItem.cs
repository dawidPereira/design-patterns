using System.Collections.Generic;

namespace DesignPatterns.BehavioralPattern.Observer
{
    public abstract class BaseItem : IItem
    {
        private readonly List<IDiscountSubscriber> _discountSubscribers = new List<IDiscountSubscriber>();

        public void Attach(IDiscountSubscriber item)
        {
            _discountSubscribers.Add(item);
        }

        public void Detach(IDiscountSubscriber restaurant)
        {
            _discountSubscribers.Remove(restaurant);
        }

        protected void Notify()
        {
            foreach (var item in _discountSubscribers)
            {
                item.Update(this);
            }
        }
    }
}