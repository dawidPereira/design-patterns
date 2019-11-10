namespace DesignPatterns.BehavioralPattern.Observer
{
    public interface IItem
    {
        void Attach(IDiscountSubscriber item);

        void Detach(IDiscountSubscriber restaurant);
    }
}