using System;
using System.Collections.Generic;

namespace DesignPatterns.BehavioralPattern.Observer
{
    public class Item : IItem
    {
        private readonly List<IDiscountSubscriber> _discountSubscribers = new List<IDiscountSubscriber>();

        public double Price { get; private set; }

        public string Name { get; private set; }

        public Item(int price, string name)
        {
            Price = price;
            Name = name;
        }

        public void Attach(IDiscountSubscriber item)
        {
            _discountSubscribers.Add(item);
        }

        public void Detach(IDiscountSubscriber restaurant)
        {
            _discountSubscribers.Remove(restaurant);
        }

        public void UpdatePrice(double newPrice)
        {
            Price = newPrice;
            Notify();
        }

        private void Notify()
        {
            foreach (var item in _discountSubscribers)
            {
                item.Update(this);
            }

            Console.WriteLine("");
        }
    }
}