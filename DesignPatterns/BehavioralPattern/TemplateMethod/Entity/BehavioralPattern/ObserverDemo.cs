using System.Collections.Generic;
using DesignPatterns.BehavioralPattern.Observer;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.BehavioralPattern
{
    public class ObserverDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var item = new Item(299, "Keyboard");
            var subscribers = new List<DiscountSubscriber>
            {
                new DiscountSubscriber("Emanule", item.Price, 0.1),
                new DiscountSubscriber("Jason", item.Price, 0.05),
                new DiscountSubscriber("Somebady", item.Price, 0.25)
            };

            foreach (var discountSubscriber in subscribers)
            {
                item.Attach(discountSubscriber);
            }

            item.UpdatePrice(249);
        }
    }
}