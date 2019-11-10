using System;

namespace DesignPatterns.BehavioralPattern.Observer
{
    public class DiscountSubscriber : IDiscountSubscriber
    {
        private readonly string _name;

        private readonly double _buyPrice;

        public DiscountSubscriber(string name, double itemPrice, double minimumDiscountAmount)
        {
            _name = name;
            _buyPrice = itemPrice - (itemPrice * minimumDiscountAmount);
        }

        public void Update(IItem item)
        {
            Console.WriteLine(
                item.Price <= _buyPrice 
                    ? $"{_name} buy {item.Name}." 
                    : $"{_name} don't 'buy {item.Name}.");
        }
    }
}