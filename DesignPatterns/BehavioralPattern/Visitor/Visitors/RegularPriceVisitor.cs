using System;

namespace DesignPatterns.BehavioralPattern.Visitor.Visitors
{
    public class RegularPriceVisitor : IVisitor<Product>
    {
        public void Visit(Product product)
        {
            product.ActualPrice = product.BasePrice;
            Console.WriteLine($"{product.Name} price: {product.ActualPrice}");
        }
    }
}