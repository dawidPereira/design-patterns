namespace DesignPatterns.BehavioralPattern.Visitor
{
    public class Product
    {
        public string Name { get; set; }
        public double ActualPrice { get; set; }
        public double BasePrice { get; set; }

        public Product(string name, double actualPrice)
        {
            Name = name;
            ActualPrice = actualPrice;
            BasePrice = actualPrice;
        }

        public void Accept(IVisitor<Product> visitor)
        {
            visitor.Visit(this);
        }
    }
}
