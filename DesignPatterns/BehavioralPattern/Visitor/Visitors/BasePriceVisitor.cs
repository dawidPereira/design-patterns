using System;

namespace DesignPatterns.BehavioralPattern.Visitor.Visitors
{
    public class BasePriceVisitor : IVisitor<Product>
    {
        public void Visit(Product product)
        {
            product.BasePrice = product.ActualPrice;
            Console.WriteLine($"{product.Name} price: {product.ActualPrice}");
        }
    }
}