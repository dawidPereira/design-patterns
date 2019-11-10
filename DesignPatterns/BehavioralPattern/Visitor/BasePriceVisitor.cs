using System;

namespace DesignPatterns.BehavioralPattern.Visitor
{
    public class BasePriceVisitor : IVisitor
    {
        public void Visit(object visited)
        {
            if (!(visited is Product product))
            {
                return;
            }

            product.BasePrice = product.ActualPrice;
            Console.WriteLine($"{product.Name} price: {product.ActualPrice}");
        }
    }
}