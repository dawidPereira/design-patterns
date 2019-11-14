using static System.Console;

namespace DesignPatterns.BehavioralPattern.Visitor.Visitors
{
    public class BasePriceVisitor : IVisitor<Product>
    {
        public void Visit(Product product)
        {
            product.BasePrice = product.ActualPrice;
            WriteLine($"{product.Name} price: {product.ActualPrice}");
        }
    }
}