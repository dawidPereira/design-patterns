using System;

namespace DesignPatterns.BehavioralPattern.Visitor
{
    public class RegularPriceVisitor : IVisitor
    {
        public void Visit(object visited)
        {
            if (!(visited is Product product))
            {
                return;
            }

            product.ActualPrice = product.BasePrice;
            Console.WriteLine($"{product.Name} price: {product.ActualPrice}");
        }
    }
}