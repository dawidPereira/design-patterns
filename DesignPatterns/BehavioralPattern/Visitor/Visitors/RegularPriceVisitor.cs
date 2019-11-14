using static System.Console;

namespace DesignPatterns.BehavioralPattern.Visitor.Visitors
{
    public class RegularPriceVisitor : IVisitor<Product>
    {
        public void Visit(Product product)
        {
            product.ActualPrice = product.BasePrice;
            WriteLine($"{product.Name} price: {product.ActualPrice}");
        }
    }
}