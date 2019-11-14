using static System.Console;

namespace DesignPatterns.BehavioralPattern.Observer
{
    public class DiscountObserver : IObserver<Item>
    {
        private readonly string _name;

        private readonly double _buyPrice;

        public DiscountObserver(string name, double itemPrice, double minimumDiscountAmount)
        {
            _name = name;
            _buyPrice = itemPrice - (itemPrice * minimumDiscountAmount);
        }

        public void Notify(Item item)
        {
            WriteLine(
                item.Price <= _buyPrice
                    ? $"{_name} buy {item.Name}."
                    : $"{_name} don't 'buy {item?.Name}.");
        }
    }
}