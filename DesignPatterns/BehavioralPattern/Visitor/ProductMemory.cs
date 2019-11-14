using System.Collections.Generic;
using static System.Console;

namespace DesignPatterns.BehavioralPattern.Visitor
{
    public class ProductMemory
    {
        private readonly List<Product> _products = new List<Product>();

        public void Attach(Product product) => _products.Add(product);

        public void Detach(Product product) => _products.Remove(product);

        public void Accept(IVisitor<Product> visitor)
        {
            foreach (var product in _products)
            {
                product.Accept(visitor);
            }
            
            WriteLine();
        }
    }
}