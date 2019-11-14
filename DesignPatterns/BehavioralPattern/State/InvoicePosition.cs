namespace DesignPatterns.BehavioralPattern.State
{
    public class InvoicePosition
    {
        public InvoicePosition(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; private set; }
        public double Price { get; private set; }
    }
}