using System.Collections.Generic;
using DesignPatterns.BehavioralPattern.Observer;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.BehavioralPattern
{
    public class ObserverDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var item = new Item(299, "Keyboard");
            var subscribers = new List<DiscountObserver>
            {
                new DiscountObserver("Emanule", item.Price, 0.1),
                new DiscountObserver("Jason", item.Price, 0.05),
                new DiscountObserver("Somebady", item.Price, 0.25)
            };

            foreach (var discountSubscriber in subscribers)
            {
                item.Subscribe(discountSubscriber);
            }

            item.UpdatePrice(249);
        }
    }
}