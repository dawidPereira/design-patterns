using DesignPatterns.BehavioralPattern.Visitor;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.BehavioralPattern
{
    public class VisitorDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var productMemory = new ProductMemory();
            productMemory.Attach(new Product("PC", 2999));
            productMemory.Attach(new Product("Car", 29999));
            productMemory.Attach(new Product("Headphone", 99));

            productMemory.Accept(new DiscountPriceVisitor());
            productMemory.Accept(new RegularPriceVisitor());
            productMemory.Accept(new DiscountPriceVisitor());
            productMemory.Accept(new BasePriceVisitor());
            productMemory.Accept(new RegularPriceVisitor());
        }
    }
}