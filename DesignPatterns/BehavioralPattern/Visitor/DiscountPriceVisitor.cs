using System;

namespace DesignPatterns.BehavioralPattern.Visitor
{
    public class DiscountPriceVisitor : IVisitor
    {
        public void Visit(object visited)
        {
            if (!(visited is Product product))
            {
                return;
            }

            product.ActualPrice *= 0.9;
            Console.WriteLine($"{product.Name} price: {product.ActualPrice}");
        }
    }
}