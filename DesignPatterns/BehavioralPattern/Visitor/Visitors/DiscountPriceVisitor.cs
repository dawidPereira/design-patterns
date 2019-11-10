using System;

namespace DesignPatterns.BehavioralPattern.Visitor.Visitors
{
    public class DiscountPriceVisitor : IVisitor<Product>
    {
        public void Visit(Product product)
        {
            product.ActualPrice *= 0.9;
            Console.WriteLine($"{product.Name} price: {product.ActualPrice}");
        }
    }
}