using System;

namespace DesignPatterns.BehavioralPattern.Observer
{
    public class Item : Observable<Item>
    {
        public double Price { get; private set; }

        public string Name { get; private set; }

        public Item(int price, string name)
        {
            Price = price;
            Name = name;
        }

        public void UpdatePrice(double newPrice)
        {
            Price = newPrice;
            Notify(this);
        }
    }
}