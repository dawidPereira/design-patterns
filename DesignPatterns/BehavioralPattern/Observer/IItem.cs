namespace DesignPatterns.BehavioralPattern.Observer
{
    public interface IItem
    {
        double Price { get; }

        string Name { get; }

        void Attach(IDiscountSubscriber item);

        void Detach(IDiscountSubscriber restaurant);

        void UpdatePrice(double newPrice);
    }
}