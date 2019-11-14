using static System.Console;

namespace DesignPatterns.BehavioralPattern.Visitor.Visitors
{
    public class DiscountPriceVisitor : IVisitor<Product>
    {
        public void Visit(Product product)
        {
            product.ActualPrice *= 0.9;
            WriteLine($"{product.Name} price: {product.ActualPrice}");
        }
    }
}